namespace Amphibian_WPF.GUI
{
    partial class Options
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lowerBar = new System.Windows.Forms.PictureBox();
            this.subIssuesRB = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBar)).BeginInit();
            this.SuspendLayout();
            // 
            // lowerBar
            // 
            this.lowerBar.BackgroundImage = global::Amphibian_WPF.Properties.Resources.page_content_footer;
            this.lowerBar.Location = new System.Drawing.Point(0, 28);
            this.lowerBar.Margin = new System.Windows.Forms.Padding(0);
            this.lowerBar.Name = "lowerBar";
            this.lowerBar.Size = new System.Drawing.Size(746, 2);
            this.lowerBar.TabIndex = 0;
            this.lowerBar.TabStop = false;
            // 
            // subIssuesRB
            // 
            this.subIssuesRB.BackColor = System.Drawing.SystemColors.Window;
            this.subIssuesRB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subIssuesRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.subIssuesRB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.subIssuesRB.Location = new System.Drawing.Point(0, 0);
            this.subIssuesRB.Margin = new System.Windows.Forms.Padding(0);
            this.subIssuesRB.Name = "subIssuesRB";
            this.subIssuesRB.Size = new System.Drawing.Size(120, 28);
            this.subIssuesRB.TabIndex = 1;
            this.subIssuesRB.Text = " Issues:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 0);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox1.Location = new System.Drawing.Point(243, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(120, 28);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = " Search:";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.subIssuesRB);
            this.Controls.Add(this.lowerBar);
            this.Name = "Options";
            this.Size = new System.Drawing.Size(746, 30);
            ((System.ComponentModel.ISupportInitialize)(this.lowerBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lowerBar;
        private System.Windows.Forms.RichTextBox subIssuesRB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
