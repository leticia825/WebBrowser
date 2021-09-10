using System;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); ////////////////////////////////////////////////////////////////////////////////
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            ////// GO BUTTON. VS WON'T RENAME METHOD //////

            //webBrowser1.Navigate(AddressTextbox.ToString());

        }

        private void webAdressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Execute GO BUTTON; but here just copied the code instead of calling method
                //webBrowser1.Navigate(AddressTextbox.ToString());

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)///////////////////////////////////////////////
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ////// BACK BUTTON. VS WON'T RENAME METHOD //////
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //is the white space inside TabPage
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void savePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void BookmarkButton_Click(object sender, EventArgs e)
        {

        }

        private void AddressTextbox_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStrip4_Load(object sender, EventArgs e)
        {

        }
    }
}
