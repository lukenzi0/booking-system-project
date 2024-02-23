namespace Y14_CA
{
    partial class UC_Update_L
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
            this.dt_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dt_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radbtn_Morning = new System.Windows.Forms.RadioButton();
            this.radbtn_Afternoon = new System.Windows.Forms.RadioButton();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dt_StartDate
            // 
            this.dt_StartDate.Location = new System.Drawing.Point(135, 66);
            this.dt_StartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dt_StartDate.Name = "dt_StartDate";
            this.dt_StartDate.Size = new System.Drawing.Size(172, 22);
            this.dt_StartDate.TabIndex = 0;
            // 
            // dt_EndDate
            // 
            this.dt_EndDate.Location = new System.Drawing.Point(132, 158);
            this.dt_EndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dt_EndDate.Name = "dt_EndDate";
            this.dt_EndDate.Size = new System.Drawing.Size(172, 22);
            this.dt_EndDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "End date:";
            // 
            // radbtn_Morning
            // 
            this.radbtn_Morning.AutoSize = true;
            this.radbtn_Morning.Location = new System.Drawing.Point(61, 266);
            this.radbtn_Morning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radbtn_Morning.Name = "radbtn_Morning";
            this.radbtn_Morning.Size = new System.Drawing.Size(80, 21);
            this.radbtn_Morning.TabIndex = 4;
            this.radbtn_Morning.TabStop = true;
            this.radbtn_Morning.Text = "Morning";
            this.radbtn_Morning.UseVisualStyleBackColor = true;
            this.radbtn_Morning.CheckedChanged += new System.EventHandler(this.radbtn_Morning_CheckedChanged);
            // 
            // radbtn_Afternoon
            // 
            this.radbtn_Afternoon.AutoSize = true;
            this.radbtn_Afternoon.Location = new System.Drawing.Point(195, 266);
            this.radbtn_Afternoon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radbtn_Afternoon.Name = "radbtn_Afternoon";
            this.radbtn_Afternoon.Size = new System.Drawing.Size(91, 21);
            this.radbtn_Afternoon.TabIndex = 5;
            this.radbtn_Afternoon.TabStop = true;
            this.radbtn_Afternoon.Text = "Afternoon";
            this.radbtn_Afternoon.UseVisualStyleBackColor = true;
            this.radbtn_Afternoon.CheckedChanged += new System.EventHandler(this.radbtn_Afternoon_CheckedChanged);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(132, 332);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(100, 79);
            this.btn_Confirm.TabIndex = 6;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // UC_Update_L
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.radbtn_Afternoon);
            this.Controls.Add(this.radbtn_Morning);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_EndDate);
            this.Controls.Add(this.dt_StartDate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_Update_L";
            this.Size = new System.Drawing.Size(373, 443);
            this.Load += new System.EventHandler(this.UC_Update_L_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_StartDate;
        private System.Windows.Forms.DateTimePicker dt_EndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radbtn_Morning;
        private System.Windows.Forms.RadioButton radbtn_Afternoon;
        private System.Windows.Forms.Button btn_Confirm;
    }
}
