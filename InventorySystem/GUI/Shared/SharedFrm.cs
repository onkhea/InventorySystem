using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using InventorySystem.GUI.inventory;
using InventorySystem.GUI.Main;

namespace InventorySystem.GUI.Shared
{
    public partial class SharedFrm : DevExpress.XtraEditors.XtraForm
    {
        public SharedFrm()
        {
            InitializeComponent();
            LoadDatag1();
            LoadDatag2();
        }
        private void LoadDatag1()
        {
            InventoryService inventoryService = new InventoryService();
            inventoryService.GetAll();
            gridControl1.DataSource = inventoryService.GetAll();
        }
        private void LoadDatag2()
        {
            Service.SharedData sharedData = new Service.SharedData();
            sharedData.GetOutData();
            gridControl2.DataSource = sharedData.GetOutData();
        }
        private void SharedFrm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) { Thread.Sleep(10); }
            LoadDatag1();
            LoadDatag2();

          
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) { Thread.Sleep(10); }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var shareddb = new Service.SharedData();
            shareddb.SharedDb();
            LoadDatag2();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void inventoryModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}