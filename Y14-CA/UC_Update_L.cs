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
    public partial class UC_Update_L : UserControl
    {
        public string ConTime;
        public DateTime Compare_StartDate, Compare_EndDate;
        public DateTime Today = DateTime.ParseExact(DateTime.Today.ToShortDateString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        public TimeSpan OriginalTimeSpan;
        public event EventHandler refreshTable, createMessageBox;
        public UC_Update_L()
        {
            InitializeComponent();
        }

        private void UC_Update_L_Load(object sender, EventArgs e)
        {
            OriginalTimeSpan = General.Lease_EndDate - General.Lease_StartDate;

            dt_StartDate.Value = General.Lease_StartDate;
            dt_EndDate.Value = General.Lease_EndDate;
        }

        private void radbtn_Morning_CheckedChanged(object sender, EventArgs e)
        {
            ConTime = "Morning";
        }

        private void radbtn_Afternoon_CheckedChanged(object sender, EventArgs e)
        {
            ConTime = "Afternoon";
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            Compare_StartDate = dt_StartDate.Value;
            TimeSpan timeToLease = Compare_StartDate - Today;
            TimeSpan NewTimeSpan = dt_EndDate.Value - dt_StartDate.Value;
            if(timeToLease.Days <= 7)
            {
                General.Message = "This lease is too short notice";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else if(dt_StartDate.Value > dt_EndDate.Value || dt_EndDate.Value < dt_StartDate.Value)
            {
                General.Message = "Invalid dates chosen";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else if (OriginalTimeSpan != NewTimeSpan)
            {
                General.Message = "Please choose an equivalent time span for the lease";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else
            {
                General.query = "UPDATE Booking SET StartDate=@Startdate,EndDate=@EndDate WHERE Booking.BookingId = " + General.selectedID;
                object[] ValueAdd = new object[] { dt_StartDate.Value, dt_EndDate.Value };
                General.GenericInsertUpdate(ValueAdd);

                refreshTable?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
