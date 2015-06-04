namespace Amphibian_WPF.GUI
{
    partial class FocusedTitle
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
            this.lowerBorder = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // lowerBorder
            // 
            this.lowerBorder.BackgroundImage = global::Amphibian_WPF.Properties.Resources.page_content_footer;
            this.lowerBorder.Location = new System.Drawing.Point(0, 28);
            this.lowerBorder.Name = "lowerBorder";
            this.lowerBorder.Size = new System.Drawing.Size(746, 2);
            this.lowerBorder.TabIndex = 0;
            this.lowerBorder.TabStop = false;
            // 
            // title
            // 
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Multiline = false;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(746, 28);
            this.title.TabIndex = 1;
            this.title.Text = "blah";
            // 
            // FocusedTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.title);
            this.Controls.Add(this.lowerBorder);
            this.Name = "FocusedTitle";
            this.Size = new System.Drawing.Size(746, 30);
            ((System.ComponentModel.ISupportInitialize)(this.lowerBorder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lowerBorder;
        public System.Windows.Forms.RichTextBox title;
    }
}
