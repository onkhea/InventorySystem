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

namespace InventorySystem.GUI.CheckStock
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            InventoryService service = new InventoryService();
            var inventoryServices = service.GetAll();
            pivotGridControl1.DataSource = inventoryServices;
        }
        private void pivotGridControl1_Click(object sender, EventArgs e)
        {

        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            layoutControl1.Dock = DockStyle.Fill;
        }
    }
}