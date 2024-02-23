namespace Y14_CA
{
    partial class UC_Conference
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
            this.label1 = new System.Windows.Forms.Label();
            this.count_Tea = new System.Windows.Forms.NumericUpDown();
            this.count_Coffee = new System.Windows.Forms.NumericUpDown();
            this.count_Biscuit = new System.Windows.Forms.NumericUpDown();
            this.count_Scones = new System.Windows.Forms.NumericUpDown();
            this.count_sandwiches = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_timeSpan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_ConStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.dt_ConEnd = new System.Windows.Forms.DateTimePicker();
            this.radiobtn_Afternoon = new System.Windows.Forms.RadioButton();
            this.radiobtn_Morning = new System.Windows.Forms.RadioButton();
            this.count_water = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_totalCost = new System.Windows.Forms.Label();
            this.lbl_Warning = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.count_Tea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Coffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Biscuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Scones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_sandwiches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_water)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conference";
            // 
            // count_Tea
            // 
            this.count_Tea.Location = new System.Drawing.Point(25, 297);
            this.count_Tea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.count_Tea.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.count_Tea.Name = "count_Tea";
            this.count_Tea.Size = new System.Drawing.Size(120, 22);
            this.count_Tea.TabIndex = 2;
            this.count_Tea.ValueChanged += new System.EventHandler(this.count_Tea_ValueChanged);
            // 
            // count_Coffee
            // 
            this.count_Coffee.Location = new System.Drawing.Point(25, 358);
            this.count_Coffee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.count_Coffee.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.count_Coffee.Name = "count_Coffee";
            this.count_Coffee.Size = new System.Drawing.Size(120, 22);
            this.count_Coffee.TabIndex = 3;
            this.count_Coffee.ValueChanged += new System.EventHandler(this.count_Coffee_ValueChanged);
            // 
            // count_Biscuit
            // 
            this.count_Biscuit.Location = new System.Drawing.Point(165, 359);
            this.count_Biscuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.count_Biscuit.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.count_Biscuit.Name = "count_Biscuit";
            this.count_Biscuit.Size = new System.Drawing.Size(120, 22);
            this.count_Biscuit.TabIndex = 4;
            this.count_Biscuit.ValueChanged += new System.EventHandler(this.count_Biscuit_ValueChanged);
            // 
            // count_Scones
            // 
            this.count_Scones.Location = new System.Drawing.Point(165, 297);
            this.count_Scones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.count_Scones.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.count_Scones.Name = "count_Scones";
            this.count_Scones.Size = new System.Drawing.Size(120, 22);
            this.count_Scones.TabIndex = 5;
            this.count_Scones.ValueChanged += new System.EventHandler(this.count_Scones_ValueChanged);
            // 
            // count_sandwiches
            // 
            this.count_sandwiches.Location = new System.Drawing.Point(165, 421);
            this.count_sandwiches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.count_sandwiches.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.count_sandwiches.Name = "count_sandwiches";
            this.count_sandwiches.Size = new System.Drawing.Size(120, 22);
            this.count_sandwiches.TabIndex = 6;
            this.count_sandwiches.ValueChanged += new System.EventHandler(this.count_sandwiches_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Coffee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Biscuits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Scones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sandwiches";
            // 
            // cb_timeSpan
            // 
            this.cb_timeSpan.FormattingEnabled = true;
            this.cb_timeSpan.Items.AddRange(new object[] {
            "Half-Day",
            "Full-Day",
            "Multiple Days"});
            this.cb_timeSpan.Location = new System.Drawing.Point(229, 170);
            this.cb_timeSpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_timeSpan.Name = "cb_timeSpan";
            this.cb_timeSpan.Size = new System.Drawing.Size(121, 24);
            this.cb_timeSpan.TabIndex = 12;
            this.cb_timeSpan.SelectedValueChanged += new System.EventHandler(this.cb_timeSpan_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Timespan";
            // 
            // dt_ConStart
            // 
            this.dt_ConStart.Location = new System.Drawing.Point(193, 110);
            this.dt_ConStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_ConStart.Name = "dt_ConStart";
            this.dt_ConStart.Size = new System.Drawing.Size(200, 22);
            this.dt_ConStart.TabIndex = 14;
            this.dt_ConStart.CloseUp += new System.EventHandler(this.dt_ConStart_CloseUp);
            this.dt_ConStart.DropDown += new System.EventHandler(this.dt_ConStart_DropDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Starting from: ";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(185, 462);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(101, 73);
            this.btn_Confirm.TabIndex = 17;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.AutoSize = true;
            this.lbl_endDate.Location = new System.Drawing.Point(125, 218);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(60, 17);
            this.lbl_endDate.TabIndex = 18;
            this.lbl_endDate.Text = "Ending: ";
            this.lbl_endDate.Visible = false;
            // 
            // dt_ConEnd
            // 
            this.dt_ConEnd.Location = new System.Drawing.Point(193, 213);
            this.dt_ConEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_ConEnd.Name = "dt_ConEnd";
            this.dt_ConEnd.Size = new System.Drawing.Size(200, 22);
            this.dt_ConEnd.TabIndex = 19;
            this.dt_ConEnd.Visible = false;
            this.dt_ConEnd.CloseUp += new System.EventHandler(this.dt_ConEnd_CloseUp);
            // 
            // radiobtn_Afternoon
            // 
            this.radiobtn_Afternoon.AutoSize = true;
            this.radiobtn_Afternoon.Location = new System.Drawing.Point(304, 242);
            this.radiobtn_Afternoon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiobtn_Afternoon.Name = "radiobtn_Afternoon";
            this.radiobtn_Afternoon.Size = new System.Drawing.Size(91, 21);
            this.radiobtn_Afternoon.TabIndex = 20;
            this.radiobtn_Afternoon.TabStop = true;
            this.radiobtn_Afternoon.Text = "Afternoon";
            this.radiobtn_Afternoon.UseVisualStyleBackColor = true;
            this.radiobtn_Afternoon.Visible = false;
            this.radiobtn_Afternoon.CheckedChanged += new System.EventHandler(this.radiobtn_Afternoon_CheckedChanged);
            // 
            // radiobtn_Morning
            // 
            this.radiobtn_Morning.AutoSize = true;
            this.radiobtn_Morning.Location = new System.Drawing.Point(151, 242);
            this.radiobtn_Morning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiobtn_Morning.Name = "radiobtn_Morning";
            this.radiobtn_Morning.Size = new System.Drawing.Size(80, 21);
            this.radiobtn_Morning.TabIndex = 21;
            this.radiobtn_Morning.TabStop = true;
            this.radiobtn_Morning.Text = "Morning";
            this.radiobtn_Morning.UseVisualStyleBackColor = true;
            this.radiobtn_Morning.Visible = false;
            this.radiobtn_Morning.CheckedChanged += new System.EventHandler(this.radiobtn_Morning_CheckedChanged);
            // 
            // count_water
            // 
            this.count_water.Location = new System.Drawing.Point(25, 420);
            this.count_water.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.count_water.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.count_water.Name = "count_water";
            this.count_water.Size = new System.Drawing.Size(120, 22);
            this.count_water.TabIndex = 22;
            this.count_water.ValueChanged += new System.EventHandler(this.count_water_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Water";
            // 
            // lbl_totalCost
            // 
            this.lbl_totalCost.AutoSize = true;
            this.lbl_totalCost.Location = new System.Drawing.Point(21, 470);
            this.lbl_totalCost.Name = "lbl_totalCost";
            this.lbl_totalCost.Size = new System.Drawing.Size(78, 17);
            this.lbl_totalCost.TabIndex = 24;
            this.lbl_totalCost.Text = "Total cost: ";
            // 
            // lbl_Warning
            // 
            this.lbl_Warning.AutoSize = true;
            this.lbl_Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Warning.ForeColor = System.Drawing.Color.Red;
            this.lbl_Warning.Location = new System.Drawing.Point(77, 138);
            this.lbl_Warning.Name = "lbl_Warning";
            this.lbl_Warning.Size = new System.Drawing.Size(373, 17);
            this.lbl_Warning.TabIndex = 25;
            this.lbl_Warning.Text = "Late fee: Bookins is less than 3 days before today";
            this.lbl_Warning.Visible = false;
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(304, 297);
            this.txt_Note.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(191, 148);
            this.txt_Note.TabIndex = 26;
            this.txt_Note.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(347, 277);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Special requests";
            // 
            // UC_Conference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.lbl_Warning);
            this.Controls.Add(this.lbl_totalCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.count_water);
            this.Controls.Add(this.radiobtn_Morning);
            this.Controls.Add(this.radiobtn_Afternoon);
            this.Controls.Add(this.dt_ConEnd);
            this.Controls.Add(this.lbl_endDate);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dt_ConStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_timeSpan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.count_sandwiches);
            this.Controls.Add(this.count_Scones);
            this.Controls.Add(this.count_Biscuit);
            this.Controls.Add(this.count_Coffee);
            this.Controls.Add(this.count_Tea);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Conference";
            this.Size = new System.Drawing.Size(500, 550);
            this.Load += new System.EventHandler(this.UC_Conference_Load);
            ((System.ComponentModel.ISupportInitialize)(this.count_Tea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Coffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Biscuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_Scones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_sandwiches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_water)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown count_Tea;
        private System.Windows.Forms.NumericUpDown count_Coffee;
        private System.Windows.Forms.NumericUpDown count_Biscuit;
        private System.Windows.Forms.NumericUpDown count_Scones;
        private System.Windows.Forms.NumericUpDown count_sandwiches;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_timeSpan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_ConStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.DateTimePicker dt_ConEnd;
        private System.Windows.Forms.RadioButton radiobtn_Afternoon;
        private System.Windows.Forms.RadioButton radiobtn_Morning;
        private System.Windows.Forms.NumericUpDown count_water;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_totalCost;
        private System.Windows.Forms.Label lbl_Warning;
        private System.Windows.Forms.RichTextBox txt_Note;
        private System.Windows.Forms.Label label11;
    }
}
