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
    public partial class UC_Office : UserControl
    {
        public event EventHandler reloadTable, createMessageBox;
        public int OfficeId;
        public int overallMonthlyCost, monthlyCost, perPersonCost = 50, cleaningCost = 25, baseRoomCost = 1000;
        public int totalCost, totalMonths, deposit;
        public DateTime StartDate, EndDate, Today, checkExpiryDate;
        public string payementType;
        public bool depositPaid = false;

        private void count_months_ValueChanged(object sender, EventArgs e)
        {   
            //Does not allow a 9 month lease
            if(count_months.Value == 9 && count_years.Value == 0)
            {
                count_months.Value += 3;
            }

            //converts 12 months to 1 year
            if(count_months.Value == 12)
            {
                count_years.Value += 1;
                count_months.Value = 0;
            }

            if (count_months.Value <= 6 && count_years.Value == 0)
            {
                count_Capacity.Maximum = 10;
                count_Capacity.Minimum = 5;

                string[] OfficeList = { "Office 1", "Office 2" };
                PopulateCombobox(OfficeList);

                CostCalculation();
            }
            else
            {
                count_Capacity.Maximum = 20;
                count_Capacity.Minimum = 10;
     
                string[] OfficeList = { "Office 3", "Office 4", "Office 5", "Office 6", "Office 7", "Office 8", "Office 9" };
                PopulateCombobox(OfficeList);

                CostCalculation();
            }
        }


        private void cb_PayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_PayType.Text == "Card")
            {
                lbl_chooseCard.Visible = true;
                cb_chooseCard.Visible = true;

                Fill_cb_chooseCard();
            }
        }

        private void count_years_ValueChanged(object sender, EventArgs e)
        {
            CostCalculation();

            if(count_years.Value >= 1)
            {
                string[] OfficeList = { "Office 3", "Office 4", "Office 5", "Office 6", "Office 7", "Office 8", "Office 9" };

                count_Capacity.Maximum = 20;
                count_Capacity.Minimum = 10;

                PopulateCombobox(OfficeList);

                CostCalculation();
            }
        }

        private void count_Capacity_ValueChanged(object sender, EventArgs e)
        {
            CostCalculation();
        }

        private void CostCalculation()
        {
            overallMonthlyCost = (perPersonCost * (int)count_Capacity.Value) + (cleaningCost * General.daysInMonth) + baseRoomCost;

            totalMonths = (int)count_months.Value + ((int)count_years.Value * 12);

            General.totalCost = (overallMonthlyCost * totalMonths) + ((int)count_Desks.Value * 100) + ((int)count_Computers.Value * 400) + ((int)count_Printers.Value * 50) + ((int)count_Projectors.Value * 100) + ((int)count_Shredders.Value * 80) + ((int)count_Telephones.Value * 300);

            General.deposit = (int)(General.totalCost * 0.2);
            lbl_Deposit.Text = "Deposit: £" + General.deposit.ToString();

            int newCost = General.totalCost - General.deposit;

            if(count_years.Value == 0 && count_months.Value == 0)
            {
                lbl_MonthlyCost.Text = "Monthly cost: ";
            }
            else
            {
                monthlyCost = newCost / totalMonths; 
                lbl_MonthlyCost.Text = "Monthly cost: £" + monthlyCost.ToString() + ".00";
            }
        }

        private void PopulateCombobox(string[] list)
        {
            cb_Office.Items.Clear();
            for (int i = 0; list.Count() > i; i++)
            {
                cb_Office.Items.Add(list[i]);
            }
        }

        public UC_Office()
        {
            InitializeComponent();
            dt_Office.MinDate = DateTime.Today.AddDays(8);

            count_months.ReadOnly = true; //Stops user typing in their own value 
            count_years.ReadOnly = true;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (count_years.Value == 0 && count_months.Value == 0)
            {
                General.Message = "Please select a length of time to book";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else if (cb_PayType.Text == "")
            {
                General.Message = "Please select the payment type";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else if(cb_PayType.Text == "Card" && cb_chooseCard.Text == "")
            {
                General.Message = "Please select the card being used";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
           else if(check_Paid.Checked == false)
            {
                General.Message = "Please confirm the deposit is paid";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else if(cb_Office.Text == "")
            {
                General.Message = "Please select the office being booked";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else if(cb_PayType.Text == "Card")
            {
                General.query = "SELECT Cards.ExpiryDate FROM Cards WHERE Cards.CardId = @CardId";
                using (General.connection = new SqlConnection(General.connectionString))
                using (SqlCommand Command = new SqlCommand(General.query, General.connection))
                {
                    General.connection.Open();
                    Command.Parameters.AddWithValue("@CardId", cb_chooseCard.SelectedValue);
                    SqlDataReader rdr = Command.ExecuteReader();

                    while (rdr.Read())
                    {
                        checkExpiryDate = DateTime.Parse(rdr["ExpiryDate"].ToString());
                    }

                    if (DateTime.Today > checkExpiryDate)
                    {
                        General.Message = "This card selected is expired";
                        General.isDialogue = false;
                        createMessageBox?.Invoke(this, EventArgs.Empty);
                        return;
                    }
                }
            }
            try
            {
                StartDate = DateTime.ParseExact(dt_Office.Value.ToShortDateString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                EndDate = StartDate.AddYears((int)count_years.Value).AddMonths((int)count_months.Value);

                char temp = cb_Office.Text[7];
                OfficeId = (int)char.GetNumericValue(temp);

                General.Message = "Are you sure this is correct?";
                General.isDialogue = true;
                createMessageBox?.Invoke(this, EventArgs.Empty);

                if (General.DialogueResponse == "Yes")
                {
                    General.query = "SELECT COUNT(*) FROM Booking WHERE (@StartDate <= EndDate) AND (StartDate <= @EndDate) AND RoomId = @OfficeId";

                    using (General.connection = new SqlConnection(General.connectionString))
                    using (SqlCommand Command = new SqlCommand(General.query, General.connection))
                    {
                        General.connection.Open();

                        Command.Parameters.AddWithValue("@StartDate", StartDate);
                        Command.Parameters.AddWithValue("@EndDate", EndDate);
                        Command.Parameters.AddWithValue("@OfficeId", OfficeId);

                        Int32 count = Convert.ToInt32(Command.ExecuteScalar());

                        if (count > 0)
                        {
                            General.Message = "There are booked days in this time slot";
                            General.isDialogue = false;
                            createMessageBox?.Invoke(this, EventArgs.Empty);
                        }
                        else
                        {
                            General.roomType = "Office";
                            try
                            {
                                General.query = "INSERT INTO Booking(StartDate, EndDate, RoomId) VALUES(@StartDate,@EndDate,@RoomId)";

                                object[] ValueAdd = new object[] { StartDate, EndDate, OfficeId };

                                General.GenericInsertUpdate(ValueAdd);
                            }
                            catch (Exception ex)
                            {
                                General.Message = "Failed to book office suite";
                                General.isDialogue = false;
                                createMessageBox?.Invoke(this, EventArgs.Empty);
                            }

                            try
                            {
                                General.query = "SELECT MAX(BookingId) FROM Booking";

                                using (General.connection = new SqlConnection(General.connectionString))
                                using (SqlCommand Cmd1 = new SqlCommand(General.query, General.connection))
                                {
                                    General.connection.Open();
                                    General.NewestId = Convert.ToInt32(Cmd1.ExecuteScalar());
                                }
                            }
                            catch (Exception ex) { }

                            try
                            {
                                General.query = "INSERT INTO Furnishing (Desks, Computers, Printers, Telephones, Projectors, Shredders) VALUES(@Desks, @Computers, @Printers, @Telephones, @Projectors, @Shredders)";
                                object[] ValueAdd = new object[] { count_Desks.Value, count_Computers.Value, count_Printers.Value, count_Telephones.Value, count_Projectors.Value, count_Shredders.Value };
                                General.GenericInsertUpdate(ValueAdd);
                            }
                            catch(Exception ex) { }

                            Today = DateTime.ParseExact(DateTime.Today.ToShortDateString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                            try
                            {
                                General.query = "SELECT MAX(FurnishingId) FROM Furnishing";
                                int furnishingId = General.GetNewestId();

                                General.query = "INSERT INTO BookingData(BusinessId, BookingId, StaffId, FurnishingId, RoomType, DateBooked, TotalCost) VALUES(@BusinessId,@BookingId,@StaffId,@FurnishingId,@RoomType,@DateBooked,@TotalCost)";
                                object[] ValueAdd = new object[] { General.selectedID, General.NewestId, General.StaffId, furnishingId, General.roomType, Today, General.totalCost };
                                General.GenericInsertUpdate(ValueAdd);

                                General.Message = "The office has been booked";
                                General.isDialogue = false;
                                createMessageBox?.Invoke(this, EventArgs.Empty);

                                reloadTable?.Invoke(this, EventArgs.Empty);
                            }
                            catch (Exception ex) { }

                            try
                            {
                               General.query = "SELECT MAX(DataId) FROM BookingData";
                               General.NewestDataId = General.GetNewestId();
                                    
                                string Notes = "This is a deposit";
                                if(cb_chooseCard.Visible == true)
                                {
                                    General.query = "INSERT INTO PaymentHistory(DataId, StaffId, Amount, PaymentType, CardId, DateDue, DatePaid, Notes) VALUES(@DataId,@StaffId,@Amount,@PaymentType,@CardId,@DateDue,@DatePaid,@Notes)";
                                    object[] ValueAdd = new object[] { General.NewestDataId, General.StaffId, General.deposit, cb_PayType.Text, cb_chooseCard.SelectedValue, Today, Today, Notes };
                                    General.GenericInsertUpdate(ValueAdd);
                                }
                                else if(cb_chooseCard.Visible == false)
                                {
                                    General.query = "INSERT INTO PaymentHistory(DataId, StaffId, Amount, PaymentType, DateDue, DatePaid, Notes) VALUES(@DataId,@StaffId,@Amount,@PaymentType,@DateDue,@DatePaid,@Notes)";
                                    object[] ValueAdd = new object[] { General.NewestDataId, General.StaffId, General.deposit, cb_PayType.Text, Today, Today, Notes };
                                    General.GenericInsertUpdate(ValueAdd);
                                }
                               
                            }
                            catch(Exception ex) { }

                            try
                            {   
                                General.query = "INSERT INTO PaymentHistory(DataId, Amount, DateDue) VALUES(@DataId,@Amount,@DateDue)";
                                for (int i = 0; i < totalMonths; i++)
                                {
                                    DateTime DueDate = StartDate.AddMonths(i + 1);
                                    object[] ValueAdd = new object[] { General.NewestDataId, monthlyCost, DueDate };
                                    General.GenericInsertUpdate(ValueAdd);
                                }
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
            catch(Exception ex)
            {
                General.Message = "Failed to insert booking";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
            }
        }
        private void OfficeUC_Load(object sender, EventArgs e)
        {

        }

        private void Fill_cb_chooseCard()
        {
            General.query = "SELECT Cards.CardId, Cards.BusinessId, Cards.CardHolderName + ' ' + Cards.CardNumber AS CardDetails FROM Cards INNER JOIN Business ON Cards.BusinessId = Business.BusinessId WHERE Cards.BusinessId = " + General.selectedID;
            using (General.connection = new SqlConnection(General.connectionString))
            using (SqlCommand Command = new SqlCommand(General.query, General.connection))
            {
                General.connection.Open();

                DataTable dt = new DataTable();
                dt.Load(Command.ExecuteReader());
                cb_chooseCard.DataSource = dt;
                cb_chooseCard.DisplayMember = "CardDetails";
                cb_chooseCard.ValueMember = "CardId";
            }
        }
        private void count_Desks_ValueChanged(object sender, EventArgs e)
        {
            CostCalculation();
        }

        private void count_Computers_ValueChanged(object sender, EventArgs e)
        {
            CostCalculation();
        }

        private void count_Printers_ValueChanged(object sender, EventArgs e)
        {
            CostCalculation();
        }

        private void count_Telephones_ValueChanged(object sender, EventArgs e)
        {
            CostCalculation();
        }

        private void count_Projectors_ValueChanged(object sender, EventArgs e)
        {
            CostCalculation();
        }

        private void count_Shredders_ValueChanged(object sender, EventArgs e)
        {
            CostCalculation();
        }
    }
}
