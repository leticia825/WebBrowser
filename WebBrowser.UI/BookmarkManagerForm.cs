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
            BookmarkListBox.Items.Clear();///////video has this below var item =;
            var items = BookmarkManager.GetItems();


            foreach (var item in items)
            {
                BookmarkListBox.Items.Add(string.Format
                    ("{0}  {1}", item.Title, item.URL));
            }
        }
    }
}
