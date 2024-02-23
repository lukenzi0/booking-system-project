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
    public partial class UC_ConDetails : UserControl
    {
        public UC_ConDetails()
        {
            InitializeComponent();
        }

        private void UC_ConDetails_Load(object sender, EventArgs e)
        {   
            General.query = "SELECT Catering.Tea, Catering.Coffee, Catering.Water, Catering.Scones, Catering.Biscuits, Catering.Sandwiches, Catering.Notes From Catering INNER JOIN BookingData ON Catering.CateringId = BookingData.CateringId INNER JOIN Booking ON BookingData.BookingId = Booking.BookingId WHERE Booking.BookingId = " + General.SelectedLeaseId;
            using (General.connection = new SqlConnection(General.connectionString))
            using (SqlCommand Command = new SqlCommand(General.query, General.connection))
            {   
                General.connection.Open();

                SqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    lbl_Tea.Text = reader["Tea"].ToString();
                    lbl_Coffee.Text = reader["Coffee"].ToString();
                    lbl_Water.Text = reader["Water"].ToString();
                    lbl_Scones.Text = reader["Scones"].ToString();
                    lbl_Biscuits.Text = reader["Biscuits"].ToString();
                    lbl_Sandwiches.Text = reader["Sandwiches"].ToString();
                    lbl_Notes.Text = reader["Notes"].ToString();
                }
            }
        }
    }
}
