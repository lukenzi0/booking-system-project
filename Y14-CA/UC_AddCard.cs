using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Y14_CA
{
    public partial class UC_AddCard : UserControl
    {
        public event EventHandler clearPanel, createMessageBox;
        public UC_AddCard()
        {
            InitializeComponent();
        }

        private void UC_AddCard_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            General.Message = "Are you sure you want to leave without making changes?";
            General.isDialogue = true;
            createMessageBox?.Invoke(this, EventArgs.Empty);

            if (General.DialogueResponse == "Yes")
            {
                clearPanel?.Invoke(this, EventArgs.Empty);
            }
            else if (General.DialogueResponse == "No")
            {
                return;
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {       
            foreach(Control x in this.Controls)
            {   
                if(x is TextBox)
                {
                    if (x.Text == "")
                    {
                        General.Message = "Please do not leave any fields blank";
                        General.isDialogue = false;
                        createMessageBox?.Invoke(this, EventArgs.Empty);
                        return;
                    }
                }
            }
            General.Message = "Are you sure these are the correct details?";
            General.isDialogue = true;
            createMessageBox?.Invoke(this, EventArgs.Empty);

            if(General.DialogueResponse == "Yes")
            {
                string expiryDateString = "01/" + txt_ExpiryMonth.Text + "/" + txt_ExpiryYear.Text;
                DateTime expiryDate = DateTime.ParseExact(expiryDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                string cardNumber = txt_cardNumber1.Text + " " + txt_cardNumber2.Text + " " + txt_cardNumber3.Text + " " + txt_cardNumber4.Text;
                General.query = "INSERT INTO Cards (CardNumber, CardHolderName, CVC, ExpiryDate, BusinessId) VALUES(@CardNumber, @CardHolderName, @CVC, @ExpiryDate, @BusinessId)";
                object[] ValueAdd = new object[] { cardNumber, txt_cardHolder.Text, txt_CVC.Text, expiryDate, General.selectedID };
                General.GenericInsertUpdate(ValueAdd);

                clearPanel?.Invoke(this, EventArgs.Empty);
            }
            else if(General.DialogueResponse == "No")
            {
                return;
            }
        }

        private void txt_cardNumber1_TextChanged(object sender, EventArgs e)
        {
            FocusNextTextbox(txt_cardNumber1, txt_cardNumber2, txt_cardNumber1);
        }

        private void txt_cardNumber2_TextChanged(object sender, EventArgs e)
        {
            FocusNextTextbox(txt_cardNumber2, txt_cardNumber3, txt_cardNumber1);
        }

        private void txt_cardNumber3_TextChanged(object sender, EventArgs e)
        {
            FocusNextTextbox(txt_cardNumber3, txt_cardNumber4, txt_cardNumber2);
        }
        private void txt_cardNumber4_TextChanged(object sender, EventArgs e)
        {
            FocusNextTextbox(txt_cardNumber4, txt_cardNumber4, txt_cardNumber3);
        }

        private void txt_ExpiryDate1_TextChanged(object sender, EventArgs e)
        {
            FocusNextTextbox(txt_ExpiryMonth, txt_ExpiryYear, txt_ExpiryMonth);
        }

        private void txt_ExpiryDate2_TextChanged(object sender, EventArgs e)
        {
            FocusNextTextbox(txt_ExpiryYear, txt_ExpiryYear, txt_ExpiryMonth);
        }

        private void FocusNextTextbox(TextBox First_textBox, TextBox Next_textBox, TextBox Before_textBox)
        {
            if(First_textBox.Text.Length == First_textBox.MaxLength)
            {
                Next_textBox.Focus();
            }
            else if(First_textBox.Text.Length == 0)
            {
                Before_textBox.Focus();
            }
        }
    }
}
