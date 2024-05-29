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
            this.panel1 = new System.Windows.Forms.Panel();
            this.curFlightInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.EconomyRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numSeatsTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.handBaggageTextBox = new System.Windows.Forms.TextBox();
            this.registBaggageTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.curFlightInfo);
            this.panel1.Location = new System.Drawing.Point(44, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 454);
            this.panel1.TabIndex = 0;
            // 
            // curFlightInfo
            // 
            this.curFlightInfo.AutoSize = true;
            this.curFlightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.curFlightInfo.Location = new System.Drawing.Point(14, 11);
            this.curFlightInfo.Name = "curFlightInfo";
            this.curFlightInfo.Size = new System.Drawing.Size(98, 22);
            this.curFlightInfo.TabIndex = 0;
            this.curFlightInfo.Text = "Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.BuyButton);
            this.panel2.Location = new System.Drawing.Point(591, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 443);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Клас:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Кількість місць:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Багаж:";
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(207, 352);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(185, 58);
            this.BuyButton.TabIndex = 3;
            this.BuyButton.Text = "Придбати";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // EconomyRadioButton
            // 
            this.EconomyRadioButton.AutoSize = true;
            this.EconomyRadioButton.Location = new System.Drawing.Point(65, 10);
            this.EconomyRadioButton.Name = "EconomyRadioButton";
            this.EconomyRadioButton.Size = new System.Drawing.Size(91, 24);
            this.EconomyRadioButton.TabIndex = 4;
            this.EconomyRadioButton.TabStop = true;
            this.EconomyRadioButton.Text = "Економ";
            this.EconomyRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(207, 10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 24);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Бізнес";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(349, 10);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(95, 24);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Перший";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.EconomyRadioButton);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Location = new System.Drawing.Point(37, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 50);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numSeatsTextBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(37, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(522, 50);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.registBaggageTextBox);
            this.panel5.Controls.Add(this.handBaggageTextBox);
            this.panel5.Controls.Add(this.checkBox2);
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(37, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(522, 50);
            this.panel5.TabIndex = 8;
            // 
            // numSeatsTextBox
            // 
            this.numSeatsTextBox.Location = new System.Drawing.Point(159, 11);
            this.numSeatsTextBox.Name = "numSeatsTextBox";
            this.numSeatsTextBox.Size = new System.Drawing.Size(100, 26);
            this.numSeatsTextBox.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(77, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Ручна поклажа";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(265, 15);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(211, 24);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Зареєстрований багаж";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // handBaggageTextBox
            // 
            this.handBaggageTextBox.Location = new System.Drawing.Point(227, 13);
            this.handBaggageTextBox.Name = "handBaggageTextBox";
            this.handBaggageTextBox.Size = new System.Drawing.Size(32, 26);
            this.handBaggageTextBox.TabIndex = 3;
            // 
            // registBaggageTextBox
            // 
            this.registBaggageTextBox.Location = new System.Drawing.Point(473, 13);
            this.registBaggageTextBox.Name = "registBaggageTextBox";
            this.registBaggageTextBox.Size = new System.Drawing.Size(36, 26);
            this.registBaggageTextBox.TabIndex = 5;
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1245, 708);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BuyTicketForm";
            this.Text = "BuyTicketForm";
            this.Load += new System.EventHandler(this.BuyTichetForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label curFlightInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton EconomyRadioButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.TextBox numSeatsTextBox;
        private System.Windows.Forms.TextBox registBaggageTextBox;
        private System.Windows.Forms.TextBox handBaggageTextBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}