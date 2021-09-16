
namespace WebBrowser.UI
{
    partial class BookmarkManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BookmarkListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BookmarkListBox
            // 
            this.BookmarkListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookmarkListBox.FormattingEnabled = true;
            this.BookmarkListBox.ItemHeight = 16;
            this.BookmarkListBox.Location = new System.Drawing.Point(0, 0);
            this.BookmarkListBox.Name = "BookmarkListBox";
            this.BookmarkListBox.Size = new System.Drawing.Size(800, 450);
            this.BookmarkListBox.TabIndex = 0;
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookmarkListBox);
            this.Name = "BookmarkManagerForm";
            this.Text = "BookmarkManagerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BookmarkListBox;
    }
}