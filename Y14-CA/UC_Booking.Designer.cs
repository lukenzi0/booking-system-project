namespace Y14_CA
{
    partial class UC_Booking
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
            this.pnl_OfficeConference = new System.Windows.Forms.Panel();
            this.lstStaff = new System.Windows.Forms.ListView();
            this.lstId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstForename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_StaffSelected = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Conference = new System.Windows.Forms.Button();
            this.btn_Office = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnl_OfficeConference
            // 
            this.pnl_OfficeConference.Location = new System.Drawing.Point(496, 28);
            this.pnl_OfficeConference.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_OfficeConference.Name = "pnl_OfficeConference";
            this.pnl_OfficeConference.Size = new System.Drawing.Size(397, 483);
            this.pnl_OfficeConference.TabIndex = 12;
            // 
            // lstStaff
            // 
            this.lstStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstId,
            this.lstForename,
            this.lstSurname});
            this.lstStaff.FullRowSelect = true;
            this.lstStaff.Location = new System.Drawing.Point(105, 277);
            this.lstStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstStaff.Name = "lstStaff";
            this.lstStaff.Size = new System.Drawing.Size(288, 234);
            this.lstStaff.TabIndex = 13;
            this.lstStaff.UseCompatibleStateImageBehavior = false;
            this.lstStaff.View = System.Windows.Forms.View.Details;
            // 
            // lstId
            // 
            this.lstId.DisplayIndex = 2;
            this.lstId.Text = "Id";
            this.lstId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstId.Width = 0;
            // 
            // lstForename
            // 
            this.lstForename.DisplayIndex = 0;
            this.lstForename.Text = "Forename";
            this.lstForename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstForename.Width = 140;
            // 
            // lstSurname
            // 
            this.lstSurname.DisplayIndex = 1;
            this.lstSurname.Text = "Surname";
            this.lstSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lstSurname.Width = 140;
            // 
            // txt_StaffSelected
            // 
            this.txt_StaffSelected.Location = new System.Drawing.Point(232, 254);
            this.txt_StaffSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_StaffSelected.Name = "txt_StaffSelected";
            this.txt_StaffSelected.Size = new System.Drawing.Size(121, 20);
            this.txt_StaffSelected.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Staff selected: ";
            // 
            // btn_Conference
            // 
            this.btn_Conference.Location = new System.Drawing.Point(274, 63);
            this.btn_Conference.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Conference.Name = "btn_Conference";
            this.btn_Conference.Size = new System.Drawing.Size(168, 149);
            this.btn_Conference.TabIndex = 16;
            this.btn_Conference.Text = "Conference";
            this.btn_Conference.UseVisualStyleBackColor = true;
            this.btn_Conference.Click += new System.EventHandler(this.btn_Conference_Click);
            // 
            // btn_Office
            // 
            this.btn_Office.Location = new System.Drawing.Point(30, 63);
            this.btn_Office.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Office.Name = "btn_Office";
            this.btn_Office.Size = new System.Drawing.Size(168, 149);
            this.btn_Office.TabIndex = 17;
            this.btn_Office.Text = "Office";
            this.btn_Office.UseVisualStyleBackColor = true;
            this.btn_Office.Click += new System.EventHandler(this.btn_Office_Click);
            // 
            // UC_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btn_Office);
            this.Controls.Add(this.btn_Conference);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_StaffSelected);
            this.Controls.Add(this.lstStaff);
            this.Controls.Add(this.pnl_OfficeConference);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_Booking";
            this.Size = new System.Drawing.Size(932, 535);
            this.Load += new System.EventHandler(this.UC_Booking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_OfficeConference;
        private System.Windows.Forms.ListView lstStaff;
        private System.Windows.Forms.ColumnHeader lstId;
        private System.Windows.Forms.ColumnHeader lstForename;
        private System.Windows.Forms.ColumnHeader lstSurname;
        private System.Windows.Forms.TextBox txt_StaffSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Conference;
        private System.Windows.Forms.Button btn_Office;
    }
}
