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
using InventorySystem.Helper;

namespace InventorySystem.GUI.Main
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }
        public bool IsFormActivated(Control form)
        {
            var isOpened = false;
            if (MdiChildren.Length <= 0) return false;
            foreach (var item in MdiChildren)
            {
                if (form.Name != item.Name) continue;
                xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                isOpened = true;
            }
            return isOpened;
        }
        public void OpenForm(Form form)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!IsFormActivated(form))
            {
                form.WindowState = FormWindowState.Maximized;
                form.MdiParent = this;
                form.Show();
            }
            Cursor.Current = Cursors.Default;
        }



        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ineven = new inventory.Inventory();
            OpenForm(ineven);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var setting = new Setting();
            OpenForm(setting);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var print22 = new ReportPrint.ReportInvoice();
            OpenForm(print22);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Do you want close this app?", "Main", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
           
            Application.Exit();
            
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) { Thread.Sleep(10); }
            if (Myhelp.Type == "A")
            {


            }
            else if (Myhelp.Type == "U")
            {
                barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                //skinRibbonGalleryBarItem1.Enabled = true;
            }

        }


        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var relogin = new Login.Login();
            this.Hide();
            relogin.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var outstock = new inventory.OutStored();
            OpenForm(outstock);
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var returnSk = new ReturnStock.ReturnSk();
            OpenForm(returnSk);
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var location = new Location.location();
            OpenForm(location);
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var Payment = new PaymentClient.PaymentAll();
            OpenForm(Payment);
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CheckStock.XtraForm1 xtraForm1 = new CheckStock.XtraForm1();
            xtraForm1.Dock = DockStyle.Fill;
            OpenForm(xtraForm1);
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CheckStock.StockBroken stockBroken = new CheckStock.StockBroken();
            stockBroken.Dock = DockStyle.Fill;
            OpenForm(stockBroken);
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CheckStock.FollowStock followStock = new CheckStock.FollowStock();
            followStock.Dock = DockStyle.Fill;
            OpenForm(followStock);
        }
    }
}
