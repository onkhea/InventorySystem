using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using InventorySystem.GUI.inventory;

namespace InventorySystem.GUI.ReportPrint
{
    public partial class SelectDate : DevExpress.XtraEditors.XtraForm
    {
        
        public SelectDate()
        {
           
            InitializeComponent();
        }
       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var reportsv = new Service.ReportService();
            //reportsv.Saller = textEdit1.Text;
            reportsv.StartDate = Convert.ToDateTime(dateEdit1.EditValue);
            reportsv.EndDate = Convert.ToDateTime(dateEdit2.EditValue);
            reportsv.ReportSv();
            DialogResult = DialogResult.OK;
        }

      

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void SelectDate_Load(object sender, EventArgs e)
        {
            

        }

       
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}