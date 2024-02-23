namespace Y14_CA
{
    partial class UC_AddCard
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
            this.txt_CVC = new System.Windows.Forms.TextBox();
            this.txt_cardHolder = new System.Windows.Forms.TextBox();
            this.txt_cardNumber1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.txt_cardNumber2 = new System.Windows.Forms.TextBox();
            this.txt_cardNumber3 = new System.Windows.Forms.TextBox();
            this.txt_cardNumber4 = new System.Windows.Forms.TextBox();
            this.txt_ExpiryMonth = new System.Windows.Forms.TextBox();
            this.txt_ExpiryYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_CVC
            // 
            this.txt_CVC.Location = new System.Drawing.Point(74, 244);
            this.txt_CVC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CVC.MaxLength = 3;
            this.txt_CVC.Name = "txt_CVC";
            this.txt_CVC.Size = new System.Drawing.Size(36, 22);
            this.txt_CVC.TabIndex = 2;
            // 
            // txt_cardHolder
            // 
            this.txt_cardHolder.Location = new System.Drawing.Point(134, 111);
            this.txt_cardHolder.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cardHolder.Name = "txt_cardHolder";
            this.txt_cardHolder.Size = new System.Drawing.Size(182, 22);
            this.txt_cardHolder.TabIndex = 3;
            // 
            // txt_cardNumber1
            // 
            this.txt_cardNumber1.Location = new System.Drawing.Point(134, 178);
            this.txt_cardNumber1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cardNumber1.MaxLength = 4;
            this.txt_cardNumber1.Name = "txt_cardNumber1";
            this.txt_cardNumber1.Size = new System.Drawing.Size(40, 22);
            this.txt_cardNumber1.TabIndex = 4;
            this.txt_cardNumber1.Tag = "1";
            this.txt_cardNumber1.TextChanged += new System.EventHandler(this.txt_cardNumber1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Card Holder: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Card number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "CVC:";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(219, 311);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(100, 78);
            this.btn_Confirm.TabIndex = 9;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(23, 311);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 78);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // txt_cardNumber2
            // 
            this.txt_cardNumber2.Location = new System.Drawing.Point(180, 178);
            this.txt_cardNumber2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cardNumber2.MaxLength = 4;
            this.txt_cardNumber2.Name = "txt_cardNumber2";
            this.txt_cardNumber2.Size = new System.Drawing.Size(40, 22);
            this.txt_cardNumber2.TabIndex = 11;
            this.txt_cardNumber2.Tag = "2";
            this.txt_cardNumber2.TextChanged += new System.EventHandler(this.txt_cardNumber2_TextChanged);
            // 
            // txt_cardNumber3
            // 
            this.txt_cardNumber3.Location = new System.Drawing.Point(228, 178);
            this.txt_cardNumber3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cardNumber3.MaxLength = 4;
            this.txt_cardNumber3.Name = "txt_cardNumber3";
            this.txt_cardNumber3.Size = new System.Drawing.Size(40, 22);
            this.txt_cardNumber3.TabIndex = 12;
            this.txt_cardNumber3.Tag = "3";
            this.txt_cardNumber3.TextChanged += new System.EventHandler(this.txt_cardNumber3_TextChanged);
            // 
            // txt_cardNumber4
            // 
            this.txt_cardNumber4.Location = new System.Drawing.Point(276, 178);
            this.txt_cardNumber4.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cardNumber4.MaxLength = 4;
            this.txt_cardNumber4.Name = "txt_cardNumber4";
            this.txt_cardNumber4.Size = new System.Drawing.Size(40, 22);
            this.txt_cardNumber4.TabIndex = 13;
            this.txt_cardNumber4.Tag = "4";
            this.txt_cardNumber4.TextChanged += new System.EventHandler(this.txt_cardNumber4_TextChanged);
            // 
            // txt_ExpiryMonth
            // 
            this.txt_ExpiryMonth.Location = new System.Drawing.Point(223, 244);
            this.txt_ExpiryMonth.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ExpiryMonth.MaxLength = 2;
            this.txt_ExpiryMonth.Name = "txt_ExpiryMonth";
            this.txt_ExpiryMonth.Size = new System.Drawing.Size(24, 22);
            this.txt_ExpiryMonth.TabIndex = 14;
            this.txt_ExpiryMonth.Tag = "1";
            this.txt_ExpiryMonth.TextChanged += new System.EventHandler(this.txt_ExpiryDate1_TextChanged);
            // 
            // txt_ExpiryYear
            // 
            this.txt_ExpiryYear.Location = new System.Drawing.Point(274, 244);
            this.txt_ExpiryYear.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ExpiryYear.MaxLength = 4;
            this.txt_ExpiryYear.Name = "txt_ExpiryYear";
            this.txt_ExpiryYear.Size = new System.Drawing.Size(40, 22);
            this.txt_ExpiryYear.TabIndex = 15;
            this.txt_ExpiryYear.Tag = "1";
            this.txt_ExpiryYear.TextChanged += new System.EventHandler(this.txt_ExpiryDate2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Expiry date:";
            // 
            // UC_AddCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ExpiryYear);
            this.Controls.Add(this.txt_ExpiryMonth);
            this.Controls.Add(this.txt_cardNumber4);
            this.Controls.Add(this.txt_cardNumber3);
            this.Controls.Add(this.txt_cardNumber2);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cardNumber1);
            this.Controls.Add(this.txt_cardHolder);
            this.Controls.Add(this.txt_CVC);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_AddCard";
            this.Size = new System.Drawing.Size(347, 425);
            this.Load += new System.EventHandler(this.UC_AddCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CVC;
        private System.Windows.Forms.TextBox txt_cardHolder;
        private System.Windows.Forms.TextBox txt_cardNumber1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox txt_cardNumber2;
        private System.Windows.Forms.TextBox txt_cardNumber3;
        private System.Windows.Forms.TextBox txt_cardNumber4;
        private System.Windows.Forms.TextBox txt_ExpiryMonth;
        private System.Windows.Forms.TextBox txt_ExpiryYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
