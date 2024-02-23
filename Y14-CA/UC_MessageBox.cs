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
    public partial class UC_MessageBox : UserControl
    {
        public event EventHandler closeMessageBox, enablePanel, disablePanel;
        public int DialogueResponse;

        public UC_MessageBox()
        {
            InitializeComponent();
        }

        public UC_MessageBox(string Message, bool isDialogue)
        {
            InitializeComponent();

            disablePanel?.Invoke(this, EventArgs.Empty);

            btn_No.Visible = isDialogue;
            btn_Yes.Visible = isDialogue;

            lbl_Message.Text = Message;
        }

        private void lbl_X_Click(object sender, EventArgs e)
        {
            closeMessageBox?.Invoke(this, EventArgs.Empty);
        }

        public void btn_Yes_Click(object sender, EventArgs e)
        {
            enablePanel?.Invoke(this, EventArgs.Empty);
            closeMessageBox?.Invoke(this, EventArgs.Empty);
        }

        public void btn_No_Click(object sender, EventArgs e)
        {
            enablePanel?.Invoke(this, EventArgs.Empty);
            closeMessageBox?.Invoke(this, EventArgs.Empty);
        }
    }
}
