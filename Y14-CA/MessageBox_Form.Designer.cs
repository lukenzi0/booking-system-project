namespace Y14_CA
{
    partial class MessageBox_Form
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
            this.lbl_Message = new System.Windows.Forms.Label();
            this.lbl_X = new System.Windows.Forms.Label();
            this.btn_No = new System.Windows.Forms.Button();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Message.Location = new System.Drawing.Point(55, 51);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(83, 31);
            this.lbl_Message.TabIndex = 0;
            this.lbl_Message.Text = "label1";
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_X.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_X.Location = new System.Drawing.Point(1180, 9);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(30, 31);
            this.lbl_X.TabIndex = 1;
            this.lbl_X.Text = "X";
            this.lbl_X.Click += new System.EventHandler(this.lbl_X_Click);
            // 
            // btn_No
            // 
            this.btn_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(119)))), ((int)(((byte)(224)))));
            this.btn_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_No.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_No.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_No.Location = new System.Drawing.Point(1001, 35);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(75, 63);
            this.btn_No.TabIndex = 5;
            this.btn_No.Text = "No";
            this.btn_No.UseVisualStyleBackColor = false;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // btn_Yes
            // 
            this.btn_Yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(119)))), ((int)(((byte)(224)))));
            this.btn_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Yes.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Yes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Yes.Location = new System.Drawing.Point(857, 35);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(75, 63);
            this.btn_Yes.TabIndex = 4;
            this.btn_Yes.Text = "Yes";
            this.btn_Yes.UseVisualStyleBackColor = false;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1222, 135);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.btn_Yes);
            this.Controls.Add(this.lbl_X);
            this.Controls.Add(this.lbl_Message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Button btn_No;
        private System.Windows.Forms.Button btn_Yes;
    }
}