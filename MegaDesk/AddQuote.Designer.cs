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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.drawersInput = new System.Windows.Forms.ComboBox();
            this.materialInput = new System.Windows.Forms.ComboBox();
            this.rushInput = new System.Windows.Forms.ComboBox();
            this.warningOne = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.depthInput = new System.Windows.Forms.NumericUpDown();
            this.warningTwo = new System.Windows.Forms.Label();
            this.SubmitOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.close.Location = new System.Drawing.Point(36, 398);
            this.close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(139, 57);
            this.close.TabIndex = 7;
            this.close.Text = "&Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(104, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desk width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(99, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Desk depth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(31, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of drawers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(48, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Desktop material:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(104, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rush order:";
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameInput.Location = new System.Drawing.Point(233, 46);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(332, 26);
            this.nameInput.TabIndex = 1;
            // 
            // drawersInput
            // 
            this.drawersInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.drawersInput.FormattingEnabled = true;
            this.drawersInput.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawersInput.Location = new System.Drawing.Point(233, 192);
            this.drawersInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(165, 28);
            this.drawersInput.TabIndex = 4;
            // 
            // materialInput
            // 
            this.materialInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialInput.FormattingEnabled = true;
            this.materialInput.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.materialInput.Location = new System.Drawing.Point(233, 241);
            this.materialInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialInput.Name = "materialInput";
            this.materialInput.Size = new System.Drawing.Size(165, 28);
            this.materialInput.TabIndex = 5;
            // 
            // rushInput
            // 
            this.rushInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rushInput.FormattingEnabled = true;
            this.rushInput.Items.AddRange(new object[] {
            "3 days",
            "5 days",
            "7 days",
            "Normal (14 days)"});
            this.rushInput.Location = new System.Drawing.Point(233, 290);
            this.rushInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rushInput.Name = "rushInput";
            this.rushInput.Size = new System.Drawing.Size(165, 28);
            this.rushInput.TabIndex = 6;
            // 
            // warningOne
            // 
            this.warningOne.AutoSize = true;
            this.warningOne.ForeColor = System.Drawing.Color.Red;
            this.warningOne.Location = new System.Drawing.Point(408, 103);
            this.warningOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warningOne.Name = "warningOne";
            this.warningOne.Size = new System.Drawing.Size(0, 17);
            this.warningOne.TabIndex = 8;
            // 
            // widthInput
            // 
            this.widthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.widthInput.Location = new System.Drawing.Point(235, 97);
            this.widthInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(165, 26);
            this.widthInput.TabIndex = 2;
            this.widthInput.ValueChanged += new System.EventHandler(this.DeskWith_ValueChanged);
            // 
            // depthInput
            // 
            this.depthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.depthInput.Location = new System.Drawing.Point(235, 144);
            this.depthInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(165, 26);
            this.depthInput.TabIndex = 3;
            this.depthInput.ValueChanged += new System.EventHandler(this.DeskDepth_ValueChanged);
            // 
            // warningTwo
            // 
            this.warningTwo.AutoSize = true;
            this.warningTwo.ForeColor = System.Drawing.Color.Red;
            this.warningTwo.Location = new System.Drawing.Point(409, 151);
            this.warningTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warningTwo.Name = "warningTwo";
            this.warningTwo.Size = new System.Drawing.Size(0, 17);
            this.warningTwo.TabIndex = 8;
            // 
            // SubmitOrder
            // 
            this.SubmitOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SubmitOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SubmitOrder.Location = new System.Drawing.Point(428, 398);
            this.SubmitOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitOrder.Name = "SubmitOrder";
            this.SubmitOrder.Size = new System.Drawing.Size(139, 57);
            this.SubmitOrder.TabIndex = 9;
            this.SubmitOrder.Text = "Submit";
            this.SubmitOrder.UseVisualStyleBackColor = true;
            this.SubmitOrder.Click += new System.EventHandler(this.SubmitOrder_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close;
            this.ClientSize = new System.Drawing.Size(679, 471);
            this.Controls.Add(this.SubmitOrder);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.warningTwo);
            this.Controls.Add(this.warningOne);
            this.Controls.Add(this.rushInput);
            this.Controls.Add(this.materialInput);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.Padding = new System.Windows.Forms.Padding(53, 49, 53, 49);
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).EndInit();
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
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.ComboBox drawersInput;
        private System.Windows.Forms.ComboBox materialInput;
        private System.Windows.Forms.ComboBox rushInput;
        private System.Windows.Forms.Label warningOne;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.NumericUpDown depthInput;
        private System.Windows.Forms.Label warningTwo;
        private System.Windows.Forms.Button SubmitOrder;
    }
}