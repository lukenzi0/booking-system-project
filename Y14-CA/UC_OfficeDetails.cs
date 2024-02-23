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
    public partial class UC_OfficeDetails : UserControl
    {
        public UC_OfficeDetails()
        {
            InitializeComponent();
        }

        private void UC_OfficeDetails_Load(object sender, EventArgs e)
        {
            General.query = "SELECT Desks, Computers, Printers, Telephones, Projectors, Shredders, Notes FROM Furnishing INNER JOIN BookingData ON Furnishing.FurnishingId = BookingData.FurnishingId INNER JOIN Booking ON BookingData.BookingId = Booking.BookingId WHERE Booking.BookingId = " + General.SelectedLeaseId;
            using (General.connection = new SqlConnection(General.connectionString))
            using (SqlCommand Command = new SqlCommand(General.query, General.connection))
            {
                General.connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    lbl_Computers.Text = "Computers:" +  reader["Computers"].ToString();
                    lbl_desks.Text ="Desks: " +  reader["Desks"].ToString();
                    lbl_Notes.Text = reader["Notes"].ToString();
                    lbl_Printers.Text = "Printers: " + reader["Printers"].ToString();
                    lbl_Telephones.Text = "Telephones: " + reader["Telephones"].ToString();
                    lbl_Projectors.Text = "Projectors: " + reader["Projectors"].ToString();
                    lbl_Shredders.Text = "Shredders: " + reader["Shredders"].ToString();
                }
            }
        }
    }
}
