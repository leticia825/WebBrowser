
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
            this.SearchBookmarkTextBox = new System.Windows.Forms.TextBox();
            this.SearchBookmarkButton = new System.Windows.Forms.Button();
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
            // SearchBookmarkTextBox
            // 
            this.SearchBookmarkTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchBookmarkTextBox.Location = new System.Drawing.Point(599, 0);
            this.SearchBookmarkTextBox.Name = "SearchBookmarkTextBox";
            this.SearchBookmarkTextBox.Size = new System.Drawing.Size(201, 22);
            this.SearchBookmarkTextBox.TabIndex = 1;
            // 
            // SearchBookmarkButton
            // 
            this.SearchBookmarkButton.Location = new System.Drawing.Point(681, 39);
            this.SearchBookmarkButton.Name = "SearchBookmarkButton";
            this.SearchBookmarkButton.Size = new System.Drawing.Size(107, 23);
            this.SearchBookmarkButton.TabIndex = 2;
            this.SearchBookmarkButton.Text = "Search";
            this.SearchBookmarkButton.UseVisualStyleBackColor = true;
            this.SearchBookmarkButton.Click += new System.EventHandler(this.SearchBookmarkButton_Click);
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBookmarkButton);
            this.Controls.Add(this.SearchBookmarkTextBox);
            this.Controls.Add(this.BookmarkListBox);
            this.Name = "BookmarkManagerForm";
            this.Text = "BookmarkManagerForm";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BookmarkListBox;
        private System.Windows.Forms.TextBox SearchBookmarkTextBox;
        private System.Windows.Forms.Button SearchBookmarkButton;
    }
}