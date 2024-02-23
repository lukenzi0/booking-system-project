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
    public partial class UC_Staff : UserControl
    {
        public event EventHandler createMessageBox;
        public UC_Staff()
        {
            InitializeComponent();
        }

        private void UC_Staff_Load(object sender, EventArgs e)
        {
            LoadListview();
        }

        private void LoadListview()
        {
            General.query = "SELECT StaffId, Forename, Surname, Address1, Address1, PostCode, City, PrimaryContact, SecondaryContact, Email FROM Staff";
            General.ListViewFill(lst_Staff);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (lst_Staff.SelectedItems.Count > 0)
            {
                if (lst_Staff.SelectedItems.Count > 0)
                {
                    General.Message = "Are you sure you want to delete this staff member?";
                    General.isDialogue = true;
                    createMessageBox?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    General.isDialogue = false;
                    General.Message = "Please select a staff member to delete";
                    createMessageBox?.Invoke(this, EventArgs.Empty);
                }

                if (General.DialogueResponse == "No")
                {
                    return;
                }
                else if(General.DialogueResponse == "Yes")
                {
                    General.query = "DELETE FROM Staff WHERE StaffId = " + lst_Staff.SelectedItems[0].SubItems[0].Text;
                    General.GenericDelete();
                    LoadListview();
                }
            }
            else
            {
                General.Message = "Please select a staff member to delete";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            InsertInPanel(true, false);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {   
            if(lst_Staff.SelectedItems.Count > 0)
            {
                General.selectedID = lst_Staff.SelectedItems[0].SubItems[0].Text;
                InsertInPanel(false, true);
            }
            else
            {
                General.Message = "Please select a staff member to update";
                General.isDialogue = false;
                createMessageBox?.Invoke(this, EventArgs.Empty);
                return;
            }
        }

        private void InsertInPanel(bool Add, bool Update)
        {
            UC_AddUpdate_S UC = new UC_AddUpdate_S();
            UC.clearPanel += new EventHandler(clearPanel);
            UC.refreshTable += new EventHandler(refreshTable);
            UC.createMessageBox += new EventHandler(CreateMessageBox);

            General.CustomerUpdate = Update;
            General.CustomerAdd = Add;

            btn_Add.Hide();
            btn_Update.Hide();

            pnl_AddUpdate.Controls.Clear();
            pnl_AddUpdate.Controls.Add(UC);
        }

        private void clearPanel(object o, EventArgs e)
        {
            pnl_AddUpdate.Controls.Clear();

            btn_Add.Show();
            btn_Update.Show();
        }

        private void refreshTable(object o, EventArgs e)
        {
            LoadListview();

            btn_Add.Show();
            btn_Update.Show();
        }

        private void CreateMessageBox(object o, EventArgs e)
        {
            createMessageBox?.Invoke(this, EventArgs.Empty);
        }
    }
}
