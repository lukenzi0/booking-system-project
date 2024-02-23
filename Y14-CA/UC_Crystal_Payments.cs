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
    public partial class UC_Crystal_Payments : UserControl
    {
        public UC_Crystal_Payments()
        {
            InitializeComponent();
            LoadForm();
        }

        private void CR_ReportViewer_Load(object sender, EventArgs e)
        {

        }

        private void LoadForm()
        {
            DA_PayHistory.SelectCommand.Parameters["@BusinessId"].Value = General.reportId;

            DA_PayHistory.FillSchema(dS_PayHistory, SchemaType.Source);
            DA_PayHistory.Fill(dS_PayHistory, "Booking");

            CR_PayHistory rpt = new CR_PayHistory();
            rpt.SetDataSource(dS_PayHistory.Tables["Booking"]);

            CR_ReportViewer.ReportSource = rpt;
            CR_ReportViewer.RefreshReport();
        }
    }
}
