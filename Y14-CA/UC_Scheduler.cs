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
    public partial class UC_Scheduler : UserControl
    {
        public event EventHandler createMessageBox;
        public string roomChosen, cellColour, conTime;
        public int roomId;
        public int yearChosen;
        public UC_Scheduler()
        {
            InitializeComponent();
        }

        private void UC_Scheduler_Load(object sender, EventArgs e)
        {
            int thisYear = DateTime.Now.Year;
            yearChosen = thisYear;
            lbl_Year.Text = thisYear.ToString();
        }

        private void btn_Availability_Click(object sender, EventArgs e)
        {
            if(cb_Room.Text == "")
            {
                General.Message = "Please select a room first";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else if(cb_Room.Text == "Conference")
            {
                roomChosen = cb_Room.Text;
                roomId = 11;
                
            }
            else
            {
                char temp = cb_Room.Text[7];
                roomId = (int)char.GetNumericValue(temp);
            }
            dg_Schedule.Rows.Clear();
            dg_Schedule.Columns.Clear();
            dg_Schedule.Refresh();

            getFirstMonth(yearChosen);
            PopulateDataGrid(yearChosen);
        }

        private void getFirstMonth(int year)
        {
            int dayNumber = 0;
            DateTime dateTime = new DateTime(year, 1, 1);

            for(int i = 0; i < DateTime.DaysInMonth(year, 1); i++)
            {
                dayNumber += 1;
                dateTime = new DateTime(year, 1, dayNumber);

                ColumnInsert(dateTime.DayOfWeek);
            }
            int row = dg_Schedule.Rows.Add();
            dg_Schedule.Rows[row].HeaderCell.Value = dateTime.ToString("MMM");
            dg_Schedule.RowHeadersWidth = 60;
        }

        private void ColumnInsert(DayOfWeek dayOfWeek)
        {
            string day = dayOfWeek.ToString();
            int columnIndex = dg_Schedule.Columns.Add(dayOfWeek.ToString(), day.Remove(3, day.Length - 3));
            dg_Schedule.Columns[columnIndex].Width = 34;
            dg_Schedule.RowTemplate.Height = 20;
            dg_Schedule.Columns[columnIndex].DefaultCellStyle.ForeColor = Color.Lavender;
            
        }

        private void PopulateDataGrid(int year)
        {
            for (int i = 0; i < 12; i++)
            {
                DateTime dt = new DateTime(year, i + 1, 1);
                int row = 0;

                if (i > 0)
                {
                    row = dg_Schedule.Rows.Add();
                    dg_Schedule.Rows[row].HeaderCell.Value = dt.ToString("MMM");
                }

                int startFrom = 0;
                for (int j = 0; j < DateTime.DaysInMonth(year, i + 1); j++)
                {
                    DateTime currentDay = new DateTime(year, i + 1, j + 1);

                    getCellColour(currentDay, roomId);
                    
                    //calculate start position
                    if (j == 0)
                    {
                        int month = i + 1;
                        int day = j + 1;
                        DateTime x = new DateTime(year, month, day);

                        startFrom = First(x.DayOfWeek.ToString());
                    }

                    // Create extra columns if is neded.
                    if (dg_Schedule.Columns.Count <= j + startFrom)
                    {
                        ColumnInsert(currentDay.DayOfWeek);
                    }

                    // Set cell value.
                    dg_Schedule[j + startFrom, row].Value = currentDay.Day.ToString();
                    if(cellColour == "DarkBlue")
                    {
                        dg_Schedule.Rows[row].Cells[j + startFrom].Style.BackColor = Color.DarkBlue;
                    }
                    else if(cellColour == "LightBlue")
                    {
                        dg_Schedule.Rows[row].Cells[j + startFrom].Style.BackColor = Color.CornflowerBlue;
                    }
                    else if(cellColour == "Lavender")
                    {
                        dg_Schedule.Rows[row].Cells[j + startFrom].Style.BackColor = Color.Lavender;
                    }
                    else if(cellColour == "Orange")
                    {
                        dg_Schedule.Rows[row].Cells[j + startFrom].Style.BackColor = Color.Orange;
                    }
                    else if(cellColour == "Purple")
                    {
                        dg_Schedule.Rows[row].Cells[j + startFrom].Style.BackColor = Color.Purple;
                    }
                    dg_Schedule.CurrentCell = null;
                }
            }
        }

        private void getCellColour(DateTime checkDate, int roomId)
        {
            cellColour = "None";
            conTime = "";
            int count;
            

            if(cb_Room.Text == "Conference")
            {   
                //checks how many bookings are made for a date
                General.query = "SELECT COUNT(*) FROM Booking WHERE (@CheckDate <= EndDate) AND (StartDate <= @CheckDate) AND RoomId = @RoomId";
                using (General.connection = new SqlConnection(General.connectionString))
                using(SqlCommand Command = new SqlCommand(General.query, General.connection))
                {
                    General.connection.Open();
                    Command.Parameters.AddWithValue("@RoomId", roomId);
                    Command.Parameters.AddWithValue("@CheckDate", checkDate);

                    count = Convert.ToInt32(Command.ExecuteScalar());
                }
                //selects the time(s) the conference is booked for
                General.query = "SELECT Booking.ConTime FROM Booking WHERE (@CheckDate <= EndDate) AND (StartDate <= @CheckDate) AND RoomId = @RoomId";
                using (General.connection = new SqlConnection(General.connectionString))
                using (SqlCommand Command = new SqlCommand(General.query, General.connection))
                using(SqlDataAdapter Adapter = new SqlDataAdapter(Command))
                {
                    General.connection.Open();
                    Command.Parameters.AddWithValue("@RoomId", roomId);
                    Command.Parameters.AddWithValue("@CheckDate", checkDate);

                    DataSet ds = new DataSet();
                    Adapter.Fill(ds, "Booking");

                    if (DateTime.Today > checkDate)//checks if the date is before today 
                    {
                        cellColour = "Lavender";
                    }
                    else if (count == 0)//if no bookings are found
                    {
                        cellColour = "LightBlue";
                    }
                    else if(count > 0)
                    {   
                        conTime = ds.Tables["Booking"].Rows[0]["ConTime"].ToString();//populates 'conTime' with the time(s) the conference is booked
                        if(count == 1)//if one booking for a date is found and checks the time it is booked for
                        {
                            if (conTime == "Morning")
                            {
                                cellColour = "Orange";
                            }
                            else if (conTime == "Afternoon")
                            {
                                cellColour = "Purple";
                            }
                            else if(conTime == "Full day")
                            {
                                cellColour = "DarkBlue";
                            }
                        }
                        else if(count == 2)//'count' equaling two means that there are two bookings for one date (Morning AND Afternoon are booked) so the full day is booked
                        {
                            cellColour = "DarkBlue";
                        }
                    }
                }
            }
            else
            {
                General.query = "SELECT Count(*) FROM Booking WHERE (@CheckDate <= EndDate) AND (StartDate <= @CheckDate) AND RoomId = @RoomId";//counts number of times the date clashes with any date ranges
                using (General.connection = new SqlConnection(General.connectionString))
                using (SqlCommand Command = new SqlCommand(General.query, General.connection))
                {
                    General.connection.Open();
                    Command.Parameters.AddWithValue("@CheckDate", checkDate);
                    Command.Parameters.AddWithValue("@RoomId", roomId);

                    count = Convert.ToInt32(Command.ExecuteScalar());

                    if (DateTime.Today > checkDate)
                    {
                        cellColour = "Lavender";
                    }
                    else if (count > 0)//checks if a booking exists on a date
                    {
                        cellColour = "DarkBlue";
                    }
                    else if (count == 0)
                    {
                        cellColour = "LightBlue";
                    }
                }
            }
        }

        private void lbl_leftArrow_Click(object sender, EventArgs e)
        {
            if (cb_Room.Text == "")
            {
                General.Message = "Please select a room first";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }

            if (yearChosen - 1 < DateTime.Now.Year)
            {
                General.Message = "You cannot choose a year before this";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }

            yearChosen -= 1;
            lbl_Year.Text = yearChosen.ToString();

            dg_Schedule.Rows.Clear();
            dg_Schedule.Columns.Clear();
            dg_Schedule.Refresh();

            getFirstMonth(yearChosen);
            PopulateDataGrid(yearChosen);
        }

        private void lbl_rightArrow_Click(object sender, EventArgs e)
        {
            if (cb_Room.Text == "")
            {
                General.Message = "Please select a room first";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }

            yearChosen += 1;
            lbl_Year.Text = yearChosen.ToString();

            dg_Schedule.Rows.Clear();
            dg_Schedule.Columns.Clear();
            dg_Schedule.Refresh();

            getFirstMonth(yearChosen);
            PopulateDataGrid(yearChosen);
        }

        private int First(string n)
        {
            for (int i = 0; i < dg_Schedule.Columns.Count; i++)
            {
                if (dg_Schedule.Columns[i].Name == n)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
