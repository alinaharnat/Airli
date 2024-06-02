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
            this.BuyPanel = new System.Windows.Forms.Panel();
            this.buyPanel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.EconomyRadioButton = new System.Windows.Forms.RadioButton();
            this.BuisinessRadioButton = new System.Windows.Forms.RadioButton();
            this.FirstRadioButton = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numSeatsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numRBUpDown = new System.Windows.Forms.NumericUpDown();
            this.numHBUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.BuyPanel.SuspendLayout();
            this.buyPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeatsUpDown)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRBUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHBUpDown)).BeginInit();
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
            // BuyPanel
            // 
            this.BuyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.BuyPanel.Controls.Add(this.buyPanel1);
            this.BuyPanel.Controls.Add(this.messageLabel);
            this.BuyPanel.Location = new System.Drawing.Point(501, 95);
            this.BuyPanel.Name = "BuyPanel";
            this.BuyPanel.Size = new System.Drawing.Size(616, 443);
            this.BuyPanel.TabIndex = 1;
            // 
            // buyPanel1
            // 
            this.buyPanel1.Controls.Add(this.panel3);
            this.buyPanel1.Controls.Add(this.panel4);
            this.buyPanel1.Controls.Add(this.panel5);
            this.buyPanel1.Controls.Add(this.BuyButton);
            this.buyPanel1.Location = new System.Drawing.Point(41, 49);
            this.buyPanel1.Name = "buyPanel1";
            this.buyPanel1.Size = new System.Drawing.Size(539, 367);
            this.buyPanel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.EconomyRadioButton);
            this.panel3.Controls.Add(this.BuisinessRadioButton);
            this.panel3.Controls.Add(this.FirstRadioButton);
            this.panel3.Location = new System.Drawing.Point(3, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 50);
            this.panel3.TabIndex = 7;
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
            this.EconomyRadioButton.CheckedChanged += new System.EventHandler(this.EconomyRadioButton_CheckedChanged);
            // 
            // BuisinessRadioButton
            // 
            this.BuisinessRadioButton.AutoSize = true;
            this.BuisinessRadioButton.Location = new System.Drawing.Point(207, 10);
            this.BuisinessRadioButton.Name = "BuisinessRadioButton";
            this.BuisinessRadioButton.Size = new System.Drawing.Size(82, 24);
            this.BuisinessRadioButton.TabIndex = 5;
            this.BuisinessRadioButton.TabStop = true;
            this.BuisinessRadioButton.Text = "Бізнес";
            this.BuisinessRadioButton.UseVisualStyleBackColor = true;
            this.BuisinessRadioButton.CheckedChanged += new System.EventHandler(this.BuisinessRadioButton_CheckedChanged);
            // 
            // FirstRadioButton
            // 
            this.FirstRadioButton.AutoSize = true;
            this.FirstRadioButton.Location = new System.Drawing.Point(349, 10);
            this.FirstRadioButton.Name = "FirstRadioButton";
            this.FirstRadioButton.Size = new System.Drawing.Size(95, 24);
            this.FirstRadioButton.TabIndex = 6;
            this.FirstRadioButton.TabStop = true;
            this.FirstRadioButton.Text = "Перший";
            this.FirstRadioButton.UseVisualStyleBackColor = true;
            this.FirstRadioButton.CheckedChanged += new System.EventHandler(this.FirstRadioButton_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numSeatsUpDown);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(522, 50);
            this.panel4.TabIndex = 8;
            // 
            // numSeatsUpDown
            // 
            this.numSeatsUpDown.Location = new System.Drawing.Point(149, 11);
            this.numSeatsUpDown.Name = "numSeatsUpDown";
            this.numSeatsUpDown.Size = new System.Drawing.Size(120, 26);
            this.numSeatsUpDown.TabIndex = 3;
            this.numSeatsUpDown.ValueChanged += new System.EventHandler(this.numSeatsUpDown_ValueChanged);
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
            // panel5
            // 
            this.panel5.Controls.Add(this.numRBUpDown);
            this.panel5.Controls.Add(this.numHBUpDown);
            this.panel5.Controls.Add(this.checkBox2);
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 203);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(522, 50);
            this.panel5.TabIndex = 8;
            // 
            // numRBUpDown
            // 
            this.numRBUpDown.Location = new System.Drawing.Point(479, 13);
            this.numRBUpDown.Name = "numRBUpDown";
            this.numRBUpDown.Size = new System.Drawing.Size(40, 26);
            this.numRBUpDown.TabIndex = 6;
            // 
            // numHBUpDown
            // 
            this.numHBUpDown.Location = new System.Drawing.Point(219, 13);
            this.numHBUpDown.Name = "numHBUpDown";
            this.numHBUpDown.Size = new System.Drawing.Size(40, 26);
            this.numHBUpDown.TabIndex = 4;
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
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
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
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.BuyButton.Location = new System.Drawing.Point(184, 306);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(185, 58);
            this.BuyButton.TabIndex = 3;
            this.BuyButton.Text = "Придбати";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(37, 26);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(113, 20);
            this.messageLabel.TabIndex = 9;
            this.messageLabel.Text = "messageLabel";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(44, 13);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(135, 30);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "Повернутися";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1148, 591);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.BuyPanel);
            this.Controls.Add(this.panel1);
            this.Name = "BuyTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyTicketForm";
            this.Load += new System.EventHandler(this.BuyTichetForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BuyPanel.ResumeLayout(false);
            this.BuyPanel.PerformLayout();
            this.buyPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeatsUpDown)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRBUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHBUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label curFlightInfo;
        private System.Windows.Forms.Panel BuyPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton EconomyRadioButton;
        private System.Windows.Forms.RadioButton BuisinessRadioButton;
        private System.Windows.Forms.RadioButton FirstRadioButton;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.NumericUpDown numSeatsUpDown;
        private System.Windows.Forms.NumericUpDown numRBUpDown;
        private System.Windows.Forms.NumericUpDown numHBUpDown;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Panel buyPanel1;
    }
}