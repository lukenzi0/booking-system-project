using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y14_CA
{
    public partial class UC_Booking : UserControl
    {
        public event EventHandler createMessageBox;
        public UC_Booking()
        {
            InitializeComponent();
        }

        private void UC_Booking_Load(object sender, EventArgs e)
        {
            General.query = "SELECT StaffId, Forename, Surname FROM Staff";
            General.ListViewFill(lstStaff);
        }

        private void btn_Office_Click(object sender, EventArgs e)
        {
            UC_Office office = new UC_Office();
            office.createMessageBox += new EventHandler(conferenceOfficeMessageBox);
            InsertInPanel(office);
        }

        private void btn_Conference_Click(object sender, EventArgs e)
        {
            UC_Conference conference = new UC_Conference();
            conference.createMessageBox += new EventHandler(conferenceOfficeMessageBox);
            InsertInPanel(conference);
            
        }

        private void InsertInPanel(Control UC)
        {
            if (lstStaff.SelectedItems.Count == 0)
            {
                General.Message = "Please select a staff member for the booking";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else
            {
                General.StaffId = lstStaff.SelectedItems[0].SubItems[0].Text;
                txt_StaffSelected.Text = lstStaff.SelectedItems[0].SubItems[1].Text + " " + lstStaff.SelectedItems[0].SubItems[2].Text;
            }

            pnl_OfficeConference.Controls.Clear();
            pnl_OfficeConference.Controls.Add(UC);
        }

        private void conferenceOfficeMessageBox(object o, EventArgs e)
        {
            createMessageBox?.Invoke(this, EventArgs.Empty);
        }
    }
}
