namespace MegaDesk
{
    partial class DisplayQuote
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
            this.ReadFile = new System.Windows.Forms.TextBox();
            this.SeeQuote = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(53, 196);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.ReadOnly = true;
            this.ReadFile.Size = new System.Drawing.Size(449, 20);
            this.ReadFile.TabIndex = 6;
            this.ReadFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SeeQuote
            // 
            this.SeeQuote.Location = new System.Drawing.Point(427, 222);
            this.SeeQuote.Name = "SeeQuote";
            this.SeeQuote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SeeQuote.Size = new System.Drawing.Size(75, 23);
            this.SeeQuote.TabIndex = 7;
            this.SeeQuote.Text = "See Quote";
            this.SeeQuote.UseVisualStyleBackColor = true;
            this.SeeQuote.Click += new System.EventHandler(this.SeeQuote_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(53, 222);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 8;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 413);
            this.Controls.Add(this.close);
            this.Controls.Add(this.SeeQuote);
            this.Controls.Add(this.ReadFile);
            this.Name = "DisplayQuote";
            this.Text = "Display Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReadFile;
        private System.Windows.Forms.Button SeeQuote;
        private System.Windows.Forms.Button close;
    }
}