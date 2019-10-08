namespace MegaDesk
{
    partial class AddQuote
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
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.warningOne = new System.Windows.Forms.Label();
            this.deskWith = new System.Windows.Forms.NumericUpDown();
            this.deskDepth = new System.Windows.Forms.NumericUpDown();
            this.warningTwo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deskWith)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.close.Location = new System.Drawing.Point(27, 323);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(104, 46);
            this.close.TabIndex = 7;
            this.close.Text = "&Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(78, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desk width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(74, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Desk depth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(23, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of drawers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(36, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Desktop material:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(78, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rush order:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(175, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 23);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox1.Location = new System.Drawing.Point(175, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.comboBox2.Location = new System.Drawing.Point(175, 196);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(125, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "3 days",
            "5 days",
            "7 days",
            "Normal (14 days)"});
            this.comboBox3.Location = new System.Drawing.Point(175, 236);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(125, 24);
            this.comboBox3.TabIndex = 6;
            // 
            // warningOne
            // 
            this.warningOne.AutoSize = true;
            this.warningOne.ForeColor = System.Drawing.Color.Red;
            this.warningOne.Location = new System.Drawing.Point(306, 84);
            this.warningOne.Name = "warningOne";
            this.warningOne.Size = new System.Drawing.Size(0, 13);
            this.warningOne.TabIndex = 8;
            // 
            // deskWith
            // 
            this.deskWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deskWith.Location = new System.Drawing.Point(176, 79);
            this.deskWith.Name = "deskWith";
            this.deskWith.Size = new System.Drawing.Size(124, 23);
            this.deskWith.TabIndex = 2;
            this.deskWith.ValueChanged += new System.EventHandler(this.DeskWith_ValueChanged);
            // 
            // deskDepth
            // 
            this.deskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deskDepth.Location = new System.Drawing.Point(176, 117);
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(124, 23);
            this.deskDepth.TabIndex = 3;
            this.deskDepth.ValueChanged += new System.EventHandler(this.DeskDepth_ValueChanged);
            // 
            // warningTwo
            // 
            this.warningTwo.AutoSize = true;
            this.warningTwo.ForeColor = System.Drawing.Color.Red;
            this.warningTwo.Location = new System.Drawing.Point(307, 123);
            this.warningTwo.Name = "warningTwo";
            this.warningTwo.Size = new System.Drawing.Size(0, 13);
            this.warningTwo.TabIndex = 8;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close;
            this.ClientSize = new System.Drawing.Size(509, 383);
            this.Controls.Add(this.deskDepth);
            this.Controls.Add(this.deskWith);
            this.Controls.Add(this.warningTwo);
            this.Controls.Add(this.warningOne);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.deskWith)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label warningOne;
        private System.Windows.Forms.NumericUpDown deskWith;
        private System.Windows.Forms.NumericUpDown deskDepth;
        private System.Windows.Forms.Label warningTwo;
    }
}