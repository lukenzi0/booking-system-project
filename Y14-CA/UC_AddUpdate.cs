using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Y14_CA
{
    public partial class UC_AddUpdate : UserControl
    {
        public event EventHandler clearPanel, refreshTable, createMessageBox;
        public string invalidValue;

        public UC_AddUpdate()
        {
            InitializeComponent();
        }

        private void UC_AddUpdate_Load(object sender, EventArgs e)
        {
            //updates buttons to reflect the form mode
            if (General.CustomerAdd)
            {
                btnAddUpdate.Text = "Add";
            }
            else if (General.CustomerUpdate)
            {
                btnAddUpdate.Text = "Update";
                try
                {
                    //selects all the data from the customer you have clicked on
                    General.query = "SELECT BusinessName,Address1, Address2, PostCode, City, County, PrimaryContact, SecondaryContact, Email FROM Business WHERE BusinessId = " + General.selectedID[0];
                     
                    using (General.connection = new SqlConnection(General.connectionString))
                    using (SqlCommand Command = new SqlCommand(General.query, General.connection))
                    using (SqlDataAdapter Adapter = new SqlDataAdapter(Command))
                    {
                        General.connection.Open();
                        SqlDataReader reader = Command.ExecuteReader();
                        while (reader.Read())
                        {
                            txtName.Text = reader["BusinessName"].ToString();
                            txtAddress1.Text = reader["Address1"].ToString();
                            txtAddress2.Text = reader["Address2"].ToString();
                            txtPostCode.Text = reader["PostCode"].ToString();
                            txtCity.Text = reader["City"].ToString();
                            txtCounty.Text = reader["County"].ToString();
                            txtPContact.Text = reader["PrimaryContact"].ToString();
                            txtSContact.Text = reader["SecondaryContact"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            //checks the texboxes if they are null
            foreach (Control x in Controls)
            {
                if (x is TextBox)
                {
                    if (x.Text == "")
                    {
                        General.Message = "Please do not leave any fields blank";
                        General.isDialogue = false;
                        createMessageBox?.Invoke(this, EventArgs.Empty);
                        return;
                    }
                }
                else
                {
                    continue;
                }
            }

            string[] txtData = new string[] { txtName.Text, txtAddress1.Text, txtAddress2.Text, txtPostCode.Text, txtCity.Text, txtCounty.Text, txtPContact.Text, txtSContact.Text, txtEmail.Text };
            string[] regexPattern = new string[] { @"^[a-zA-Z]*$", @"[\w',-\\/.\s]", @"[\w',-\\/.\s]", @"^[A-Z]{1,2}[0-9][A-Z0-9]? ?[0-9][A-Z]{2}$", @"^[a-zA-Z]*$", @"^[a-zA-Z]*$", @"^[0-9]*$", @"^[0-9]*$", @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$" };
            if(checkTextFormat(txtData, regexPattern) == false)
            {
                General.Message = invalidValue + " is not a valid value";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }

            if (General.CustomerAdd)
            {
                //adds a customer to the database using data from the textboxes
                General.query = "INSERT INTO Business VALUES(@BusinessName,@Address1,@Address2,@PostCode,@City,@County,@PrimaryContact,@SecondaryContact,@Email)";

                object[] ValueAdd = new object[] { txtName.Text, txtAddress1.Text, txtAddress2.Text, txtPostCode.Text, txtCity.Text, txtCounty.Text, txtPContact.Text, txtSContact.Text, txtEmail.Text };
                General.GenericInsertUpdate(ValueAdd);

                this.Hide();
            }
            else if (General.CustomerUpdate)
            {   
                
                //updates customer data using the data that was put in the textboxes
                General.query = "UPDATE Business SET BusinessName=@BusinessName,Address1=@Address1,Address2=@Address2,PostCode=@PostCode,City=@City,County=@County,PrimaryContact=@PrimaryContact,SecondaryContact=@SecondaryContact,Email=@Email WHERE BusinessId = " + General.selectedID[0];

                object[] ValueAdd = new object[] { txtName.Text, txtAddress1.Text, txtAddress2.Text, txtPostCode.Text, txtCity.Text, txtCounty.Text, txtPContact.Text, txtSContact.Text, txtEmail.Text };
                General.GenericInsertUpdate(ValueAdd);

                this.Hide();
            }

            refreshTable?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            General.Message = "Are you sure you want to leave without making changes?";
            General.isDialogue = true;
            createMessageBox?.Invoke(this, EventArgs.Empty);

            if(General.DialogueResponse == "Yes")
            {
                clearPanel?.Invoke(this, EventArgs.Empty);
            }
            else if(General.DialogueResponse == "No")
            {
                return;
            }
  
        }

        private bool checkTextFormat(string[] itxtData, string[] iregexPattern)
        {
            for (int i = 0; itxtData.Count() > i; i++)
            {
                if(Regex.IsMatch(itxtData[i], iregexPattern[i]) == true)
                {
                    continue;
                }
                else if(Regex.IsMatch(itxtData[i], iregexPattern[i]) == false)
                {
                    invalidValue = itxtData[i];
                    return false;
                }
            }
            return true;
        }
    }
}
