namespace Y14_CA
{
    partial class UC_Crystal_Payments
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Crystal_Payments));
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.SQL_Connection = new System.Data.SqlClient.SqlConnection();
            this.DA_PayHistory = new System.Data.SqlClient.SqlDataAdapter();
            this.dS_PayHistory = new Y14_CA.DS_PayHistory();
            this.CR_ReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CR_PayHistory1 = new Y14_CA.CR_PayHistory();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PayHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.SQL_Connection;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@BusinessId", System.Data.SqlDbType.Int, 4, "BusinessId")});
            // 
            // SQL_Connection
            // 
            this.SQL_Connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ControlledAss" +
    "essment.mdf;Integrated Security=True";
            this.SQL_Connection.FireInfoMessageEventOnUserErrors = false;
            // 
            // DA_PayHistory
            // 
            this.DA_PayHistory.SelectCommand = this.sqlSelectCommand1;
            this.DA_PayHistory.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "BookingData", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("PaymentType", "PaymentType"),
                        new System.Data.Common.DataColumnMapping("DatePaid", "DatePaid"),
                        new System.Data.Common.DataColumnMapping("DateDue", "DateDue"),
                        new System.Data.Common.DataColumnMapping("StartDate", "StartDate"),
                        new System.Data.Common.DataColumnMapping("EndDate", "EndDate"),
                        new System.Data.Common.DataColumnMapping("RoomId", "RoomId"),
                        new System.Data.Common.DataColumnMapping("BusinessName", "BusinessName"),
                        new System.Data.Common.DataColumnMapping("PrimaryContact", "PrimaryContact"),
                        new System.Data.Common.DataColumnMapping("SecondaryContact", "SecondaryContact"),
                        new System.Data.Common.DataColumnMapping("Email", "Email"),
                        new System.Data.Common.DataColumnMapping("RoomType", "RoomType"),
                        new System.Data.Common.DataColumnMapping("TotalCost", "TotalCost"),
                        new System.Data.Common.DataColumnMapping("Expr1", "Expr1")})});
            // 
            // dS_PayHistory
            // 
            this.dS_PayHistory.DataSetName = "DS_PayHistory";
            this.dS_PayHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CR_ReportViewer
            // 
            this.CR_ReportViewer.ActiveViewIndex = 0;
            this.CR_ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CR_ReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CR_ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CR_ReportViewer.Location = new System.Drawing.Point(0, 0);
            this.CR_ReportViewer.Name = "CR_ReportViewer";
            this.CR_ReportViewer.ReportSource = this.CR_PayHistory1;
            this.CR_ReportViewer.ShowCloseButton = false;
            this.CR_ReportViewer.ShowCopyButton = false;
            this.CR_ReportViewer.ShowExportButton = false;
            this.CR_ReportViewer.ShowGotoPageButton = false;
            this.CR_ReportViewer.ShowGroupTreeButton = false;
            this.CR_ReportViewer.ShowLogo = false;
            this.CR_ReportViewer.ShowPageNavigateButtons = false;
            this.CR_ReportViewer.ShowParameterPanelButton = false;
            this.CR_ReportViewer.ShowPrintButton = false;
            this.CR_ReportViewer.ShowRefreshButton = false;
            this.CR_ReportViewer.ShowTextSearchButton = false;
            this.CR_ReportViewer.ShowZoomButton = false;
            this.CR_ReportViewer.Size = new System.Drawing.Size(1113, 646);
            this.CR_ReportViewer.TabIndex = 0;
            this.CR_ReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CR_ReportViewer.Load += new System.EventHandler(this.CR_ReportViewer_Load);
            // 
            // UC_Crystal_Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CR_ReportViewer);
            this.Name = "UC_Crystal_Payments";
            this.Size = new System.Drawing.Size(1113, 646);
            ((System.ComponentModel.ISupportInitialize)(this.dS_PayHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CR_ReportViewer;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection SQL_Connection;
        private System.Data.SqlClient.SqlDataAdapter DA_PayHistory;
        private DS_PayHistory dS_PayHistory;
        private CR_PayHistory CR_PayHistory1;
    }
}
