using System.Windows.Forms;

namespace Project
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.curUserLastName = new System.Windows.Forms.TextBox();
            this.curUserFirstName = new System.Windows.Forms.TextBox();
            this.curUserEmail = new System.Windows.Forms.TextBox();
            this.curUserPassword = new System.Windows.Forms.TextBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.ShowHistoryButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.destinationCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // curUserLastName
            // 
            this.curUserLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.curUserLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curUserLastName.ForeColor = System.Drawing.Color.Black;
            this.curUserLastName.Location = new System.Drawing.Point(46, 188);
            this.curUserLastName.Name = "curUserLastName";
            this.curUserLastName.Size = new System.Drawing.Size(298, 26);
            this.curUserLastName.TabIndex = 0;
            this.curUserLastName.TextChanged += new System.EventHandler(this.curUserLastName_TextChanged);
            // 
            // curUserFirstName
            // 
            this.curUserFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.curUserFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curUserFirstName.Location = new System.Drawing.Point(46, 245);
            this.curUserFirstName.Name = "curUserFirstName";
            this.curUserFirstName.Size = new System.Drawing.Size(298, 26);
            this.curUserFirstName.TabIndex = 1;
            this.curUserFirstName.TextChanged += new System.EventHandler(this.curUserFirstName_TextChanged);
            // 
            // curUserEmail
            // 
            this.curUserEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.curUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curUserEmail.Location = new System.Drawing.Point(46, 300);
            this.curUserEmail.Name = "curUserEmail";
            this.curUserEmail.ReadOnly = true;
            this.curUserEmail.Size = new System.Drawing.Size(298, 26);
            this.curUserEmail.TabIndex = 2;
            // 
            // curUserPassword
            // 
            this.curUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.curUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curUserPassword.Location = new System.Drawing.Point(46, 353);
            this.curUserPassword.Name = "curUserPassword";
            this.curUserPassword.Size = new System.Drawing.Size(298, 26);
            this.curUserPassword.TabIndex = 3;
            this.curUserPassword.TextChanged += new System.EventHandler(this.curUserPassword_TextChanged);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.saveChangesButton.FlatAppearance.BorderSize = 0;
            this.saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveChangesButton.Location = new System.Drawing.Point(99, 410);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(205, 37);
            this.saveChangesButton.TabIndex = 4;
            this.saveChangesButton.Text = "Зберегти";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.curUserFirstName);
            this.panel1.Controls.Add(this.saveChangesButton);
            this.panel1.Controls.Add(this.curUserPassword);
            this.panel1.Controls.Add(this.curUserLastName);
            this.panel1.Controls.Add(this.curUserEmail);
            this.panel1.Location = new System.Drawing.Point(24, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 509);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(3, 2);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(61, 37);
            this.returnButton.TabIndex = 8;
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // ShowHistoryButton
            // 
            this.ShowHistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ShowHistoryButton.FlatAppearance.BorderSize = 0;
            this.ShowHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowHistoryButton.Location = new System.Drawing.Point(440, 82);
            this.ShowHistoryButton.Name = "ShowHistoryButton";
            this.ShowHistoryButton.Size = new System.Drawing.Size(197, 40);
            this.ShowHistoryButton.TabIndex = 9;
            this.ShowHistoryButton.Text = "Історія замовлень";
            this.ShowHistoryButton.UseVisualStyleBackColor = false;
            this.ShowHistoryButton.Click += new System.EventHandler(this.ShowHistoryButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.destinationCity});
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.Location = new System.Drawing.Point(440, 165);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(215, 405);
            this.dataGridView.TabIndex = 10;
            // 
            // destinationCity
            // 
            this.destinationCity.DataPropertyName = "infoOrder";
            this.destinationCity.HeaderText = "Інформація про замовлення";
            this.destinationCity.MinimumWidth = 8;
            this.destinationCity.Name = "destinationCity";
            this.destinationCity.ReadOnly = true;
            this.destinationCity.Width = 150;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1148, 591);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ShowHistoryButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1170, 647);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox curUserLastName;
        private System.Windows.Forms.TextBox curUserFirstName;
        private System.Windows.Forms.TextBox curUserEmail;
        private System.Windows.Forms.TextBox curUserPassword;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button ShowHistoryButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView;
        private DataGridViewTextBoxColumn destinationCity;
    }
}