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
using System.Globalization;

namespace Y14_CA
{
    public partial class UC_Lease : UserControl
    {
        public event EventHandler loadSchedule, createMessageBox;
        public UC_Lease()
        {
            InitializeComponent();
        }

        private void UC_Lease_Load(object sender, EventArgs e)
        {
            ReloadTable(this, EventArgs.Empty);
        }

        private void ReloadTable(object o, EventArgs e)
        {
            General.query = "SELECT Booking.BookingId, Business.BusinessName, BookingData.RoomType, Room.RoomId, Booking.StartDate, Booking.EndDate, Booking.ConTime FROM BookingData INNER JOIN Business ON BookingData.BusinessId = Business.BusinessId INNER JOIN Booking ON BookingData.BookingId = Booking.BookingId INNER JOIN Room ON Booking.RoomId = Room.RoomId ORDER BY Booking.StartDate ASC";
            General.ListViewFill(lst_Lease);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (lst_Lease.SelectedItems.Count <= 0)
            {
                General.Message = "Select a lease to update";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }

            string StartDate = lst_Lease.SelectedItems[0].SubItems[4].Text;
            string EndDate = lst_Lease.SelectedItems[0].SubItems[5].Text;

            General.Lease_StartDate = DateTime.Parse(StartDate);
            General.Lease_EndDate = DateTime.Parse(EndDate);

            TimeSpan daysToLease = General.Lease_StartDate - DateTime.Today;
            if (daysToLease.Days <= 7 && lst_Lease.SelectedItems[0].SubItems[2].Text == "Office")
            {
                General.Message = "The office lease cannot be updated a week before the lease starts";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else if(daysToLease.Days <= 3 && lst_Lease.SelectedItems[0].SubItems[2].Text == "Conference")
            {
                General.Message = "The conference lease cannot be updated 3 days before the lease starts";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else
            {
                General.selectedID = lst_Lease.SelectedItems[0].SubItems[0].Text;

                UC_Update_L update = new UC_Update_L();
                pnl_Lease.Controls.Clear();
                pnl_Lease.Controls.Add(update);
                update.refreshTable += new EventHandler(ReloadTable);
                update.createMessageBox += new EventHandler(CreateMessageBox);
            }
        }

        private void btn_Availability_Click(object sender, EventArgs e)
        {
            loadSchedule?.Invoke(this, EventArgs.Empty);
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {   
            if(lst_Lease.SelectedItems.Count > 0)
            {
                General.SelectedLeaseId = lst_Lease.SelectedItems[0].SubItems[0].Text;

                if (lst_Lease.SelectedItems[0].SubItems[2].Text == "Conference")
                {
                    UC_ConDetails ConDetails = new UC_ConDetails();
                    pnl_Lease.Controls.Clear();
                    pnl_Lease.Controls.Add(ConDetails);
                }
                else if(lst_Lease.SelectedItems[0].SubItems[2].Text == "Office")
                {
                    UC_OfficeDetails OfficeDetails = new UC_OfficeDetails();
                    pnl_Lease.Controls.Clear();
                    pnl_Lease.Controls.Add(OfficeDetails);
                }
            }
            else
            {
                General.Message = "Select a lease to see its details";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
            }
        }

        private void CreateMessageBox(object o, EventArgs e)
        {
            createMessageBox?.Invoke(this, EventArgs.Empty);
        }
    }
}
