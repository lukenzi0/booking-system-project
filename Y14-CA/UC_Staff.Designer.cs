namespace Y14_CA
{
    partial class UC_Staff
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
            this.lst_Staff = new System.Windows.Forms.ListView();
            this.lst_StaffId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_Forename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_Address1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_Address2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_PostCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_County = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_PContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_SContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Delete = new System.Windows.Forms.Button();
            this.pnl_AddUpdate = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Staff
            // 
            this.lst_Staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(120)))), ((int)(((byte)(216)))));
            this.lst_Staff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lst_StaffId,
            this.lst_Forename,
            this.lst_Surname,
            this.lst_Address1,
            this.lst_Address2,
            this.lst_PostCode,
            this.lst_City,
            this.lst_County,
            this.lst_PContact,
            this.lst_SContact,
            this.lst_Email});
            this.lst_Staff.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Staff.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lst_Staff.FullRowSelect = true;
            this.lst_Staff.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lst_Staff.Location = new System.Drawing.Point(0, 0);
            this.lst_Staff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lst_Staff.Name = "lst_Staff";
            this.lst_Staff.Size = new System.Drawing.Size(1243, 425);
            this.lst_Staff.TabIndex = 0;
            this.lst_Staff.UseCompatibleStateImageBehavior = false;
            this.lst_Staff.View = System.Windows.Forms.View.Details;
            // 
            // lst_StaffId
            // 
            this.lst_StaffId.Width = 0;
            // 
            // lst_Forename
            // 
            this.lst_Forename.Text = "Forename";
            this.lst_Forename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_Forename.Width = 100;
            // 
            // lst_Surname
            // 
            this.lst_Surname.Text = "Surname";
            this.lst_Surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_Surname.Width = 100;
            // 
            // lst_Address1
            // 
            this.lst_Address1.Text = "Address 1";
            this.lst_Address1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_Address1.Width = 100;
            // 
            // lst_Address2
            // 
            this.lst_Address2.Text = "Address 2";
            this.lst_Address2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_Address2.Width = 100;
            // 
            // lst_PostCode
            // 
            this.lst_PostCode.Text = "PostCode";
            this.lst_PostCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_PostCode.Width = 75;
            // 
            // lst_City
            // 
            this.lst_City.Text = "City";
            this.lst_City.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_City.Width = 80;
            // 
            // lst_County
            // 
            this.lst_County.Text = "County";
            this.lst_County.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_County.Width = 80;
            // 
            // lst_PContact
            // 
            this.lst_PContact.Text = "Primary contact";
            this.lst_PContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_PContact.Width = 120;
            // 
            // lst_SContact
            // 
            this.lst_SContact.Text = "Secondary";
            this.lst_SContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_SContact.Width = 120;
            // 
            // lst_Email
            // 
            this.lst_Email.Text = "Email";
            this.lst_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_Email.Width = 120;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(429, 490);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(127, 111);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // pnl_AddUpdate
            // 
            this.pnl_AddUpdate.Location = new System.Drawing.Point(900, 36);
            this.pnl_AddUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_AddUpdate.Name = "pnl_AddUpdate";
            this.pnl_AddUpdate.Size = new System.Drawing.Size(323, 425);
            this.pnl_AddUpdate.TabIndex = 4;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(739, 490);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(127, 111);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(584, 490);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(127, 111);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // UC_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.pnl_AddUpdate);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lst_Staff);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Staff";
            this.Size = new System.Drawing.Size(1243, 658);
            this.Load += new System.EventHandler(this.UC_Staff_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lst_Staff;
        private System.Windows.Forms.ColumnHeader lst_StaffId;
        private System.Windows.Forms.ColumnHeader lst_Forename;
        private System.Windows.Forms.ColumnHeader lst_Surname;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Panel pnl_AddUpdate;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ColumnHeader lst_Address1;
        private System.Windows.Forms.ColumnHeader lst_Address2;
        private System.Windows.Forms.ColumnHeader lst_PostCode;
        private System.Windows.Forms.ColumnHeader lst_City;
        private System.Windows.Forms.ColumnHeader lst_County;
        private System.Windows.Forms.ColumnHeader lst_PContact;
        private System.Windows.Forms.ColumnHeader lst_SContact;
        private System.Windows.Forms.ColumnHeader lst_Email;
    }
}
