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

namespace InventorySystem.GUI.ReturnStock
{
    public partial class ReturnSk : DevExpress.XtraEditors.XtraForm
    {
        public ReturnSk()
        {
            InitializeComponent();
            LoadData();
        }

        private void ReturnSk_Load(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            InventoryService service = new InventoryService();
            var inventoryServices = service.GetAll();
            gridControl1.DataSource = inventoryServices;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var rows = gridView1.GetSelectedRows();
                foreach (var row in rows)
                    if (row >= 0)
                    {
                        var frm = new inventory.ReturnStored();
                        var Saller = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Saller")).ToString();
                        //var Delivery = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Delivery")).ToString();
                        var Location = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Location")).ToString();
                        var Client = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Client")).ToString();
                        var Price = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Price")).ToString();
                        var StartDate = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("StartDate")).ToString();
                        var EndDate = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("EndDate")).ToString();
                        if (Saller == "true")
                            frm.textEdit1.Text = Saller;

                        else
                            frm.textEdit1.Text = Saller;
                        // frm.textEdit2.Text = Delivery;
                        frm.textEdit3.Text = Location;
                        frm.textEdit4.Text = Client;
                        frm.textEdit5.EditValue = Price;
                        frm.dateEdit1.Text = StartDate;
                        frm.dateEdit2.Text = EndDate;
                        frm.simpleButton1.Text = @"នាំចូល";
                        if (frm.ShowDialog() == DialogResult.OK)
                            LoadData();
                    }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}