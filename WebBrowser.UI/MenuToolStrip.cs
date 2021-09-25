using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class MenuToolStrip : UserControl
    {
        public MenuToolStrip()
        {
            InitializeComponent();
        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(AddressTextbox.Text) || AddressTextbox.Text.Equals("about:blank"))
            {
                MessageBox.Show("Whoa Nully! Hold your horses. I need something to work with.");
                AddressTextbox.Focus();
                return;
            }
            webBrowser1.Navigate(AddressTextbox.ToString());
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void AddressTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GoButton_Click(sender, e);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }      
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }
        private void BookmarkButton_Click(object sender, EventArgs e)
        {
            var item = new BookmarkItem();
            item.URL = AddressTextbox.Text;
            item.Title = webBrowser1.Document.Title;

            BookmarkManager.AddItem(item);

            item.URL = "";
            item.Title = "";
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (this.toolStripProgressBar1.Value < this.toolStripProgressBar1.Maximum)
            {
                toolStripStatusLabel1.Text = "Loading";
                while (this.toolStripProgressBar1.Value < this.toolStripProgressBar1.Maximum)
                {
                    this.toolStripProgressBar1.Value++;
                }
            }

            else
            {
                toolStripStatusLabel1.Text = "Done";
                this.toolStripProgressBar1.Value = 0;
            }

            return;
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            var item = new HistoryItem();
            item.Date = DateTime.Now;
            item.URL = AddressTextbox.Text;
            item.Title = webBrowser1.Document.Title;

            HistoryManager.AddItem(item);

            //try { AddressTextbox.Text = webBrowser1.Url.ToString(); }
            //catch (Exception nu) { return; }
            // UPDATES ADDRESSTEXTBOX BUT BREAKS: System.Data.ConstraintException on BookmarkButton_Click

            // How to clear time? What a concept. DateTime is non-nullable.
            item.URL = "";
            item.Title = "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Howdy! Howdy!\n\nThis web browser was made and is maintained"
            + " by Leticia Garcia. For Auburn's reference, that's LZG0052. This "
            + "is an ongoing project that has a 3-tier design. Feel free to "
            + "ask me about it. \n\nAs an up-and-coming application developer, I "
            + "look forward to working in collaborative environments and growing "
            + "in knowledge and skill. I would love feedback on this project "
            + "and to engage in new opportunities. \n\nFind me on LinkedIn "
            + "and GitHub!\nhttps://www.linkedin.com/in/leticia825"
            + "\nhttps://github.com/leticia825");
        }



        /////////////////////////////////////////////////////////////////////////
        ////////////////////////// Empty methods below //////////////////////////
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e) { }
            
        private void AddressTextbox_Click(object sender, EventArgs e) { }
        
    }
}
