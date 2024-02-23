namespace Y14_CA
{
    partial class UC_Payments
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
            this.lst_Payments = new System.Windows.Forms.ListView();
            this.lst_PayId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_BookingId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_Business = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_RoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_roomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_DueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.lbl_Payment = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_DateDue = new System.Windows.Forms.TextBox();
            this.lst_Staff = new System.Windows.Forms.ListView();
            this.lstId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstForename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddPayment = new System.Windows.Forms.Button();
            this.cb_PayType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_roomNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_CrytalPay = new System.Windows.Forms.Button();
            this.cb_Card = new System.Windows.Forms.ComboBox();
            this.lbl_cardChosen = new System.Windows.Forms.Label();
            this.lbl_CVC = new System.Windows.Forms.Label();
            this.txt_CVC = new System.Windows.Forms.TextBox();
            this.btn_CrystalBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Payments
            // 
            this.lst_Payments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(120)))), ((int)(((byte)(216)))));
            this.lst_Payments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lst_PayId,
            this.lst_BookingId,
            this.lst_Business,
            this.lst_RoomType,
            this.lst_roomNumber,
            this.lst_DueDate,
            this.lst_Amount});
            this.lst_Payments.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lst_Payments.FullRowSelect = true;
            this.lst_Payments.Location = new System.Drawing.Point(194, 98);
            this.lst_Payments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lst_Payments.Name = "lst_Payments";
            this.lst_Payments.Size = new System.Drawing.Size(506, 309);
            this.lst_Payments.TabIndex = 0;
            this.lst_Payments.UseCompatibleStateImageBehavior = false;
            this.lst_Payments.View = System.Windows.Forms.View.Details;
            this.lst_Payments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_Payments_MouseDoubleClick);
            // 
            // lst_PayId
            // 
            this.lst_PayId.Text = "PayId";
            this.lst_PayId.Width = 0;
            // 
            // lst_BookingId
            // 
            this.lst_BookingId.Text = "BookingId";
            this.lst_BookingId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_BookingId.Width = 0;
            // 
            // lst_Business
            // 
            this.lst_Business.Text = "Name";
            this.lst_Business.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_Business.Width = 120;
            // 
            // lst_RoomType
            // 
            this.lst_RoomType.Text = "Room Type";
            this.lst_RoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_RoomType.Width = 100;
            // 
            // lst_roomNumber
            // 
            this.lst_roomNumber.Text = "Room";
            this.lst_roomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_roomNumber.Width = 50;
            // 
            // lst_DueDate
            // 
            this.lst_DueDate.Text = "Date due";
            this.lst_DueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_DueDate.Width = 100;
            // 
            // lst_Amount
            // 
            this.lst_Amount.Text = "Amount";
            this.lst_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_Amount.Width = 120;
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer.Location = new System.Drawing.Point(301, 57);
            this.lbl_Customer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(292, 31);
            this.lbl_Customer.TabIndex = 1;
            this.lbl_Customer.Text = "Please select a customer";
            // 
            // lbl_Payment
            // 
            this.lbl_Payment.AutoSize = true;
            this.lbl_Payment.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment.Location = new System.Drawing.Point(95, 57);
            this.lbl_Payment.Name = "lbl_Payment";
            this.lbl_Payment.Size = new System.Drawing.Size(183, 31);
            this.lbl_Payment.TabIndex = 3;
            this.lbl_Payment.Tag = "NewPay";
            this.lbl_Payment.Text = "Make payment";
            this.lbl_Payment.Visible = false;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(58, 101);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(100, 20);
            this.txt_Amount.TabIndex = 4;
            this.txt_Amount.Tag = "NewPay";
            // 
            // txt_DateDue
            // 
            this.txt_DateDue.Location = new System.Drawing.Point(239, 101);
            this.txt_DateDue.Name = "txt_DateDue";
            this.txt_DateDue.Size = new System.Drawing.Size(66, 20);
            this.txt_DateDue.TabIndex = 5;
            this.txt_DateDue.Tag = "NewPay";
            // 
            // lst_Staff
            // 
            this.lst_Staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(120)))), ((int)(((byte)(216)))));
            this.lst_Staff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstId,
            this.lstForename,
            this.lstSurname});
            this.lst_Staff.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lst_Staff.FullRowSelect = true;
            this.lst_Staff.Location = new System.Drawing.Point(32, 253);
            this.lst_Staff.Name = "lst_Staff";
            this.lst_Staff.Size = new System.Drawing.Size(297, 154);
            this.lst_Staff.TabIndex = 6;
            this.lst_Staff.Tag = "NewPay";
            this.lst_Staff.UseCompatibleStateImageBehavior = false;
            this.lst_Staff.View = System.Windows.Forms.View.Details;
            // 
            // lstId
            // 
            this.lstId.Width = 0;
            // 
            // lstForename
            // 
            this.lstForename.Text = "Forename";
            this.lstForename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstForename.Width = 146;
            // 
            // lstSurname
            // 
            this.lstSurname.Text = "Surname";
            this.lstSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstSurname.Width = 146;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Tag = "NewPay";
            this.label1.Text = "Amount: ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(174, 103);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 13);
            this.label.TabIndex = 8;
            this.label.Tag = "NewPay";
            this.label.Text = "Date Due: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 9;
            this.label2.Tag = "NewPay";
            this.label2.Text = "Staff Member";
            // 
            // btn_AddPayment
            // 
            this.btn_AddPayment.Location = new System.Drawing.Point(135, 419);
            this.btn_AddPayment.Name = "btn_AddPayment";
            this.btn_AddPayment.Size = new System.Drawing.Size(87, 67);
            this.btn_AddPayment.TabIndex = 10;
            this.btn_AddPayment.Tag = "NewPay";
            this.btn_AddPayment.Text = "Add Payment";
            this.btn_AddPayment.UseVisualStyleBackColor = true;
            this.btn_AddPayment.Click += new System.EventHandler(this.btn_NewPayment_Click);
            // 
            // cb_PayType
            // 
            this.cb_PayType.FormattingEnabled = true;
            this.cb_PayType.Items.AddRange(new object[] {
            "Card",
            "Cash",
            "Cheque"});
            this.cb_PayType.Location = new System.Drawing.Point(242, 136);
            this.cb_PayType.Name = "cb_PayType";
            this.cb_PayType.Size = new System.Drawing.Size(62, 21);
            this.cb_PayType.TabIndex = 12;
            this.cb_PayType.Tag = "NewPay";
            this.cb_PayType.SelectedIndexChanged += new System.EventHandler(this.cb_PayType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 13;
            this.label3.Tag = "NewPay";
            this.label3.Text = "Payment Type: ";
            // 
            // txt_roomNumber
            // 
            this.txt_roomNumber.Location = new System.Drawing.Point(87, 136);
            this.txt_roomNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_roomNumber.Name = "txt_roomNumber";
            this.txt_roomNumber.Size = new System.Drawing.Size(24, 20);
            this.txt_roomNumber.TabIndex = 14;
            this.txt_roomNumber.Tag = "NewPay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 15;
            this.label4.Tag = "NewPay";
            this.label4.Text = "Room number: ";
            // 
            // btn_CrytalPay
            // 
            this.btn_CrytalPay.Location = new System.Drawing.Point(612, 419);
            this.btn_CrytalPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CrytalPay.Name = "btn_CrytalPay";
            this.btn_CrytalPay.Size = new System.Drawing.Size(87, 67);
            this.btn_CrytalPay.TabIndex = 16;
            this.btn_CrytalPay.Text = "Payment history check";
            this.btn_CrytalPay.UseVisualStyleBackColor = true;
            this.btn_CrytalPay.Click += new System.EventHandler(this.btn_CrytalPay_Click);
            // 
            // cb_Card
            // 
            this.cb_Card.Location = new System.Drawing.Point(81, 181);
            this.cb_Card.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Card.Name = "cb_Card";
            this.cb_Card.Size = new System.Drawing.Size(109, 21);
            this.cb_Card.TabIndex = 17;
            this.cb_Card.Tag = "NewPay";
            this.cb_Card.Visible = false;
            // 
            // lbl_cardChosen
            // 
            this.lbl_cardChosen.AutoSize = true;
            this.lbl_cardChosen.Location = new System.Drawing.Point(8, 184);
            this.lbl_cardChosen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cardChosen.Name = "lbl_cardChosen";
            this.lbl_cardChosen.Size = new System.Drawing.Size(70, 13);
            this.lbl_cardChosen.TabIndex = 18;
            this.lbl_cardChosen.Tag = "NewPay";
            this.lbl_cardChosen.Text = "Card chosen:";
            this.lbl_cardChosen.Visible = false;
            // 
            // lbl_CVC
            // 
            this.lbl_CVC.AutoSize = true;
            this.lbl_CVC.Location = new System.Drawing.Point(247, 184);
            this.lbl_CVC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CVC.Name = "lbl_CVC";
            this.lbl_CVC.Size = new System.Drawing.Size(31, 13);
            this.lbl_CVC.TabIndex = 19;
            this.lbl_CVC.Tag = "NewPay";
            this.lbl_CVC.Text = "CVC:";
            this.lbl_CVC.Visible = false;
            // 
            // txt_CVC
            // 
            this.txt_CVC.Location = new System.Drawing.Point(280, 181);
            this.txt_CVC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_CVC.Name = "txt_CVC";
            this.txt_CVC.Size = new System.Drawing.Size(24, 20);
            this.txt_CVC.TabIndex = 20;
            this.txt_CVC.Tag = "NewPay";
            this.txt_CVC.Visible = false;
            // 
            // btn_CrystalBook
            // 
            this.btn_CrystalBook.Location = new System.Drawing.Point(505, 419);
            this.btn_CrystalBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CrystalBook.Name = "btn_CrystalBook";
            this.btn_CrystalBook.Size = new System.Drawing.Size(87, 67);
            this.btn_CrystalBook.TabIndex = 21;
            this.btn_CrystalBook.Text = "Booking history check";
            this.btn_CrystalBook.UseVisualStyleBackColor = true;
            // 
            // UC_Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btn_CrystalBook);
            this.Controls.Add(this.txt_CVC);
            this.Controls.Add(this.lbl_CVC);
            this.Controls.Add(this.lbl_cardChosen);
            this.Controls.Add(this.cb_Card);
            this.Controls.Add(this.btn_CrytalPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_roomNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_PayType);
            this.Controls.Add(this.btn_AddPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_Staff);
            this.Controls.Add(this.txt_DateDue);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.lbl_Payment);
            this.Controls.Add(this.lbl_Customer);
            this.Controls.Add(this.lst_Payments);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_Payments";
            this.Size = new System.Drawing.Size(932, 535);
            this.Load += new System.EventHandler(this.UC_Payments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lst_Payments;
        private System.Windows.Forms.ColumnHeader lst_PayId;
        private System.Windows.Forms.ColumnHeader lst_Business;
        private System.Windows.Forms.Label lbl_Customer;
        private System.Windows.Forms.ColumnHeader lst_RoomType;
        private System.Windows.Forms.ColumnHeader lst_DueDate;
        private System.Windows.Forms.ColumnHeader lst_Amount;
        private System.Windows.Forms.ColumnHeader lst_roomNumber;
        private System.Windows.Forms.Label lbl_Payment;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.TextBox txt_DateDue;
        private System.Windows.Forms.ListView lst_Staff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddPayment;
        private System.Windows.Forms.ComboBox cb_PayType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader lstId;
        private System.Windows.Forms.ColumnHeader lstForename;
        private System.Windows.Forms.ColumnHeader lstSurname;
        private System.Windows.Forms.TextBox txt_roomNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_CrytalPay;
        private System.Windows.Forms.ComboBox cb_Card;
        private System.Windows.Forms.Label lbl_cardChosen;
        private System.Windows.Forms.ColumnHeader lst_BookingId;
        private System.Windows.Forms.Label lbl_CVC;
        private System.Windows.Forms.TextBox txt_CVC;
        private System.Windows.Forms.Button btn_CrystalBook;
    }
}
