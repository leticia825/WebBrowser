﻿using System;
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
            HistoryListBox.Items.Clear();///////video has this below var item =;
            var items = HistoryManager.GetItem();
            

            foreach(var item in items)
            {
                HistoryListBox.Items.Add(string.Format
                    ("{0}  {1}   {2}", item.Date.ToString(), item.Title, item.URL));
            }

        }
    }
}