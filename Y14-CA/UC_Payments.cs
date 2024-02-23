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
    public partial class UC_Payments : UserControl
    {
        public event EventHandler updatePanel, createMessageBox;
        public string paymentId = "", staffId = "", Notes;
        public bool businessSelected = false, OverPaying;
        public int tableAmount, customerAmount, roomNumberChosen, totalAmount, duePaymentId;
        public int amountPaid = 0;
        public DateTime Today = DateTime.ParseExact(DateTime.Today.ToShortDateString(), "dd/MM/yyyy", CultureInfo.InvariantCulture), NewestDateDue, checkExpiryDate;
        public UC_Payments()
        {
            InitializeComponent();
            lst_RoomType.Width = 0;
            lst_DueDate.Width = 0;
            lst_Amount.Width = 0;
            lst_roomNumber.Width = 0;

            lbl_Payment.Visible = false;
        }

        private void UC_Payments_Load(object sender, EventArgs e)
        {
            General.query = "SELECT BusinessId, Email, BusinessName FROM Business";
            
            General.ListViewFill(lst_Payments);

            foreach(Control x in this.Controls)
            {
                if((string)x.Tag == "NewPay")
                {
                    x.Visible = false;
                }
            }
        }

        private void ReloadTable()
        {
            General.query = "SELECT PaymentHistory.PaymentId, Business.BusinessId, Business.BusinessName, BookingData.RoomType, Room.RoomId, PaymentHistory.DateDue, PaymentHistory.Amount FROM PaymentHistory INNER JOIN BookingData ON PaymentHistory.DataId = BookingData.DataId INNER JOIN Business ON BookingData.BusinessId = Business.BusinessId INNER JOIN Booking ON BookingData.BookingId = Booking.BookingId INNER JOIN Room ON Booking.RoomId = Room.RoomId WHERE Business.BusinessId = " + General.selectedID + " AND PaymentHistory.FullyPaid = 0";
            General.ListViewFill(lst_Payments);
        }

        private void lst_Payments_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (businessSelected == false)
            {
                if (lst_Payments.SelectedItems.Count > 0)
                {
                    General.selectedID = lst_Payments.SelectedItems[0].SubItems[0].Text;

                    General.query = "SELECT COUNT(*) AS numberOfDuePayments FROM PaymentHistory INNER JOIN BookingData ON PaymentHistory.DataId = BookingData.DataId INNER JOIN Business ON BookingData.BusinessId = Business.BusinessId WHERE PaymentHistory.FullyPaid = 0 AND Business.BusinessId = @BusinessId";
                    using (General.connection = new SqlConnection(General.connectionString))
                    using (SqlCommand Command = new SqlCommand(General.query, General.connection))
                    {
                        General.connection.Open();

                        Command.Parameters.AddWithValue("@BusinessId", General.selectedID);

                        int count = Convert.ToInt32(Command.ExecuteScalar());
                        if (count == 0)
                        {   
                            General.Message = "There are no due payments for " + lst_Payments.SelectedItems[0].SubItems[2].Text;
                            General.isDialogue = false;
                            createMessageBox?.Invoke(this, EventArgs.Empty);
                            return;
                        }
                    }

                    lbl_Customer.Text = lst_Payments.SelectedItems[0].SubItems[2].Text + "'s due payments";

                    lst_RoomType.Width = 100;
                    lst_DueDate.Width = 80;
                    lst_Amount.Width = 120;
                    lst_roomNumber.Width = 40;

                    foreach (Control x in this.Controls)
                    {
                        if ((string)x.Tag != "NewPay")
                        {
                            x.Left += 170;
                        }
                        else if ((string)x.Tag == "NewPay")
                        {
                            x.Visible = true;
                        }
                        lbl_cardChosen.Visible = false;
                        cb_Card.Visible = false;
                        lbl_CVC.Visible = false;
                        txt_CVC.Visible = false;

                    }

                    Fill_cb_Card();

                    ReloadTable();

                    General.query = "SELECT * FROM Staff";
                    General.ListViewFill(lst_Staff);
                    businessSelected = true;
                }
            }
            else
            {
                txt_Amount.Text = lst_Payments.SelectedItems[0].SubItems[6].Text;
                txt_DateDue.Text = lst_Payments.SelectedItems[0].SubItems[5].Text;
                txt_roomNumber.Text = lst_Payments.SelectedItems[0].SubItems[4].Text;

                paymentId = lst_Payments.SelectedItems[0].SubItems[0].Text;
            }
        }
          
        private void cb_PayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_PayType.Text == "Card")
            {
                lbl_cardChosen.Visible = true;
                cb_Card.Visible = true;
                lbl_CVC.Visible = true;
                txt_CVC.Visible = true;
            }
            else
            {
                lbl_cardChosen.Visible = false;
                cb_Card.Visible = false;
                lbl_CVC.Visible = false;
                txt_CVC.Visible = false;
            }
        }

        private void btn_NewPayment_Click(object sender, EventArgs e)
        {   
            if (paymentId == "" || txt_Amount.Text == "" || txt_roomNumber.Text == "")
            {
                General.Message = "Please double click on a due payment to select it";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else
            {
                customerAmount = Convert.ToInt32(txt_Amount.Text);
                roomNumberChosen = Convert.ToInt32(txt_roomNumber.Text);
            }
            if (lst_Staff.SelectedItems.Count <= 0)
            {
                General.Message = "Please select a staff member to make this payment";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else if(cb_PayType.Text == "")
            {
                General.Message = "Please select a payment type";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else if (ifOverPaying(roomNumberChosen, customerAmount))
            {
                General.Message = "You currently owe: £" + totalAmount.ToString() + "\nYou are overpaying by: £" + (customerAmount - totalAmount).ToString();
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return; 
            }
            else if(cb_PayType.Text == "Card" && cb_Card.Text == "")
            {
                General.Message = "Please select the card you want to pay with";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else if(txt_CVC.Text == "" && cb_Card.Visible == true)
            {
                General.Message = "Please enter a CVC code";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else if(cb_Card.Visible == true)
            {
              
                General.query = "SELECT Cards.ExpiryDate FROM Cards WHERE Cards.CardId = @CardId";
                using (General.connection = new SqlConnection(General.connectionString))
                using (SqlCommand Command = new SqlCommand(General.query, General.connection))
                {
                    General.connection.Open();
                    Command.Parameters.AddWithValue("@CardId", cb_Card.SelectedValue);
                    SqlDataReader rdr = Command.ExecuteReader();

                    while (rdr.Read())
                    {
                        checkExpiryDate = DateTime.Parse(rdr["ExpiryDate"].ToString());
                    }

                    if(DateTime.Today > checkExpiryDate)
                    {
                        General.Message = "The card selected is expired";
                        General.isDialogue = false;
                        createMessageBox?.Invoke(this, EventArgs.Empty);
                        return;
                    }
                }

                General.query = "SELECT COUNT(*) FROM Cards WHERE Cards.CardId = @CardId AND Cards.CVC = @CVC";
                using (General.connection = new SqlConnection(General.connectionString))
                using (SqlCommand Command = new SqlCommand(General.query, General.connection))
                {
                    General.connection.Open();

                    Command.Parameters.AddWithValue("@CardId", cb_Card.SelectedValue);
                    Command.Parameters.AddWithValue("@CVC", Convert.ToInt32(txt_CVC.Text));

                    int count = Convert.ToInt32(Command.ExecuteScalar());
                    if(count == 0)
                    {
                        General.Message = "The CVC entered was wrong";
                        General.isDialogue = false;
                        createMessageBox?.Invoke(this, EventArgs.Empty);
                        return;
                    }
                    else if(count == 1)
                    {
                        staffId = lst_Staff.SelectedItems[0].SubItems[0].Text;

                        payAmount();
                        ReloadTable();
                    }
                }
            }
            else
            {
                staffId = lst_Staff.SelectedItems[0].SubItems[0].Text;

                payAmount();
                ReloadTable();
            }
        }

        private void btn_CrytalPay_Click(object sender, EventArgs e)
        {   
            if(lst_Payments.SelectedItems.Count <= 0)
            {
                General.Message = "Please select a business first";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
            else
            {
                General.reportId = Convert.ToInt32(lst_Payments.SelectedItems[0].SubItems[0].Text);
                updatePanel?.Invoke(this, EventArgs.Empty);
            }
        }

        private void Fill_cb_Card()
        {
            General.query = "SELECT Cards.CardId, Cards.BusinessId, Cards.CardHolderName + ' ' + Cards.CardNumber AS CardDetails FROM Cards INNER JOIN Business ON Cards.BusinessId = Business.BusinessId WHERE Cards.BusinessId = " +  General.selectedID;
            using (General.connection = new SqlConnection(General.connectionString))
            using (SqlCommand Command = new SqlCommand(General.query, General.connection))
            {
                General.connection.Open();

                DataTable ds = new DataTable();
                ds.Load(Command.ExecuteReader());
                cb_Card.DataSource = ds;
                cb_Card.DisplayMember = "CardDetails";
                cb_Card.ValueMember = "CardId";
            }
        }
        private void payAmount()
        {
            if (cb_Card.Visible == true)
            {
                int CVC = Convert.ToInt32(txt_CVC.Text);
            }

            while (customerAmount != 0)//loops until the clients money inserted is used as far as possible in the table
            {
                //Gets the earliest date due for payment
                General.query = "SELECT MIN(DateDue) AS NewestDateDue FROM PaymentHistory INNER JOIN BookingData ON PaymentHistory.DataId = BookingData.DataId INNER JOIN Business ON BookingData.BusinessId = Business.BusinessId INNER JOIN Booking ON BookingData.BookingId = Booking.BookingId INNER JOIN Room ON Booking.RoomId = Room.RoomId WHERE PaymentHistory.FullyPaid = 0 AND Room.RoomId = @RoomId AND Business.BusinessId = @BusinessId";
                using (General.connection = new SqlConnection(General.connectionString))
                using (SqlCommand Command = new SqlCommand(General.query, General.connection))
                {
                    General.connection.Open();

                    Command.Parameters.AddWithValue("@RoomId", roomNumberChosen);
                    Command.Parameters.AddWithValue("@BusinessId", General.selectedID);

                    SqlDataReader rdr = Command.ExecuteReader();
                    while (rdr.Read())
                    {
                        NewestDateDue = Convert.ToDateTime(rdr["NewestDateDue"]);
                    }
                }

                //Gets the amount and Id for the earliest payment due
                General.query = "SELECT PaymentHistory.Amount, PaymentHistory.PaymentId FROM PaymentHistory INNER JOIN BookingData ON PaymentHistory.DataId = BookingData.DataId INNER JOIN Business ON BookingData.BusinessId = Business.BusinessId INNER JOIN Booking ON BookingData.BookingId = Booking.BookingId INNER JOIN Room ON Booking.RoomId = Room.RoomId WHERE PaymentHistory.FullyPaid = 0 AND Room.RoomId = @RoomId AND Business.BusinessId = @BusinessId AND PaymentHistory.DateDue = @NewestDateDue";
                using (General.connection = new SqlConnection(General.connectionString))
                using (SqlCommand Command = new SqlCommand(General.query, General.connection))
                {
                    General.connection.Open();
                    Command.Parameters.AddWithValue("@RoomId", roomNumberChosen);
                    Command.Parameters.AddWithValue("@BusinessId", General.selectedID);
                    Command.Parameters.AddWithValue("@NewestDateDue", NewestDateDue);

                    SqlDataReader rdr = Command.ExecuteReader();
                    while (rdr.Read())
                    {
                        tableAmount = Convert.ToInt32(rdr["Amount"]);
                        duePaymentId = Convert.ToInt32(rdr["PaymentId"]);
                    }
                }

                //Checks if there are payments made for the due payment
                General.query = "SELECT COUNT(*) FROM PaymentsMade INNER JOIN PaymentHistory ON PaymentHistory.PaymentId = PaymentsMade.PaymentId WHERE PaymentHistory.PaymentId = " + duePaymentId.ToString();
                using (General.connection = new SqlConnection(General.connectionString))
                using (SqlCommand Command = new SqlCommand(General.query, General.connection))
                {
                    General.connection.Open();

                    int count = Convert.ToInt32(Command.ExecuteScalar());

                    if(count > 0)
                    {
                        //Gets the amount the client has paid for this due payment
                        General.query = "SELECT SUM(Amount) FROM PaymentsMade AS amountPaid INNER JOIN PaymentHistory ON PaymentHistory.PaymentId = PaymentsMade.PaymentId WHERE PaymentHistory.PaymentId = " + duePaymentId.ToString();
                        using (General.connection = new SqlConnection(General.connectionString))
                        using (SqlCommand Cmd = new SqlCommand(General.query, General.connection))
                        {
                            General.connection.Open();
                            amountPaid = Convert.ToInt32(Command.ExecuteScalar());
                        }
                    }
                }

               int leftAmount = tableAmount - amountPaid; //Takes the remaining payment needed

               if(customerAmount >= leftAmount)
                {
                    customerAmount -= leftAmount;

                    General.query = "UPDATE TOP (1) PaymentHistory SET PaymentHistory.FullyPaid = 1 FROM PaymentHistory INNER JOIN BookingData ON PaymentHistory.DataId = BookingData.DataId INNER JOIN Business ON BookingData.BusinessId = Business.BusinessId INNER JOIN Booking ON BookingData.BookingId = Booking.BookingId INNER JOIN Room ON Booking.RoomId = Room.RoomId WHERE PaymentHistory.FullyPaid = 0 AND Room.RoomId = @RoomId AND Business.BusinessId = @BusinessId AND PaymentHistory.DateDue = @NewestDateDue";
                    using (General.connection = new SqlConnection(General.connectionString))
                    using (SqlCommand Command = new SqlCommand(General.query, General.connection))
                    {
                        General.connection.Open();

                        Command.Parameters.AddWithValue("@RoomId", roomNumberChosen);
                        Command.Parameters.AddWithValue("@BusinessId", General.selectedID);
                        Command.Parameters.AddWithValue("@NewestDateDue", NewestDateDue);

                        Command.ExecuteNonQuery();
                    }

                    InsertPaid(leftAmount);
                }
               else if(customerAmount < leftAmount)
                {
                    InsertPaid(customerAmount);
                    customerAmount = 0;
                }
            }
        }

        private void InsertPaid(int PayAmount)
        {   
            if(cb_Card.Visible == true)
            {
                General.query = "INSERT INTO PaymentsMade (PaymentId,PaymentType,CardId,DatePaid,Amount,StaffId) VALUES(@DuePayId,@PaymentType,@CardId,@DatePaid,@Amount,@StaffId)";
                object[] ValueAdd = new object[] { duePaymentId, cb_PayType.Text, cb_Card.SelectedValue, Today, PayAmount, Convert.ToInt32(staffId) };
                General.GenericInsertUpdate(ValueAdd);
            }
            else
            {
                General.query = "INSERT INTO PaymentsMade (PaymentId,PaymentType,DatePaid,Amount,StaffId) VALUES(@DuePayId,@PaymentType,@DatePaid,@Amount,@StaffId)";
                object[] ValueAdd = new object[] { duePaymentId, cb_PayType.Text, Today, PayAmount, Convert.ToInt32(staffId) };
                General.GenericInsertUpdate(ValueAdd);
            }

        }
        private bool ifOverPaying(int iroomNumberChosen, int icustomerAmount)
        {          
            General.query = "SELECT SUM(PaymentHistory.Amount) AS TotalPaymentSum FROM PaymentHistory INNER JOIN BookingData ON PaymentHistory.DataId = BookingData.DataId INNER JOIN Business ON BookingData.BusinessId = Business.BusinessId INNER JOIN Booking ON BookingData.BookingId = Booking.BookingId INNER JOIN Room ON Booking.RoomId = Room.RoomId WHERE PaymentHistory.FullyPaid = 0 AND Room.RoomId = @RoomId AND Business.BusinessId = @BusinessId";
            using (General.connection = new SqlConnection(General.connectionString))
            using (SqlCommand Command = new SqlCommand(General.query, General.connection))
            {
                General.connection.Open();
                Command.Parameters.AddWithValue("@RoomId", iroomNumberChosen);
                Command.Parameters.AddWithValue("@BusinessId", General.selectedID);

                SqlDataReader rdr = Command.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        totalAmount = Convert.ToInt32(rdr["TotalPaymentSum"]);

                        if (icustomerAmount > totalAmount)
                        {
                            OverPaying = true;
                        }
                        else if (icustomerAmount <= totalAmount)
                        {
                            OverPaying = false;
                        }
                    }
                }
                return OverPaying;
            }
        }
    }
}
