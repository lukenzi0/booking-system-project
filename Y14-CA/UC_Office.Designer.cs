namespace Y14_CA
{
    partial class UC_Office
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.dt_Office = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Office = new System.Windows.Forms.ComboBox();
            this.count_months = new System.Windows.Forms.NumericUpDown();
            this.count_years = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.count_Capacity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_MonthlyCost = new System.Windows.Forms.Label();
            this.lbl_Deposit = new System.Windows.Forms.Label();
            this.check_Paid = new System.Windows.Forms.CheckBox();
            this.cb_PayType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_chooseCard = new System.Windows.Forms.Label();
            this.cb_chooseCard = new System.Windows.Forms.ComboBox();
            this.count_Projectors = new System.Windows.Forms.NumericUpDown();
            this.count_Shredders = new System.Windows.Forms.NumericUpDown();
            this.count_Desks = new System.Windows.Forms.NumericUpDown();
            this.count_Telephones = new System.Windows.Forms.NumericUpDown();
            this.count_Printers = new System.Windows.Forms.NumericUpDown();
            this.count_Computers = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.count_months)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_years)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Projectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Shredders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Desks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Telephones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Printers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Computers)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "OFFICE";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(160, 418);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(63, 47);
            this.btn_Confirm.TabIndex = 7;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // dt_Office
            // 
            this.dt_Office.Location = new System.Drawing.Point(176, 89);
            this.dt_Office.MinDate = new System.DateTime(2021, 9, 29, 0, 0, 0, 0);
            this.dt_Office.Name = "dt_Office";
            this.dt_Office.Size = new System.Drawing.Size(130, 20);
            this.dt_Office.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Starting from: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Office:";
            // 
            // cb_Office
            // 
            this.cb_Office.FormattingEnabled = true;
            this.cb_Office.Location = new System.Drawing.Point(267, 128);
            this.cb_Office.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Office.Name = "cb_Office";
            this.cb_Office.Size = new System.Drawing.Size(68, 21);
            this.cb_Office.TabIndex = 11;
            this.cb_Office.Tag = "Office";
            // 
            // count_months
            // 
            this.count_months.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.count_months.Location = new System.Drawing.Point(105, 154);
            this.count_months.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.count_months.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.count_months.Name = "count_months";
            this.count_months.Size = new System.Drawing.Size(45, 20);
            this.count_months.TabIndex = 12;
            this.count_months.ValueChanged += new System.EventHandler(this.count_months_ValueChanged);
            // 
            // count_years
            // 
            this.count_years.Location = new System.Drawing.Point(105, 131);
            this.count_years.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.count_years.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.count_years.Name = "count_years";
            this.count_years.Size = new System.Drawing.Size(45, 20);
            this.count_years.TabIndex = 13;
            this.count_years.ValueChanged += new System.EventHandler(this.count_years_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Years: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Months: ";
            // 
            // count_Capacity
            // 
            this.count_Capacity.Location = new System.Drawing.Point(266, 153);
            this.count_Capacity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.count_Capacity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.count_Capacity.Name = "count_Capacity";
            this.count_Capacity.Size = new System.Drawing.Size(70, 20);
            this.count_Capacity.TabIndex = 16;
            this.count_Capacity.ValueChanged += new System.EventHandler(this.count_Capacity_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Capacity:";
            // 
            // lbl_MonthlyCost
            // 
            this.lbl_MonthlyCost.AutoSize = true;
            this.lbl_MonthlyCost.Location = new System.Drawing.Point(49, 375);
            this.lbl_MonthlyCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MonthlyCost.Name = "lbl_MonthlyCost";
            this.lbl_MonthlyCost.Size = new System.Drawing.Size(73, 13);
            this.lbl_MonthlyCost.TabIndex = 18;
            this.lbl_MonthlyCost.Text = "Monthly cost: ";
            // 
            // lbl_Deposit
            // 
            this.lbl_Deposit.AutoSize = true;
            this.lbl_Deposit.Location = new System.Drawing.Point(70, 347);
            this.lbl_Deposit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Deposit.Name = "lbl_Deposit";
            this.lbl_Deposit.Size = new System.Drawing.Size(49, 13);
            this.lbl_Deposit.TabIndex = 19;
            this.lbl_Deposit.Text = "Deposit: ";
            // 
            // check_Paid
            // 
            this.check_Paid.AutoSize = true;
            this.check_Paid.Location = new System.Drawing.Point(21, 346);
            this.check_Paid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_Paid.Name = "check_Paid";
            this.check_Paid.Size = new System.Drawing.Size(53, 17);
            this.check_Paid.TabIndex = 23;
            this.check_Paid.Text = "Paid?";
            this.check_Paid.UseVisualStyleBackColor = true;
            // 
            // cb_PayType
            // 
            this.cb_PayType.FormattingEnabled = true;
            this.cb_PayType.Items.AddRange(new object[] {
            "Card",
            "Cash",
            "Cheque"});
            this.cb_PayType.Location = new System.Drawing.Point(248, 340);
            this.cb_PayType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_PayType.Name = "cb_PayType";
            this.cb_PayType.Size = new System.Drawing.Size(145, 21);
            this.cb_PayType.TabIndex = 24;
            this.cb_PayType.SelectedIndexChanged += new System.EventHandler(this.cb_PayType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 342);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Payment type: ";
            // 
            // lbl_chooseCard
            // 
            this.lbl_chooseCard.AutoSize = true;
            this.lbl_chooseCard.Location = new System.Drawing.Point(173, 377);
            this.lbl_chooseCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_chooseCard.Name = "lbl_chooseCard";
            this.lbl_chooseCard.Size = new System.Drawing.Size(70, 13);
            this.lbl_chooseCard.TabIndex = 26;
            this.lbl_chooseCard.Text = "Card chosen:";
            this.lbl_chooseCard.Visible = false;
            // 
            // cb_chooseCard
            // 
            this.cb_chooseCard.FormattingEnabled = true;
            this.cb_chooseCard.Location = new System.Drawing.Point(247, 374);
            this.cb_chooseCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_chooseCard.Name = "cb_chooseCard";
            this.cb_chooseCard.Size = new System.Drawing.Size(147, 21);
            this.cb_chooseCard.TabIndex = 27;
            this.cb_chooseCard.Visible = false;
            // 
            // count_Projectors
            // 
            this.count_Projectors.Location = new System.Drawing.Point(293, 241);
            this.count_Projectors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.count_Projectors.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.count_Projectors.Name = "count_Projectors";
            this.count_Projectors.Size = new System.Drawing.Size(47, 20);
            this.count_Projectors.TabIndex = 28;
            this.count_Projectors.ValueChanged += new System.EventHandler(this.count_Projectors_ValueChanged);
            // 
            // count_Shredders
            // 
            this.count_Shredders.Location = new System.Drawing.Point(293, 271);
            this.count_Shredders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.count_Shredders.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.count_Shredders.Name = "count_Shredders";
            this.count_Shredders.Size = new System.Drawing.Size(47, 20);
            this.count_Shredders.TabIndex = 29;
            this.count_Shredders.ValueChanged += new System.EventHandler(this.count_Shredders_ValueChanged);
            // 
            // count_Desks
            // 
            this.count_Desks.Location = new System.Drawing.Point(105, 211);
            this.count_Desks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.count_Desks.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.count_Desks.Name = "count_Desks";
            this.count_Desks.Size = new System.Drawing.Size(47, 20);
            this.count_Desks.TabIndex = 30;
            this.count_Desks.ValueChanged += new System.EventHandler(this.count_Desks_ValueChanged);
            // 
            // count_Telephones
            // 
            this.count_Telephones.Location = new System.Drawing.Point(293, 211);
            this.count_Telephones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.count_Telephones.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.count_Telephones.Name = "count_Telephones";
            this.count_Telephones.Size = new System.Drawing.Size(47, 20);
            this.count_Telephones.TabIndex = 31;
            this.count_Telephones.ValueChanged += new System.EventHandler(this.count_Telephones_ValueChanged);
            // 
            // count_Printers
            // 
            this.count_Printers.Location = new System.Drawing.Point(105, 271);
            this.count_Printers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.count_Printers.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.count_Printers.Name = "count_Printers";
            this.count_Printers.Size = new System.Drawing.Size(47, 20);
            this.count_Printers.TabIndex = 32;
            this.count_Printers.ValueChanged += new System.EventHandler(this.count_Printers_ValueChanged);
            // 
            // count_Computers
            // 
            this.count_Computers.Location = new System.Drawing.Point(105, 241);
            this.count_Computers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.count_Computers.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.count_Computers.Name = "count_Computers";
            this.count_Computers.Size = new System.Drawing.Size(47, 20);
            this.count_Computers.TabIndex = 33;
            this.count_Computers.ValueChanged += new System.EventHandler(this.count_Computers_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 213);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Telephones: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 244);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Projectors: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 273);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Shredders: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 274);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Printers: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 244);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Computers: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(60, 214);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Desks: ";
            // 
            // UC_Office
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.count_Computers);
            this.Controls.Add(this.count_Printers);
            this.Controls.Add(this.count_Telephones);
            this.Controls.Add(this.count_Desks);
            this.Controls.Add(this.count_Shredders);
            this.Controls.Add(this.count_Projectors);
            this.Controls.Add(this.cb_chooseCard);
            this.Controls.Add(this.lbl_chooseCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_PayType);
            this.Controls.Add(this.check_Paid);
            this.Controls.Add(this.lbl_Deposit);
            this.Controls.Add(this.lbl_MonthlyCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.count_Capacity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.count_years);
            this.Controls.Add(this.count_months);
            this.Controls.Add(this.cb_Office);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt_Office);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_Office";
            this.Size = new System.Drawing.Size(405, 489);
            this.Load += new System.EventHandler(this.OfficeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.count_months)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_years)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Projectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Shredders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Desks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Telephones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Printers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Computers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.DateTimePicker dt_Office;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Office;
        private System.Windows.Forms.NumericUpDown count_months;
        private System.Windows.Forms.NumericUpDown count_years;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown count_Capacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_MonthlyCost;
        private System.Windows.Forms.Label lbl_Deposit;
        private System.Windows.Forms.CheckBox check_Paid;
        private System.Windows.Forms.ComboBox cb_PayType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_chooseCard;
        private System.Windows.Forms.ComboBox cb_chooseCard;
        private System.Windows.Forms.NumericUpDown count_Projectors;
        private System.Windows.Forms.NumericUpDown count_Shredders;
        private System.Windows.Forms.NumericUpDown count_Desks;
        private System.Windows.Forms.NumericUpDown count_Telephones;
        private System.Windows.Forms.NumericUpDown count_Printers;
        private System.Windows.Forms.NumericUpDown count_Computers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}
