namespace MegaDesk
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addQuote = new System.Windows.Forms.Button();
            this.viewQuote = new System.Windows.Forms.Button();
            this.searchQuote = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuote
            // 
            this.addQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addQuote.Location = new System.Drawing.Point(43, 43);
            this.addQuote.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.addQuote.Name = "addQuote";
            this.addQuote.Padding = new System.Windows.Forms.Padding(5);
            this.addQuote.Size = new System.Drawing.Size(182, 58);
            this.addQuote.TabIndex = 1;
            this.addQuote.Text = "&Add New Quote";
            this.addQuote.UseVisualStyleBackColor = true;
            this.addQuote.Click += new System.EventHandler(this.AddQuote_Click);
            // 
            // viewQuote
            // 
            this.viewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.viewQuote.Location = new System.Drawing.Point(43, 124);
            this.viewQuote.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.viewQuote.Name = "viewQuote";
            this.viewQuote.Padding = new System.Windows.Forms.Padding(5);
            this.viewQuote.Size = new System.Drawing.Size(182, 58);
            this.viewQuote.TabIndex = 2;
            this.viewQuote.Text = "&View Quotes";
            this.viewQuote.UseVisualStyleBackColor = true;
            this.viewQuote.Click += new System.EventHandler(this.ViewQuote_Click);
            // 
            // searchQuote
            // 
            this.searchQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchQuote.Location = new System.Drawing.Point(43, 205);
            this.searchQuote.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.searchQuote.Name = "searchQuote";
            this.searchQuote.Padding = new System.Windows.Forms.Padding(5);
            this.searchQuote.Size = new System.Drawing.Size(182, 58);
            this.searchQuote.TabIndex = 3;
            this.searchQuote.Text = "&Search Quotes";
            this.searchQuote.UseVisualStyleBackColor = true;
            this.searchQuote.Click += new System.EventHandler(this.SearchQuote_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exit.Location = new System.Drawing.Point(43, 286);
            this.exit.Name = "exit";
            this.exit.Padding = new System.Windows.Forms.Padding(5);
            this.exit.Size = new System.Drawing.Size(182, 58);
            this.exit.TabIndex = 4;
            this.exit.Text = "E&xit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk.Properties.Resources.desk;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(281, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchQuote);
            this.Controls.Add(this.viewQuote);
            this.Controls.Add(this.addQuote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Text = "MegaDesk - Enamorado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuote;
        private System.Windows.Forms.Button viewQuote;
        private System.Windows.Forms.Button searchQuote;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

