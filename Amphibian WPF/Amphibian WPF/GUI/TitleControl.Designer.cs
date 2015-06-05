namespace Amphibian_WPF.GUI
{
    partial class TitleControl
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
            this.titleText = new System.Windows.Forms.RichTextBox();
            this.lowerBorder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.BackColor = System.Drawing.SystemColors.WindowText;
            this.titleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleText.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.titleText.Location = new System.Drawing.Point(0, 0);
            this.titleText.Margin = new System.Windows.Forms.Padding(0);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(700, 28);
            this.titleText.TabIndex = 1;
            this.titleText.Text = "Test Text";
            // 
            // lowerBorder
            // 
            this.lowerBorder.BackgroundImage = global::Amphibian_WPF.Properties.Resources.page_content_footer;
            this.lowerBorder.Location = new System.Drawing.Point(0, 28);
            this.lowerBorder.Margin = new System.Windows.Forms.Padding(0);
            this.lowerBorder.Name = "lowerBorder";
            this.lowerBorder.Size = new System.Drawing.Size(700, 2);
            this.lowerBorder.TabIndex = 0;
            this.lowerBorder.TabStop = false;
            // 
            // TitleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.lowerBorder);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TitleControl";
            this.Size = new System.Drawing.Size(700, 30);
            ((System.ComponentModel.ISupportInitialize)(this.lowerBorder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lowerBorder;
        private System.Windows.Forms.RichTextBox titleText;
    }
}
