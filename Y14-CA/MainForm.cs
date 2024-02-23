using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y14_CA
{
    public partial class MainForm : Form
    {   
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            lbl_Caption.Text = "Business";

            UC_Business Business = new UC_Business();

            Business.showBooking += new EventHandler(loadBooking);
            Business.createMessageBox += new EventHandler(CreateMessageBox);
            Business.showAdd += new EventHandler(AddUpdateFormLoad);
            Business.showUpdate += new EventHandler(AddUpdateFormLoad);
            Business.addCard += new EventHandler(AddCard);

            InsertInPanel(Business);
        }

        private void AddCard(object sender, EventArgs e)
        {
            UC_AddCard Card = new UC_AddCard();
            Card.createMessageBox += new EventHandler(CreateMessageBox);

            InsertInPanel(Card);
        }

        private void loadBooking(object sender, EventArgs e)
        {
            lbl_Caption.Text = "Booking";

            UC_Booking booking = new UC_Booking();
            booking.createMessageBox += new EventHandler(CreateMessageBox);
            InsertInPanel(booking);
        }

        private void AddUpdateFormLoad(object sender, EventArgs e)
        {
            if (General.CustomerAdd)
            {
                lbl_Caption.Text = "Add";
            }
            else if (General.CustomerUpdate)
            {
                lbl_Caption.Text = "Update";
            }

            UC_AddUpdate AddUpdate = new UC_AddUpdate();
            AddUpdate.createMessageBox += new EventHandler(CreateMessageBox);
            InsertInPanel(AddUpdate);
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            lbl_Caption.Text = "Staff";

            UC_Staff staff = new UC_Staff();
            staff.createMessageBox += new EventHandler(CreateMessageBox);
            InsertInPanel(staff);
        }

        private void btn_Appointments_Click(object sender, EventArgs e)
        {
            lbl_Caption.Text = "Lease";

            UC_Lease Lease = new UC_Lease();
            Lease.loadSchedule += new EventHandler(loadScheduler);
            Lease.createMessageBox += new EventHandler(CreateMessageBox);
            InsertInPanel(Lease);
        }

        private void loadScheduler(object o, EventArgs e)
        {
            lbl_Caption.Text = "Schedule";

            UC_Scheduler scheduler = new UC_Scheduler();
            scheduler.createMessageBox += new EventHandler(CreateMessageBox);
            InsertInPanel(scheduler);
        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            lbl_Caption.Text = "Payments";

            UC_Payments Payment = new UC_Payments();
            Payment.updatePanel += new EventHandler(updatePanel);
            Payment.createMessageBox += new EventHandler(CreateMessageBox);
            InsertInPanel(Payment);
        }

        private void updatePanel(object o, EventArgs e)
        {
            UC_Crystal_Payments crystal = new UC_Crystal_Payments();
            InsertInPanel(crystal);
        }

        private void InsertInPanel(Control UserControl)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(UserControl);
        }

        private void CreateMessageBox(object o, EventArgs e)
        {
            MainPanel.Enabled = false;

            MessageBox_Form messageBox = new MessageBox_Form(General.Message, General.isDialogue);
            messageBox.enablePanel += new EventHandler(EnablePanel);
            messageBox.disablePanel += new EventHandler(DisablePanel);

            messageBox.ShowDialog();
        }

        private void DisablePanel(object o, EventArgs e)
        {
            MainPanel.Enabled = false;
        }

        private void EnablePanel(object o, EventArgs e)
        {
            MainPanel.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
