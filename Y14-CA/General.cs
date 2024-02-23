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
    class General
    {
        public static string query, roomType, Message;

        public static SqlConnection connection;
        public static string connectionString = ConfigurationManager.ConnectionStrings["Y14_CA.Properties.Settings.ControlledAssessmentConnectionString"].ConnectionString;

        public static bool CustomerAdd, CustomerUpdate;
        public static string selectedID, StaffId = "0", SelectedLeaseId, DialogueResponse;
        public static bool foundNull = false, isDialogue;

        public static Int32 NewestId, NewestDataId;

        public static List<string> Parameters = new List<string>();

        public static int currentMonth = DateTime.Now.Month, totalCost, deposit;
        public static int currentYear = DateTime.Now.Year;
        public static int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
        public static int reportId;

        public static DateTime Lease_StartDate, Lease_EndDate;


        public static void GenericInsertUpdate(object[] iValueAdd)
        {
            GetQueryFields();   
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand Command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    for (int i = 0; i < Parameters.Count(); i++)
                    {
                        Command.Parameters.AddWithValue(Parameters[i], iValueAdd[i]);
                    }
                    Command.ExecuteNonQuery();
                }
        }

        public static void GenericDelete()
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand Command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    Command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex){  }
        }

        public static void ListViewFill(ListView Listview)
        {
            try
            {
                SqlDataReader Reader;

                //Clearing Item From ListView 
                Listview.Items.Clear();

                using (General.connection = new SqlConnection(General.connectionString))
                using (SqlCommand Command = new SqlCommand(query, General.connection))  //3 - Added a new class for common/global vars 
                {
                    General.connection.Open();
                    Reader = Command.ExecuteReader();

                    //Creating Array To Hold Each Field 
                    String[] SubItems = new String[Reader.FieldCount];

                    //Checking That The DataReader Has Records To Read 
                    if (Reader.HasRows)
                    {
                        //While Reader Reads Each Record 
                        while (Reader.Read())
                        {
                            //Looping Through Each Field In The Record 
                            for (int Index = 0; Index < Reader.FieldCount; Index++)
                            {
                                SubItems[Index] = Reader[Index].ToString();
                            }
                            //Creating And Adding The ListView Item 
                            ListViewItem Item = new ListViewItem(SubItems);
                            Listview.Items.Add(Item);
                        }
                    }
                }
            }
            catch (Exception ex){
                MessageBox.Show("Failed To Load Listview\nPlease Try Reloading The Form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void GetQueryFields()
        {
            //Clears List Of Fields From Previous Queries
            Parameters.Clear();

            string Query;
            int Start = 0, Finish = 0;

            Query = query;

            if (Query.Contains("INSERT"))
            {
                //Replacing Values To Get Query In The Right Format
                Query = Query.Replace(')', ',');

                //Skips The Start Of The Query To The First @
                Query = Query.Substring(Query.IndexOf("@"));
            }
            else if (Query.Contains("UPDATE"))
            {
                Query = Query.Replace(')', ',').Replace(" WHERE", ",").Replace(" FROM", ",");

                Query = Query.Substring(Query.IndexOf('@'));
            }
            else
            {
                //Replacing Values To Get Query In The Right Format
                Query = Query.Replace(" WHERE", ",").Replace("ID ", "") + ",";

            }

            while (Query.Contains("@"))
            { 
                Start = Query.IndexOf('@'); // Starts selecttion at '@'

                Finish = Query.IndexOf(','); // Ends selection at ','

                //Getting The Substring From The Start Position Of The @ For A Length Of The Finish - Start
                Parameters.Add(Query.Substring(Start, Finish - Start));

                //Updating Query To The Remaining Part Of The String
                Query = Query.Substring(Finish + 1); //+1 To Skip Ending Comma
            }
        }

        public static int GetNewestId()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand Command = new SqlCommand(query, connection))
            {
                connection.Open();
                Int32 count = Convert.ToInt32(Command.ExecuteScalar());
                return count;
            }
        }
    }
}
