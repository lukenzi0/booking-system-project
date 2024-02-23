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

namespace Y14_CA
{
    public partial class UC_AddUpdate_S : UserControl
    {
        public event EventHandler refreshTable, clearPanel, createMessageBox;
        public UC_AddUpdate_S()
        {
            InitializeComponent();
        }

        private void UC_AddUpdate_S_Load(object sender, EventArgs e)
        {
            //updates buttons to reflect the form mode
            if (General.CustomerAdd)
            {
                btn_AddUpdate.Text = "Add";
            }
            else if (General.CustomerUpdate)
            {
                btn_AddUpdate.Text = "Update";
                try
                {
                    //selects all the data from the customer you have clicked on
                    General.query = "SELECT * FROM Staff WHERE StaffId = " + General.selectedID;

                    using (General.connection = new SqlConnection(General.connectionString))
                    using (SqlCommand Command = new SqlCommand(General.query, General.connection))
                    using (SqlDataAdapter Adapter = new SqlDataAdapter(Command))
                    {
                        General.connection.Open();
                        DataSet data = new DataSet();
                        Adapter.Fill(data);

                        txt_Forename.Text = data.Tables[0].Rows[0]["Forename"].ToString();
                        txt_Surname.Text = data.Tables[0].Rows[0]["Surname"].ToString();
                        
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btn_AddUpdate_Click(object sender, EventArgs e)
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

            if (General.CustomerAdd)
            {

                //adds a customer to the database using data from the textboxes
                General.query = "INSERT INTO Staff(Forename, Surname) VALUES(@Surname, @Forename)";

                object[] ValueAdd = new object[] { txt_Forename.Text, txt_Surname.Text };
                General.GenericInsertUpdate(ValueAdd);

                this.Hide();
            }
            else if (General.CustomerUpdate)
            {
                //updates customer data using the data that was put in the textboxes
                General.query = "UPDATE Staff SET Forename=@Forename, Surname=@Surname WHERE StaffId = " + General.selectedID;

                object[] ValueAdd = new object[] { txt_Forename.Text, txt_Surname.Text };
                General.GenericInsertUpdate(ValueAdd);

                this.Hide();
            }

            refreshTable?.Invoke(this, EventArgs.Empty);
        }

        private void btn_Back_Click(object sender, EventArgs e)
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
    }
}
