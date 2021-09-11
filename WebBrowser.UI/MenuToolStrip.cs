using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class MenuToolStrip : UserControl
    {


        public MenuToolStrip()
        {
            InitializeComponent();
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

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(AddressTextbox.ToString());
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            //MessageBox.Show("refreshed");
        }

        private void AddressTextbox_Click(object sender, EventArgs e)
        {

        }

        private void AddressTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(AddressTextbox.Text);
            }
        }
    }
}
