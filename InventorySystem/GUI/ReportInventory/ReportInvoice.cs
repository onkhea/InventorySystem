using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using InventorySystem.GUI.inventory;
using InventorySystem.Helper;

namespace InventorySystem.GUI.ReportPrint
{
    public partial class ReportInvoice : DevExpress.XtraEditors.XtraForm
    {
        public ReportInvoice()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            InventoryService service = new InventoryService();
            var inventoryServices = service.GetAll();
            gridControl1.DataSource = inventoryServices;
        }
        private void loadGet()
        {
            Service.ReportService Report = new Service.ReportService();
            Report.ReportSv();
            gridControl1.DataSource = Report; 

        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                var selectdate = new SelectDate();
            if (selectdate.ShowDialog() == DialogResult.OK)
            {
                loadGet();
            }    
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var payReport = new Payment();

            payReport.DataSource = gridControl1.DataSource;
            ReportPrintTool tool = new ReportPrintTool(payReport);
            tool.ShowPreviewDialog();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void ReportInvoice_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var sharedDb = new Shared.SharedFrm();
            sharedDb.ShowDialog();
        }
    }
}