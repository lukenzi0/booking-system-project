using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y14_CA
{
    public partial class MessageBox_Form : Form
    {
        public event EventHandler enablePanel, disablePanel;
        public MessageBox_Form()
        {
            InitializeComponent();
        }

        public MessageBox_Form(string Message, bool isDialogue)
        {
            InitializeComponent();

            disablePanel?.Invoke(this, EventArgs.Empty);

            lbl_Message.Text = Message;
            btn_Yes.Visible = isDialogue;
            btn_No.Visible = isDialogue;
        }

        private void lbl_X_Click(object sender, EventArgs e)
        {
            enablePanel?.Invoke(this, EventArgs.Empty);
            this.Close();        
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            General.DialogueResponse = "Yes";

            enablePanel?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            General.DialogueResponse = "No";

            enablePanel?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
