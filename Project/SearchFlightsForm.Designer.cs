
using System;
using System.Windows.Forms;

namespace Project
{
    partial class SearchFlightsForm
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
            System.Windows.Forms.MenuStrip menuStrip1;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Button profileButton;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.straightCheckBox = new System.Windows.Forms.CheckBox();
            this.anywhenСheckBox = new System.Windows.Forms.CheckBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchButton = new System.Windows.Forms.Button();
            this.toCityTextBox = new System.Windows.Forms.TextBox();
            this.fromCityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.SortButton = new System.Windows.Forms.ToolStripMenuItem();
            this.sortPriceUp = new System.Windows.Forms.ToolStripMenuItem();
            this.sortPriceDown = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfSeatsUp = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOtSeatsDown = new System.Windows.Forms.ToolStripMenuItem();
            this.dateSortButton = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.departureCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intermediateLandingPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfAvailableSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            panel1 = new System.Windows.Forms.Panel();
            profileButton = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.White;
            menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1148, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(this.straightCheckBox);
            panel1.Controls.Add(this.anywhenСheckBox);
            panel1.Controls.Add(this.datePicker);
            panel1.Controls.Add(this.SearchButton);
            panel1.Controls.Add(this.toCityTextBox);
            panel1.Controls.Add(this.fromCityTextBox);
            panel1.Controls.Add(this.label3);
            panel1.Controls.Add(this.label2);
            panel1.Controls.Add(this.label1);
            panel1.Controls.Add(this.menuStrip2);
            panel1.Location = new System.Drawing.Point(43, 54);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1044, 192);
            panel1.TabIndex = 1;
            // 
            // straightCheckBox
            // 
            this.straightCheckBox.AutoSize = true;
            this.straightCheckBox.Location = new System.Drawing.Point(308, 52);
            this.straightCheckBox.Name = "straightCheckBox";
            this.straightCheckBox.Size = new System.Drawing.Size(148, 24);
            this.straightCheckBox.TabIndex = 11;
            this.straightCheckBox.Text = "Без пересадки";
            this.straightCheckBox.UseVisualStyleBackColor = true;
            // 
            // anywhenСheckBox
            // 
            this.anywhenСheckBox.AutoSize = true;
            this.anywhenСheckBox.Location = new System.Drawing.Point(553, 52);
            this.anywhenСheckBox.Name = "anywhenСheckBox";
            this.anywhenСheckBox.Size = new System.Drawing.Size(114, 24);
            this.anywhenСheckBox.TabIndex = 9;
            this.anywhenСheckBox.Text = "Будь-коли";
            this.anywhenСheckBox.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(553, 125);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 26);
            this.datePicker.TabIndex = 7;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchButton.Location = new System.Drawing.Point(823, 115);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(153, 44);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Пошук";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // toCityTextBox
            // 
            this.toCityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toCityTextBox.Location = new System.Drawing.Point(308, 125);
            this.toCityTextBox.Name = "toCityTextBox";
            this.toCityTextBox.Size = new System.Drawing.Size(219, 26);
            this.toCityTextBox.TabIndex = 4;
            // 
            // fromCityTextBox
            // 
            this.fromCityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromCityTextBox.Location = new System.Drawing.Point(78, 125);
            this.fromCityTextBox.Name = "fromCityTextBox";
            this.fromCityTextBox.Size = new System.Drawing.Size(213, 26);
            this.fromCityTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Коли";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "До";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "З";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortButton});
            this.menuStrip2.Location = new System.Drawing.Point(78, 43);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(133, 33);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.White;
            this.SortButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortPriceUp,
            this.sortPriceDown,
            this.numberOfSeatsUp,
            this.numberOtSeatsDown,
            this.dateSortButton});
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(125, 29);
            this.SortButton.Text = "Сортування";
            // 
            // sortPriceUp
            // 
            this.sortPriceUp.Name = "sortPriceUp";
            this.sortPriceUp.Size = new System.Drawing.Size(431, 34);
            this.sortPriceUp.Text = "за збільшенням ціни";
            this.sortPriceUp.Click += new System.EventHandler(this.sortPriceUp_Click);
            // 
            // sortPriceDown
            // 
            this.sortPriceDown.Name = "sortPriceDown";
            this.sortPriceDown.Size = new System.Drawing.Size(431, 34);
            this.sortPriceDown.Text = "за зменшенням ціни";
            this.sortPriceDown.Click += new System.EventHandler(this.sortPriceDown_Click);
            // 
            // numberOfSeatsUp
            // 
            this.numberOfSeatsUp.Name = "numberOfSeatsUp";
            this.numberOfSeatsUp.Size = new System.Drawing.Size(431, 34);
            this.numberOfSeatsUp.Text = "за збільшенням кількості вільних місць";
            this.numberOfSeatsUp.Click += new System.EventHandler(this.numberOfSeatsUp_Click);
            // 
            // numberOtSeatsDown
            // 
            this.numberOtSeatsDown.Name = "numberOtSeatsDown";
            this.numberOtSeatsDown.Size = new System.Drawing.Size(431, 34);
            this.numberOtSeatsDown.Text = "за зменшенням кількості вільних місць";
            this.numberOtSeatsDown.Click += new System.EventHandler(this.numberOtSeatsDown_Click);
            // 
            // dateSortButton
            // 
            this.dateSortButton.Name = "dateSortButton";
            this.dateSortButton.Size = new System.Drawing.Size(431, 34);
            this.dateSortButton.Text = "за датою";
            this.dateSortButton.Click += new System.EventHandler(this.dateSortButton_Click);
            // 
            // profileButton
            // 
            profileButton.BackColor = System.Drawing.SystemColors.Control;
            profileButton.FlatAppearance.BorderSize = 0;
            profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            profileButton.Location = new System.Drawing.Point(43, 0);
            profileButton.Name = "profileButton";
            profileButton.Size = new System.Drawing.Size(128, 31);
            profileButton.TabIndex = 8;
            profileButton.Text = "Профіль";
            profileButton.UseVisualStyleBackColor = false;
            profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersHeight = 34;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departureCity,
            this.destinationCity,
            this.intermediateLandingPoint,
            this.dateTime,
            this.flightDuration,
            this.id,
            this.price,
            this.numberOfAvailableSeats});
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.Location = new System.Drawing.Point(52, 276);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1044, 281);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick_1);
            // 
            // departureCity
            // 
            this.departureCity.DataPropertyName = "departureCity";
            this.departureCity.HeaderText = "Місто відправлення";
            this.departureCity.MinimumWidth = 10;
            this.departureCity.Name = "departureCity";
            this.departureCity.ReadOnly = true;
            this.departureCity.Width = 196;
            // 
            // destinationCity
            // 
            this.destinationCity.DataPropertyName = "destinationCity";
            this.destinationCity.HeaderText = "Місто прибуття";
            this.destinationCity.MinimumWidth = 10;
            this.destinationCity.Name = "destinationCity";
            this.destinationCity.ReadOnly = true;
            this.destinationCity.Width = 161;
            // 
            // intermediateLandingPoint
            // 
            this.intermediateLandingPoint.DataPropertyName = "intermediateLandingPoint";
            this.intermediateLandingPoint.HeaderText = "Місто пересадки";
            this.intermediateLandingPoint.MinimumWidth = 10;
            this.intermediateLandingPoint.Name = "intermediateLandingPoint";
            this.intermediateLandingPoint.ReadOnly = true;
            this.intermediateLandingPoint.Width = 172;
            // 
            // dateTime
            // 
            this.dateTime.DataPropertyName = "dateTime";
            this.dateTime.HeaderText = "Дата";
            this.dateTime.MinimumWidth = 8;
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            this.dateTime.Width = 84;
            // 
            // flightDuration
            // 
            this.flightDuration.DataPropertyName = "flightDuration";
            this.flightDuration.HeaderText = "Тривалість";
            this.flightDuration.MinimumWidth = 10;
            this.flightDuration.Name = "flightDuration";
            this.flightDuration.ReadOnly = true;
            this.flightDuration.Width = 129;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Номер рейсу";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 141;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Ціна";
            this.price.MinimumWidth = 10;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 78;
            // 
            // numberOfAvailableSeats
            // 
            this.numberOfAvailableSeats.DataPropertyName = "numberOfAvailableSeats";
            this.numberOfAvailableSeats.HeaderText = "Залишилось місць";
            this.numberOfAvailableSeats.MinimumWidth = 10;
            this.numberOfAvailableSeats.Name = "numberOfAvailableSeats";
            this.numberOfAvailableSeats.ReadOnly = true;
            this.numberOfAvailableSeats.Width = 186;
            // 
            // SearchFlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1148, 591);
            this.Controls.Add(profileButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(panel1);
            this.Controls.Add(menuStrip1);
            this.MainMenuStrip = menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1170, 647);
            this.Name = "SearchFlightsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SearchFlightsForm_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox toCityTextBox;
        private System.Windows.Forms.TextBox fromCityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.CheckBox anywhenСheckBox;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem SortButton;
        private System.Windows.Forms.ToolStripMenuItem sortPriceUp;
        private System.Windows.Forms.ToolStripMenuItem sortPriceDown;
        private System.Windows.Forms.ToolStripMenuItem numberOfSeatsUp;
        private System.Windows.Forms.ToolStripMenuItem numberOtSeatsDown;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn departureCity;
        private DataGridViewTextBoxColumn destinationCity;
        private DataGridViewTextBoxColumn intermediateLandingPoint;
        private DataGridViewTextBoxColumn dateTime;
        private DataGridViewTextBoxColumn flightDuration;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn numberOfAvailableSeats;
        private CheckBox straightCheckBox;
        private ToolStripMenuItem dateSortButton;
        //private DataGridViewTextBoxColumn DepartureCity;
        //private DataGridViewTextBoxColumn DestinationCity;
        //private DataGridViewTextBoxColumn IntermediateLandingPoint;
        //private DataGridViewTextBoxColumn DateTime;
        //private DataGridViewTextBoxColumn Id;
        //private DataGridViewTextBoxColumn FlightDuration;
        //private DataGridViewTextBoxColumn Price;
        //private DataGridViewTextBoxColumn Carrier;
        //private DataGridViewTextBoxColumn NumberOfAvailableSeats;
    }
}
