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
    public partial class UC_Conference : UserControl
    {
        public event EventHandler reloadTable, createMessageBox;
        public DateTime StartDate, EndDate, CompareDate, DateBooked, Today;
        public string ConTime = "";
        public int conferenceDayCost = 80, finalRoomCost, totalDays, finalCost, cateringCost;
        public double lateFee;
        public bool isLate = false;

        public UC_Conference()
        {
            InitializeComponent();

            dt_ConStart.MinDate = DateTime.Today.AddDays(2);
            dt_ConEnd.MinDate = DateTime.Today.AddDays(4);
            dt_ConEnd.MaxDate = DateTime.Today.AddDays(9);

            StartDate = DateTime.ParseExact(dt_ConStart.Value.ToShortDateString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Today = DateTime.ParseExact(DateTime.Today.ToShortDateString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            checkIfLate();
        }

        private void UC_Conference_Load(object sender, EventArgs e)
        {
            checkIfLate();
        }

        private void checkIfLate()
        {
            StartDate = DateTime.ParseExact(dt_ConStart.Value.ToShortDateString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            TimeSpan daysUntilBook = StartDate - Today;
            if ((int)daysUntilBook.TotalDays <= 3)
            {
                isLate = true;
                lbl_Warning.Visible = true;
            }
            else
            {
                isLate = false;
                lbl_Warning.Visible = false;
            }
        }

        private void cb_timeSpan_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cb_timeSpan.Text == "Multiple Days")
            {
                dt_ConEnd.Visible = true;
                lbl_endDate.Visible = true;

                EndDate = dt_ConEnd.Value;
                TimeSpanCalculation(StartDate, EndDate);

                radiobtn_Morning.Visible = false;
                radiobtn_Afternoon.Visible = false;
            }
            else if(cb_timeSpan.Text == "Half-Day")
            {
                dt_ConEnd.Visible = false;
                lbl_endDate.Visible = false;

                radiobtn_Afternoon.Visible = true;
                radiobtn_Morning.Visible = true;

                finalRoomCost = conferenceDayCost / 2;
            }
            else
            {
                dt_ConEnd.Visible = false;
                lbl_endDate.Visible = false;

                radiobtn_Morning.Visible = false;
                radiobtn_Afternoon.Visible = false;

                finalRoomCost = conferenceDayCost;
            }
        }

        private void dt_ConStart_DropDown(object sender, EventArgs e)
        {
            CompareDate = dt_ConStart.Value;
        }

        private void dt_ConStart_CloseUp(object sender, EventArgs e)
        {   

            if(CompareDate != dt_ConStart.Value)
            {
                dt_ConEnd.MaxDate = DateTimePicker.MaximumDateTime;
                dt_ConEnd.MinDate = DateTimePicker.MinimumDateTime; //Adjusts date times to avoid over or underflow errors

                dt_ConEnd.MinDate = dt_ConStart.Value.AddDays(2);
                dt_ConEnd.MaxDate = dt_ConStart.Value.AddDays(7);
            }
            checkIfLate();
        }

        private void dt_ConEnd_CloseUp(object sender, EventArgs e)
        {
            EndDate = dt_ConEnd.Value;
            TimeSpanCalculation(StartDate, EndDate);
        }

        private void TimeSpanCalculation(DateTime iStartDate, DateTime iEndDate)
        {
            TimeSpan timeSpan = iEndDate - iStartDate;
            totalDays = (int)timeSpan.TotalDays;

            finalRoomCost = conferenceDayCost * totalDays;     
        }

        private void radiobtn_Morning_CheckedChanged(object sender, EventArgs e)
        {
            ConTime = "Morning";
        }

        private void radiobtn_Afternoon_CheckedChanged(object sender, EventArgs e)
        {
            ConTime = "Afternoon";
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (cb_timeSpan.Text == "")
            {
                General.Message = "Please select a date range for the booking";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }

            if (ConTime == "" && cb_timeSpan.Text == "Half-Day")
            {
                General.Message = "Please select a time for the booking";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }

            if (cb_timeSpan.Text == "Half-Day")
            {
                EndDate = dt_ConStart.Value;
            }
            else if(cb_timeSpan.Text == "Full-Day")
            {
                EndDate = dt_ConStart.Value;
                ConTime = "Full day";
            }
            else if (cb_timeSpan.Text == "Multiple Days")
            {
                EndDate = dt_ConEnd.Value;
                ConTime = "Full day";
            }

            int ConferenceId = 11;

            General.Message = "Are you sure this is correct?";
            General.isDialogue = true;
            createMessageBox?.Invoke(this, EventArgs.Empty);

            if (General.DialogueResponse == "Yes")
            {
                StartDate = DateTime.ParseExact(dt_ConStart.Value.ToShortDateString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                General.query = "SELECT COUNT(*) FROM Booking WHERE (@StartDate <= EndDate) AND (StartDate <= @EndDate) AND (ConTime = 'Morning' OR ConTime = 'Afternoon') AND RoomId = @ConferenceId";

                using (General.connection = new SqlConnection(General.connectionString))
                using(SqlCommand Command = new SqlCommand(General.query, General.connection))
                {
                    General.connection.Open();

                    Command.Parameters.AddWithValue("@StartDate", StartDate);
                    Command.Parameters.AddWithValue("@EndDate", EndDate);
                    Command.Parameters.AddWithValue("@ConferenceId", ConferenceId);

                    int count = Convert.ToInt32(Command.ExecuteScalar());

                    if(count == 2)
                    {
                        General.Message = "There are bookings within this timeslot. Please check the scheduler for more information";
                        createMessageBox?.Invoke(this, EventArgs.Empty);
                        return;
                    }
                }

                    General.query = "SELECT COUNT(*) FROM Booking WHERE (@StartDate <= EndDate) AND (StartDate <= @EndDate) AND RoomId = @ConferenceId AND (ConTime = @ConTime OR ConTime = 'Full day')";
                
                using (General.connection = new SqlConnection(General.connectionString))
                using(SqlCommand Command = new SqlCommand(General.query, General.connection))
                {
                    General.connection.Open();

                    Command.Parameters.AddWithValue("@StartDate", StartDate);
                    Command.Parameters.AddWithValue("@EndDate", EndDate);
                    Command.Parameters.AddWithValue("@ConferenceId", ConferenceId);
                    Command.Parameters.AddWithValue("@ConTime", ConTime);

                    Int32 count = Convert.ToInt32(Command.ExecuteScalar());

                    if(count > 0)
                    {
                        General.Message = "There are bookings within this timeslot. Please check the scheduler for more information";
                        General.isDialogue = false;
                        createMessageBox?.Invoke(this, EventArgs.Empty);
                        return;
                    }
                    else
                    {
                        General.roomType = "Conference";
                       
                            General.query = "INSERT INTO Booking(StartDate, EndDate, RoomId, ConTime) VALUES(@StartDate, @EndDate, @RoomId, @ConTime)";

                            object[] ValueAdd = new object[] { StartDate, EndDate, ConferenceId, ConTime };
                            General.GenericInsertUpdate(ValueAdd);

                        General.query = "INSERT INTO Catering(Tea, Coffee, Water, Scones, Biscuits, Sandwiches, cateringCost, Notes) VALUES(@Tea, @Coffee, @Water, @Scones, @Biscuits, @Sandwiches, @cateringCost, @Notes)";
                        object[] objectAdd = new object[] { count_Tea.Value, count_Coffee.Value, count_water.Value, count_Scones.Value, count_Biscuit.Value, count_sandwiches.Value, cateringCost, txt_Note.Text };
                        General.GenericInsertUpdate(objectAdd);

                        DateBooked = DateTime.ParseExact(DateTime.Today.ToShortDateString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        General.query = "SELECT MAX(BookingId) FROM Booking";
                        General.NewestId = General.GetNewestId();

                        General.query = "SELECT MAX(CateringId) FROM Catering";
                        int NewestCateringId = General.GetNewestId();


                        General.query = "INSERT INTO BookingData(BusinessId, BookingId, StaffId, CateringId, RoomType, DateBooked, TotalCost) VALUES(@BusinessId, @BookingId, @StaffId, @CateringId, @RoomType, @DateBooked, @TotalCost)";

                        object[] Value_Add = new object[] { General.selectedID, General.NewestId, General.StaffId, NewestCateringId, General.roomType, DateBooked, finalCost };
                        General.GenericInsertUpdate(Value_Add);

                        General.query = "SELECT MAX(DataId) FROM BookingData";
                        General.NewestDataId = General.GetNewestId();

                        reloadTable?.Invoke(this, EventArgs.Empty);

                        DateTime DueDate = StartDate.AddDays(-1);
                        try
                        {
                            General.query = "INSERT INTO PaymentHistory(DataId, Amount, DateDue) VALUES (@DataId, @Amount, @DateDue)";
                            object[] ObjectAdd = new object[] { General.NewestDataId, finalCost, DueDate };
                            General.GenericInsertUpdate(ObjectAdd);
                        }
                        catch(Exception ex) { }

                    }
                }

            }
            else if(General.DialogueResponse == "No")
            {
                return;
            }
        }
        private void CostCalculation()
        {
            cateringCost = ((int)count_Biscuit.Value * 2) + ((int)count_Coffee.Value * 3) + ((int)count_sandwiches.Value * 5) + ((int)count_Scones.Value * 2) + ((int)count_Tea.Value * 3);
            finalCost = cateringCost + finalRoomCost;

            if (isLate)
            {
                lateFee = finalCost * 0.1;
                finalCost = cateringCost + finalRoomCost + (int)lateFee;
            }
            else
            {
                finalCost = finalRoomCost + cateringCost;
            }

            lbl_totalCost.Text = "Total Cost: £" + finalCost.ToString();
        }

        private void count_Scones_ValueChanged(object sender, EventArgs e)
        {
            CostCalculation();
        }

        private void count_Tea_ValueChanged(object sender, EventArgs e)
        {
            CostCalculation();
        }

        private void count_Biscuit_ValueChanged(object sender, EventArgs e)
        {
            CostCalculation();
        }

        private void count_Coffee_ValueChanged(object sender, EventArgs e)
        {
            CostCalculation();
        }

        private void count_sandwiches_ValueChanged(object sender, EventArgs e)
        {
            CostCalculation();
        }

        private void count_water_ValueChanged(object sender, EventArgs e)
        {
            CostCalculation();
        }
    }
}
