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
using InventorySystem.GUI.Class;
using InventorySystem.Helper;

namespace InventorySystem.GUI.inventory
{
    public partial class Inventory :XtraForm
    { 

        public Inventory()
        {
         
            InitializeComponent();
            LoadData();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabFormContentContainer1_Click(object sender, EventArgs e)
        {
            Myhelper.GetData();
        }
       
      

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newform = new FormAdd(this);
            if (newform.ShowDialog() == DialogResult.OK)
            {
                newform.Show();
                LoadData();
                
            }
           
        }
        public void LoadData()
        {
            InventoryService service = new InventoryService();
            var inventoryServices = service.GetAll();
            gridControl2.DataSource = inventoryServices;
        }
        private void gridControl2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {

            //var invenservice = new InventoryService();
            //var inventorymodel = new InventoryModel();
            //inventorymodel.StartDate = Convert.ToDateTime(dateEdit1.EditValue);
            //inventorymodel.EndDate = Convert.ToDateTime(dateEdit2.EditValue);
            //List<InventoryModel> li = invenservice.GeneratData(inventorymodel);
            //gridControl2.DataSource = li;


        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            if (Myhelp.Type == "U")
            {
                barButtonItem4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
    
}