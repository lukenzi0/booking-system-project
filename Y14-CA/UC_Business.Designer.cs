namespace Y14_CA
{
    partial class UC_Business
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
            this.btn_Book = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstBusiness = new System.Windows.Forms.ListView();
            this.lstId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstBusinessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstAddress1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstAddress2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstPostCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstCounty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstPrimaryContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstSecondaryContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Card = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Book
            // 
            this.btn_Book.Location = new System.Drawing.Point(652, 407);
            this.btn_Book.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(95, 90);
            this.btn_Book.TabIndex = 9;
            this.btn_Book.Text = "Book";
            this.btn_Book.UseVisualStyleBackColor = true;
            this.btn_Book.Click += new System.EventHandler(this.btn_Appointment_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(62, 407);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 90);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(310, 407);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 90);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(186, 407);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 90);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstBusiness
            // 
            this.lstBusiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(120)))), ((int)(((byte)(216)))));
            this.lstBusiness.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstId,
            this.lstBusinessName,
            this.lstAddress1,
            this.lstAddress2,
            this.lstPostCode,
            this.lstCity,
            this.lstCounty,
            this.lstPrimaryContact,
            this.lstSecondaryContact,
            this.lstEmail});
            this.lstBusiness.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBusiness.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstBusiness.FullRowSelect = true;
            this.lstBusiness.HideSelection = false;
            this.lstBusiness.Location = new System.Drawing.Point(-4, 0);
            this.lstBusiness.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstBusiness.Name = "lstBusiness";
            this.lstBusiness.Size = new System.Drawing.Size(937, 346);
            this.lstBusiness.TabIndex = 5;
            this.lstBusiness.UseCompatibleStateImageBehavior = false;
            this.lstBusiness.View = System.Windows.Forms.View.Details;
            // 
            // lstId
            // 
            this.lstId.Text = "Id";
            this.lstId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstId.Width = 0;
            // 
            // lstBusinessName
            // 
            this.lstBusinessName.Text = "Business";
            this.lstBusinessName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstBusinessName.Width = 100;
            // 
            // lstAddress1
            // 
            this.lstAddress1.Text = "Address 1";
            this.lstAddress1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstAddress1.Width = 100;
            // 
            // lstAddress2
            // 
            this.lstAddress2.Text = "Address 2";
            this.lstAddress2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstAddress2.Width = 100;
            // 
            // lstPostCode
            // 
            this.lstPostCode.Text = "Postcode";
            this.lstPostCode.Width = 75;
            // 
            // lstCity
            // 
            this.lstCity.Text = "City";
            this.lstCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstCity.Width = 80;
            // 
            // lstCounty
            // 
            this.lstCounty.Text = "County";
            this.lstCounty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstCounty.Width = 80;
            // 
            // lstPrimaryContact
            // 
            this.lstPrimaryContact.Text = "Primary Contact";
            this.lstPrimaryContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstPrimaryContact.Width = 120;
            // 
            // lstSecondaryContact
            // 
            this.lstSecondaryContact.Text = "Secondary";
            this.lstSecondaryContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstSecondaryContact.Width = 120;
            // 
            // lstEmail
            // 
            this.lstEmail.Text = "Email";
            this.lstEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstEmail.Width = 120;
            // 
            // btn_Card
            // 
            this.btn_Card.Location = new System.Drawing.Point(778, 407);
            this.btn_Card.Name = "btn_Card";
            this.btn_Card.Size = new System.Drawing.Size(95, 90);
            this.btn_Card.TabIndex = 11;
            this.btn_Card.Text = "New Card";
            this.btn_Card.UseVisualStyleBackColor = true;
            this.btn_Card.Click += new System.EventHandler(this.btn_Card_Click);
            // 
            // UC_Business
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btn_Card);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn_Book);
            this.Controls.Add(this.lstBusiness);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_Business";
            this.Size = new System.Drawing.Size(932, 535);
            this.Load += new System.EventHandler(this.ClientUC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lstBusiness;
        private System.Windows.Forms.ColumnHeader lstId;
        private System.Windows.Forms.ColumnHeader lstBusinessName;
        private System.Windows.Forms.ColumnHeader lstPrimaryContact;
        private System.Windows.Forms.ColumnHeader lstSecondaryContact;
        private System.Windows.Forms.ColumnHeader lstEmail;
        private System.Windows.Forms.Button btn_Card;
        private System.Windows.Forms.ColumnHeader lstAddress1;
        private System.Windows.Forms.ColumnHeader lstAddress2;
        private System.Windows.Forms.ColumnHeader lstPostCode;
        private System.Windows.Forms.ColumnHeader lstCity;
        private System.Windows.Forms.ColumnHeader lstCounty;
    }
}
