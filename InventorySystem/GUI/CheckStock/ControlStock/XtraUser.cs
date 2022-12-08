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

namespace InventorySystem.GUI.CheckStock.ControlStock
{
    public partial class XtraUser : DevExpress.XtraEditors.XtraUserControl
    {
        public XtraUser()
        {
            InitializeComponent();
            LoadData();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void LoadData()
        {
            var servicename = new ServiceStock();
            var servicename2 = servicename.GetData();
            gridControl1.DataSource = servicename2;
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void XtraUser_Load(object sender, EventArgs e)
        {

        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmAdd = new FrmAdd.FrmAdd();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void Updated()
        {
            var rows = gridView1.GetSelectedRows();

            foreach (var row in rows)
                if (row >= 0)
                {
                    var frmEdit = new FrmAdd.FrmAdd();
                    var StockItem = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("StockItem")).ToString();
                    var followType = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("followType")).ToString();
                    var Balance = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Balance")).ToString();
                    var DateCreate = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("DateCreate")).ToString();
                    var CreateBy = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("CreateBy")).ToString();
                    var EditeDate = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("EditeDate")).ToString();
                    var EditeBy = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("EditeBy")).ToString();
                    if (StockItem == "true")
                        frmEdit.textEdit1.Text = StockItem;

                    else
                        frmEdit.textEdit1.Text = StockItem;
                    frmEdit.textEdit2.Text = followType;
                    frmEdit.textEdit3.Text = Balance;
                    frmEdit.dateEdit1.EditValue = DateCreate;
                    frmEdit.textEdit4.EditValue = CreateBy;
                    frmEdit.dateEdit2.EditValue = EditeDate;
                    frmEdit.textEdit5.EditValue = EditeBy;
                   // frmEdit.simpleButton1.Text = @"កែប្រែ";
                    if (frmEdit.ShowDialog() == DialogResult.OK)
                        LoadData();
                }
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Updated();
        }
        private void Deleted()
        {
            var servcieStock = new ServiceStock();
            string followType = "", StockItem = "";
            if (gridView1.SelectedRowsCount <= 0) return;
            var selectedRows = gridView1.GetSelectedRows();
            foreach (var rowHandle in selectedRows)
            {
                if (rowHandle < 0) continue;
                followType = gridView1.GetRowCellValue(rowHandle, "followType").ToString();
                StockItem = gridView1.GetRowCellValue(rowHandle, "StockItem").ToString();
            }
            var dialogResult = XtraMessageBox.Show($"Do you want to delete { StockItem } ?", "Yes / No", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;
            servcieStock.Delete(followType, StockItem);
            LoadData();
            LoadData();
        }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Deleted();
        }
    }
}
