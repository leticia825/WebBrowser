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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e) 
        {
            var items = HistoryManager.GetItem(); 
            HistoryListBox.Items.Clear();

            foreach (var item in items)
            {
                HistoryListBox.Items.Add(string.Format
                    ("{0}  {1}   {2}", item.Date.ToString(), item.Title, item.URL));
            }
        }

        private void SearchHistoryButton_Click(object sender, EventArgs e)
        {
            //foreach loop will cause System.InvalidOperationException: Modified Collection; Enumeration Unexecutable
            for (int i = HistoryListBox.Items.Count - 1; i >= 0; --i)
            {
                if (!(HistoryListBox.Items[i].ToString().ToLower().Contains(SearchHistoryTextBox.Text.ToLower())))
                {
                    HistoryListBox.Items.RemoveAt(i);
                }
            }
        }

        private void DeleteHistoryButton_Click(object sender, EventArgs e)
        {
            if (HistoryListBox.Items.Count <= 0)
            {
                MessageBox.Show("Nothing to delete.");
                return;
            }

            var h = HistoryManager.GetItem();
            HistoryManager.DeleteHistoryItem(h[HistoryListBox.SelectedIndex]);
            HistoryManagerForm_Load(sender, e); 
        } 


    }//end partial
}

