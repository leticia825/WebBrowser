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
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            
            var items = BookmarkManager.GetItems();
            BookmarkListBox.Items.Clear();

            foreach (var item in items)
            {
                BookmarkListBox.Items.Add(string.Format
                    ("{0}  {1}", item.Title, item.URL));
            }
        }

        private void SearchBookmarkButton_Click(object sender, EventArgs e)
        {
            for (int i = BookmarkListBox.Items.Count - 1; i >= 0; --i)
            {
                if (!(BookmarkListBox.Items[i].ToString().ToLower().Contains(SearchBookmarkTextBox.Text.ToLower())))
                {
                    BookmarkListBox.Items.RemoveAt(i);
                }
            }
        }

        private void DeleteBookmarkButton_Click(object sender, EventArgs e)
        {
            if (BookmarkListBox.Items.Count <= 0) //nothing listed
            {
                MessageBox.Show("Nothing to delete.");
                return;
            }

            if (BookmarkListBox.SelectedIndex == -1) //nothing selected
            {
                MessageBox.Show("Nothing selected to delete.");
                return;
            }

            var b = BookmarkManager.GetItems();
            BookmarkManager.DeleteBookmarkItem(b[BookmarkListBox.SelectedIndex]);
            BookmarkManagerForm_Load(sender, e);
        }
    }
}
