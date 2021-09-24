
namespace WebBrowser.UI
{
    partial class HistoryManagerForm
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
            this.HistoryListBox = new System.Windows.Forms.ListBox();
            this.SearchHistoryTextBox = new System.Windows.Forms.TextBox();
            this.SearchHistoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HistoryListBox
            // 
            this.HistoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryListBox.FormattingEnabled = true;
            this.HistoryListBox.ItemHeight = 16;
            this.HistoryListBox.Location = new System.Drawing.Point(0, 0);
            this.HistoryListBox.Name = "HistoryListBox";
            this.HistoryListBox.Size = new System.Drawing.Size(800, 450);
            this.HistoryListBox.TabIndex = 0;
            // 
            // SearchHistoryTextBox
            // 
            this.SearchHistoryTextBox.Location = new System.Drawing.Point(580, 405);
            this.SearchHistoryTextBox.Name = "SearchHistoryTextBox";
            this.SearchHistoryTextBox.Size = new System.Drawing.Size(208, 22);
            this.SearchHistoryTextBox.TabIndex = 1;
            // 
            // SearchHistoryButton
            // 
            this.SearchHistoryButton.Location = new System.Drawing.Point(499, 405);
            this.SearchHistoryButton.Name = "SearchHistoryButton";
            this.SearchHistoryButton.Size = new System.Drawing.Size(75, 23);
            this.SearchHistoryButton.TabIndex = 2;
            this.SearchHistoryButton.Text = "Search";
            this.SearchHistoryButton.UseVisualStyleBackColor = true;
            this.SearchHistoryButton.Click += new System.EventHandler(this.SearchHistoryButton_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchHistoryButton);
            this.Controls.Add(this.SearchHistoryTextBox);
            this.Controls.Add(this.HistoryListBox);
            this.Name = "HistoryManagerForm";
            this.Text = "HistoryManagerForm";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HistoryListBox;
        private System.Windows.Forms.TextBox SearchHistoryTextBox;
        private System.Windows.Forms.Button SearchHistoryButton;
    }
}