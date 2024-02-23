namespace Y14_CA
{
    partial class UC_Scheduler
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
            this.dg_Schedule = new System.Windows.Forms.DataGridView();
            this.cb_Room = new System.Windows.Forms.ComboBox();
            this.btn_Availability = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_leftArrow = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_rightArrow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Schedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Schedule
            // 
            this.dg_Schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Schedule.Location = new System.Drawing.Point(174, 89);
            this.dg_Schedule.Name = "dg_Schedule";
            this.dg_Schedule.Size = new System.Drawing.Size(729, 302);
            this.dg_Schedule.TabIndex = 1;
            // 
            // cb_Room
            // 
            this.cb_Room.FormattingEnabled = true;
            this.cb_Room.Items.AddRange(new object[] {
            "Office 1\t",
            "Office 2",
            "Office 3",
            "Office 4",
            "Office 5",
            "Office 6",
            "Office 7",
            "Office 8",
            "Office 9",
            "Conference"});
            this.cb_Room.Location = new System.Drawing.Point(28, 160);
            this.cb_Room.Name = "cb_Room";
            this.cb_Room.Size = new System.Drawing.Size(121, 21);
            this.cb_Room.TabIndex = 2;
            // 
            // btn_Availability
            // 
            this.btn_Availability.Location = new System.Drawing.Point(48, 216);
            this.btn_Availability.Name = "btn_Availability";
            this.btn_Availability.Size = new System.Drawing.Size(85, 69);
            this.btn_Availability.TabIndex = 3;
            this.btn_Availability.Text = "Check availability";
            this.btn_Availability.UseVisualStyleBackColor = true;
            this.btn_Availability.Click += new System.EventHandler(this.btn_Availability_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(45, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose a room";
            // 
            // lbl_leftArrow
            // 
            this.lbl_leftArrow.AutoSize = true;
            this.lbl_leftArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leftArrow.Location = new System.Drawing.Point(467, 50);
            this.lbl_leftArrow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_leftArrow.Name = "lbl_leftArrow";
            this.lbl_leftArrow.Size = new System.Drawing.Size(17, 18);
            this.lbl_leftArrow.TabIndex = 5;
            this.lbl_leftArrow.Text = "<";
            this.lbl_leftArrow.Click += new System.EventHandler(this.lbl_leftArrow_Click);
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Year.Location = new System.Drawing.Point(494, 36);
            this.lbl_Year.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(88, 45);
            this.lbl_Year.TabIndex = 6;
            this.lbl_Year.Text = "yyyy";
            // 
            // lbl_rightArrow
            // 
            this.lbl_rightArrow.AutoSize = true;
            this.lbl_rightArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rightArrow.Location = new System.Drawing.Point(591, 50);
            this.lbl_rightArrow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_rightArrow.Name = "lbl_rightArrow";
            this.lbl_rightArrow.Size = new System.Drawing.Size(17, 18);
            this.lbl_rightArrow.TabIndex = 7;
            this.lbl_rightArrow.Text = ">";
            this.lbl_rightArrow.Click += new System.EventHandler(this.lbl_rightArrow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 462);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Booked";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 462);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Not booked";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(823, 462);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Morning booked";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(598, 462);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Afternoon booked";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(405, 422);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkBlue;
            this.pictureBox2.Location = new System.Drawing.Point(189, 422);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Orange;
            this.pictureBox3.Location = new System.Drawing.Point(854, 422);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Purple;
            this.pictureBox4.Location = new System.Drawing.Point(636, 422);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // UC_Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_rightArrow);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.lbl_leftArrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Availability);
            this.Controls.Add(this.cb_Room);
            this.Controls.Add(this.dg_Schedule);
            this.Name = "UC_Scheduler";
            this.Size = new System.Drawing.Size(932, 535);
            this.Load += new System.EventHandler(this.UC_Scheduler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Schedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Schedule;
        private System.Windows.Forms.ComboBox cb_Room;
        private System.Windows.Forms.Button btn_Availability;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_leftArrow;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_rightArrow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
