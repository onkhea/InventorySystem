using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.GUI.CheckStock.ControlStock;

namespace InventorySystem.GUI.CheckStock
{
    public partial class FollowStock : DevExpress.XtraEditors.XtraForm
    {
        public FollowStock()
        {
            InitializeComponent();
            ShowForm();
        }

        private void xtraTabPage3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ShowForm()
        {

            var warehouseControl = new XtraUser();
            warehouseControl.Dock = DockStyle.Fill;
            xtraTabPage1.Controls.Add(warehouseControl);

            var warehouseControl1 = new XtraUserControl1();
            warehouseControl1.Dock = DockStyle.Fill;
            xtraTabPage2.Controls.Add(warehouseControl1);

            var warehouseControl2 = new XtraUserControl2();
            warehouseControl2.Dock = DockStyle.Fill;
            xtraTabPage3.Controls.Add(warehouseControl2);

            var warehouseControl3 = new XtraUserControl3();
            warehouseControl3.Dock = DockStyle.Fill;
            xtraTabPage4.Controls.Add(warehouseControl3);

            var warehouseControl4 = new XtraUserControl4();
            warehouseControl4.Dock = DockStyle.Fill;
            xtraTabPage5.Controls.Add(warehouseControl4);
        }
        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}