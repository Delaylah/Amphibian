namespace Amphibian_WPF.GUI
{
    partial class IssueViewForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.expandButton = new System.Windows.Forms.Button();
            this.commentPanel = new System.Windows.Forms.Panel();
            this.comments = new Amphibian_WPF.GUI.TitleControl();
            this.titleControl = new Amphibian_WPF.GUI.TitleControl();
            this.issueContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.backButton.Location = new System.Drawing.Point(703, 0);
            this.backButton.Margin = new System.Windows.Forms.Padding(0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 30);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.closeForm);
            // 
            // expandButton
            // 
            this.expandButton.BackColor = System.Drawing.Color.Black;
            this.expandButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.expandButton.FlatAppearance.BorderSize = 0;
            this.expandButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.expandButton.Location = new System.Drawing.Point(703, 220);
            this.expandButton.Margin = new System.Windows.Forms.Padding(0);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(30, 30);
            this.expandButton.TabIndex = 3;
            this.expandButton.Text = "V";
            this.expandButton.UseVisualStyleBackColor = false;
            this.expandButton.Click += new System.EventHandler(this.expandcomments);
            // 
            // commentPanel
            // 
            this.commentPanel.Location = new System.Drawing.Point(0, 253);
            this.commentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.commentPanel.Name = "commentPanel";
            this.commentPanel.Size = new System.Drawing.Size(730, 0);
            this.commentPanel.TabIndex = 4;
            // 
            // comments
            // 
            this.comments.BackColor = System.Drawing.SystemColors.WindowText;
            this.comments.Location = new System.Drawing.Point(0, 220);
            this.comments.Margin = new System.Windows.Forms.Padding(0);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(700, 30);
            this.comments.TabIndex = 2;
            this.comments.text = "Test Text";
            // 
            // titleControl
            // 
            this.titleControl.BackColor = System.Drawing.SystemColors.WindowText;
            this.titleControl.Location = new System.Drawing.Point(0, 0);
            this.titleControl.Margin = new System.Windows.Forms.Padding(0);
            this.titleControl.Name = "titleControl";
            this.titleControl.Size = new System.Drawing.Size(700, 30);
            this.titleControl.TabIndex = 0;
            this.titleControl.text = "Test Text";
            // 
            // issueContent
            // 
            this.issueContent.BackColor = System.Drawing.SystemColors.WindowText;
            this.issueContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.issueContent.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.issueContent.Location = new System.Drawing.Point(0, 33);
            this.issueContent.Margin = new System.Windows.Forms.Padding(0);
            this.issueContent.Name = "issueContent";
            this.issueContent.Size = new System.Drawing.Size(733, 184);
            this.issueContent.TabIndex = 5;
            this.issueContent.Text = "";
            // 
            // IssueViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(733, 268);
            this.Controls.Add(this.issueContent);
            this.Controls.Add(this.commentPanel);
            this.Controls.Add(this.expandButton);
            this.Controls.Add(this.comments);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.titleControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IssueViewForm";
            this.ShowIcon = false;
            this.Text = "mainForm";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private TitleControl titleControl;
        private System.Windows.Forms.Button backButton;
        private TitleControl comments;
        private System.Windows.Forms.Button expandButton;
        private System.Windows.Forms.Panel commentPanel;
        private System.Windows.Forms.RichTextBox issueContent;
    }
}