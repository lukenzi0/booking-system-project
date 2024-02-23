namespace Y14_CA
{
    partial class UC_Lease
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
            this.lst_Lease = new System.Windows.Forms.ListView();
            this.lst_BookID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_ClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_RoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_RoomNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_StartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_EndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_ConTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Update = new System.Windows.Forms.Button();
            this.pnl_Lease = new System.Windows.Forms.Panel();
            this.btn_Availability = new System.Windows.Forms.Button();
            this.btn_Details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Lease
            // 
            this.lst_Lease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(120)))), ((int)(((byte)(216)))));
            this.lst_Lease.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lst_BookID,
            this.lst_ClientName,
            this.lst_RoomType,
            this.lst_RoomNum,
            this.lst_StartDate,
            this.lst_EndDate,
            this.lst_ConTime});
            this.lst_Lease.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lst_Lease.FullRowSelect = true;
            this.lst_Lease.Location = new System.Drawing.Point(0, 0);
            this.lst_Lease.Margin = new System.Windows.Forms.Padding(2);
            this.lst_Lease.Name = "lst_Lease";
            this.lst_Lease.Size = new System.Drawing.Size(932, 357);
            this.lst_Lease.TabIndex = 2;
            this.lst_Lease.UseCompatibleStateImageBehavior = false;
            this.lst_Lease.View = System.Windows.Forms.View.Details;
            // 
            // lst_BookID
            // 
            this.lst_BookID.Text = "BookId";
            this.lst_BookID.Width = 0;
            // 
            // lst_ClientName
            // 
            this.lst_ClientName.Text = "Client name";
            this.lst_ClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_ClientName.Width = 140;
            // 
            // lst_RoomType
            // 
            this.lst_RoomType.Text = "Room type";
            this.lst_RoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_RoomType.Width = 100;
            // 
            // lst_RoomNum
            // 
            this.lst_RoomNum.Text = "Room number";
            this.lst_RoomNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_RoomNum.Width = 80;
            // 
            // lst_StartDate
            // 
            this.lst_StartDate.Text = "Start date";
            this.lst_StartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_StartDate.Width = 80;
            // 
            // lst_EndDate
            // 
            this.lst_EndDate.Text = "End date";
            this.lst_EndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_EndDate.Width = 80;
            // 
            // lst_ConTime
            // 
            this.lst_ConTime.Text = "Time";
            this.lst_ConTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lst_ConTime.Width = 100;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(514, 420);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(95, 90);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // pnl_Lease
            // 
            this.pnl_Lease.Location = new System.Drawing.Point(631, 3);
            this.pnl_Lease.Name = "pnl_Lease";
            this.pnl_Lease.Size = new System.Drawing.Size(280, 356);
            this.pnl_Lease.TabIndex = 6;
            // 
            // btn_Availability
            // 
            this.btn_Availability.Location = new System.Drawing.Point(21, 420);
            this.btn_Availability.Name = "btn_Availability";
            this.btn_Availability.Size = new System.Drawing.Size(95, 90);
            this.btn_Availability.TabIndex = 7;
            this.btn_Availability.Text = "Check availability";
            this.btn_Availability.UseVisualStyleBackColor = true;
            this.btn_Availability.Click += new System.EventHandler(this.btn_Availability_Click);
            // 
            // btn_Details
            // 
            this.btn_Details.Location = new System.Drawing.Point(153, 420);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(95, 90);
            this.btn_Details.TabIndex = 9;
            this.btn_Details.Text = "Show Details";
            this.btn_Details.UseVisualStyleBackColor = true;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // UC_Lease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btn_Details);
            this.Controls.Add(this.btn_Availability);
            this.Controls.Add(this.pnl_Lease);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lst_Lease);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Lease";
            this.Size = new System.Drawing.Size(932, 535);
            this.Load += new System.EventHandler(this.UC_Lease_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lst_Lease;
        private System.Windows.Forms.ColumnHeader lst_BookID;
        private System.Windows.Forms.ColumnHeader lst_ClientName;
        private System.Windows.Forms.ColumnHeader lst_RoomType;
        private System.Windows.Forms.ColumnHeader lst_StartDate;
        private System.Windows.Forms.ColumnHeader lst_EndDate;
        private System.Windows.Forms.ColumnHeader lst_RoomNum;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Panel pnl_Lease;
        private System.Windows.Forms.Button btn_Availability;
        private System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.ColumnHeader lst_ConTime;
    }
}
