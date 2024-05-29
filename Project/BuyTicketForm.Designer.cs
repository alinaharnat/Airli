namespace Project
{
    partial class BuyTicketForm
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
            this.InformationLabel = new System.Windows.Forms.Label();
            this.BuyTicketButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RegistratedBaggagecheckBox = new System.Windows.Forms.CheckBox();
            this.HandBaggagecheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numSeatsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.numberHandBaggage = new System.Windows.Forms.TextBox();
            this.numberRegistratedBaggage = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Location = new System.Drawing.Point(56, 61);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(0, 20);
            this.InformationLabel.TabIndex = 0;
            // 
            // BuyTicketButton
            // 
            this.BuyTicketButton.Location = new System.Drawing.Point(231, 321);
            this.BuyTicketButton.Name = "BuyTicketButton";
            this.BuyTicketButton.Size = new System.Drawing.Size(202, 43);
            this.BuyTicketButton.TabIndex = 1;
            this.BuyTicketButton.Text = "Придбати";
            this.BuyTicketButton.UseVisualStyleBackColor = true;
            this.BuyTicketButton.Click += new System.EventHandler(this.BuyTicketButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BuyTicketButton);
            this.panel1.Location = new System.Drawing.Point(477, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 434);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numberRegistratedBaggage);
            this.panel4.Controls.Add(this.numberHandBaggage);
            this.panel4.Controls.Add(this.RegistratedBaggagecheckBox);
            this.panel4.Controls.Add(this.HandBaggagecheckBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(30, 192);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(589, 58);
            this.panel4.TabIndex = 7;
            // 
            // RegistratedBaggagecheckBox
            // 
            this.RegistratedBaggagecheckBox.AutoSize = true;
            this.RegistratedBaggagecheckBox.Location = new System.Drawing.Point(303, 17);
            this.RegistratedBaggagecheckBox.Name = "RegistratedBaggagecheckBox";
            this.RegistratedBaggagecheckBox.Size = new System.Drawing.Size(211, 24);
            this.RegistratedBaggagecheckBox.TabIndex = 4;
            this.RegistratedBaggagecheckBox.Text = "Зареєстрований багаж";
            this.RegistratedBaggagecheckBox.UseVisualStyleBackColor = true;
            // 
            // HandBaggagecheckBox
            // 
            this.HandBaggagecheckBox.AutoSize = true;
            this.HandBaggagecheckBox.Location = new System.Drawing.Point(92, 17);
            this.HandBaggagecheckBox.Name = "HandBaggagecheckBox";
            this.HandBaggagecheckBox.Size = new System.Drawing.Size(148, 24);
            this.HandBaggagecheckBox.TabIndex = 3;
            this.HandBaggagecheckBox.Text = "Ручна поклажа";
            this.HandBaggagecheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Багаж:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numSeatsTextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(30, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(589, 56);
            this.panel3.TabIndex = 6;
            // 
            // numSeatsTextBox
            // 
            this.numSeatsTextBox.Location = new System.Drawing.Point(160, 14);
            this.numSeatsTextBox.Name = "numSeatsTextBox";
            this.numSeatsTextBox.Size = new System.Drawing.Size(63, 26);
            this.numSeatsTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кількість місць:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(30, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 54);
            this.panel2.TabIndex = 5;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(368, 14);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(134, 24);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Перший клас";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клас:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(240, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(122, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Бізнес-клас";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(92, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Економ-клас";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // numberHandBaggage
            // 
            this.numberHandBaggage.Location = new System.Drawing.Point(240, 15);
            this.numberHandBaggage.Name = "numberHandBaggage";
            this.numberHandBaggage.Size = new System.Drawing.Size(32, 26);
            this.numberHandBaggage.TabIndex = 5;
            // 
            // numberRegistratedBaggage
            // 
            this.numberRegistratedBaggage.Location = new System.Drawing.Point(520, 15);
            this.numberRegistratedBaggage.Name = "numberRegistratedBaggage";
            this.numberRegistratedBaggage.Size = new System.Drawing.Size(32, 26);
            this.numberRegistratedBaggage.TabIndex = 6;
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1172, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InformationLabel);
            this.MinimumSize = new System.Drawing.Size(1170, 647);
            this.Name = "BuyTicketForm";
            this.Text = "BuyTicket";
            this.Load += new System.EventHandler(this.BuyTicketForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Button BuyTicketButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox numSeatsTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox RegistratedBaggagecheckBox;
        private System.Windows.Forms.CheckBox HandBaggagecheckBox;
        private System.Windows.Forms.TextBox numberRegistratedBaggage;
        private System.Windows.Forms.TextBox numberHandBaggage;
    }
}