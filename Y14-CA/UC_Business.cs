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
    public partial class UC_Business : UserControl
    {   
        public event EventHandler showUpdate, showAdd, showBooking, addCard, createMessageBox;
        public UC_Business()
        {
            InitializeComponent();
        }

        private void ClientUC_Load(object sender, EventArgs e)
        {
            CustomerLoadTable();
        }

        private void CustomerLoadTable()
        {
            General.CustomerAdd = false;
            General.CustomerUpdate = false;
            General.query = "SELECT BusinessId, BusinessName, Address1, Address2, PostCode, City, County, PrimaryContact, SecondaryContact, Email FROM Business ORDER BY Business.BusinessName ASC";
            General.ListViewFill(lstBusiness);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            General.CustomerAdd = true;
            General.CustomerUpdate = false;
            showAdd?.Invoke(this, EventArgs.Empty);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //checks if you have selected a customer
            if (lstBusiness.SelectedItems.Count > 0)
            {
                //saves the Id of the customer selected
                General.CustomerUpdate = true;
                General.CustomerAdd = false;
                General.selectedID = lstBusiness.SelectedItems[0].SubItems[0].Text;
                showUpdate?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                General.Message = "Please select a business to update";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //checks if a customer is selected
            if (lstBusiness.SelectedItems.Count > 0)
            {
                General.query = "SELECT COUNT(*) FROM PaymentsMade INNER JOIN PaymentHistory ON PaymentHistory.PaymentId = PaymentsMade.PaymentId INNER JOIN BookingData ON BookingData.DataId = PaymentHistory.DataId INNER JOIN Business ON Business.BusinessId = BookingData.BusinessId WHERE Business.BusinessId = " + lstBusiness.SelectedItems[0].SubItems[0].Text;
                using (General.connection = new SqlConnection(General.connectionString))
                using (SqlCommand Command = new SqlCommand(General.query, General.connection))
                using (SqlDataAdapter Adapter = new SqlDataAdapter(Command))
                {
                    Int32 count = Convert.ToInt32(Command.ExecuteScalar());
                    if (count > 0)
                    {
                        General.Message = "Business cannot be deleted as it has made payments";
                        General.isDialogue = false;
                        createMessageBox?.Invoke(this, EventArgs.Empty);

                        return;
                    }
                }

                General.Message = "Are you sure you want to delete this client?";
                General.isDialogue = true;
                createMessageBox?.Invoke(this, EventArgs.Empty);

                if(General.DialogueResponse == "Yes")
                {
                    General.query = "DELETE FROM Business WHERE BusinessId = " + lstBusiness.SelectedItems[0].SubItems[0].Text;
                    General.GenericDelete();

                    //reloads the table
                    CustomerLoadTable();
                }
                if(General.DialogueResponse == "No")
                {
                    return;
                }
            }
            else
            {
                General.Message = "Please select a business to delete";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
        }

        private void btn_Appointment_Click(object sender, EventArgs e)
        {
            if (lstBusiness.SelectedItems.Count > 0)
            {
                General.selectedID = lstBusiness.SelectedItems[0].SubItems[0].Text;
                showBooking?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                General.Message = "Please select a business to make a booking with";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
        }

        private void btn_Card_Click(object sender, EventArgs e)
        {
            if(lstBusiness.SelectedItems.Count > 0)
            { 
                General.selectedID = lstBusiness.SelectedItems[0].SubItems[0].Text;
                addCard?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                General.Message = "Please select a business first";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
        }

        private void CreateMessageBox(object o, EventArgs e)
        {
            createMessageBox?.Invoke(this, EventArgs.Empty);
        }
    }
}
