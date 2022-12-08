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
using InventorySystem.Helper;

namespace InventorySystem.GUI.PaymentClient
{
    public partial class PaymentAll : DevExpress.XtraEditors.XtraForm
    {
        public PaymentAll()
        {
            InitializeComponent();
            LoadData();
        }
       
        public void LoadData()
        {
            InventoryService service = new InventoryService();
            var inventoryServices = service.GetAll();
            gridControl1.DataSource = inventoryServices;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            foreach (var row in rows)
                if (row >= 0)
                {
                    var frmpay = new FrmPay();
                    var Client = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Client")).ToString();
                    
                    var Location = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Location")).ToString();
                    var Price = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Price")).ToString();
                    //var BuiltMoney = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("BuiltMoney")).ToString();
                    //var Remaining = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Remaining")).ToString();
                    if (Client == "true")
                        frmpay.textEdit1.Text = Client;
                    else
                    frmpay.textEdit1.Text = Client;
                    frmpay.textEdit2.Text = Price;
                    frmpay.textEdit3.Text = Location;
                    //frmpay.textEdit4.Text = BuiltMoney;
                    //frmpay.textEdit5.Text = Remaining;
                    if (frmpay.ShowDialog() == DialogResult.OK)
                        LoadData();
                }   

        }

        private void gridControl1_DoublClick(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            foreach (var row in rows)
                if (row >= 0)
                {
                    var frmpay = new CheckPayment();
                    var Client = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Client")).ToString();
                    var Location = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Location")).ToString();
                    var DebtAll = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Price")).ToString();
                    //var BuiltMoney = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("BuiltMoney")).ToString();
                    //var Remaining = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Remaining")).ToString();
                   
                    frmpay.textEdit1.Text = Client;
                    frmpay.textEdit2.Text = DebtAll;
                    frmpay.textEdit3.Text = Location;
                    //frmpay.textEdit4.Text = BuiltMoney;
                    //frmpay.textEdit5.Text = Remaining;
                    frmpay.ShowDialog(this);
                     
                }
        }
        private void Delete_user()
        {
            try
            {

                var inventory = new InventoryService();
                string Price = "", Saller = "",Location="",Client="",StartDate="",EndDate="";
                if (gridView1.SelectedRowsCount <= 0) return;
                var selectedRows = gridView1.GetSelectedRows();
                foreach (var rowHandle in selectedRows)
                {
                    if (rowHandle < 0) continue;
                    Price = gridView1.GetRowCellValue(rowHandle, "Price").ToString();
                    Saller = gridView1.GetRowCellValue(rowHandle, "Saller").ToString();
                }
                var dialogResult = XtraMessageBox.Show($"Do you want to delete { Saller } ?", "លុបទិន្ន័យ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult != DialogResult.Yes) return;
                inventory.ReturnStored(Saller,Price,Location,Client,StartDate,EndDate);
                LoadData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (XtraMessageBox.Show("", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            Delete_user();

        }

        private void PaymentAll_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++) { Thread.Sleep(10); }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Myhelp.Export(gridView1);  
        }
    }
}