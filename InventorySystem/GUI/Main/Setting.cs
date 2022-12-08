using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using InventorySystem.GUI.UserManger;
using System.Threading;

namespace InventorySystem.GUI.Main
{
    public partial class Setting : DevExpress.XtraEditors.XtraForm
    {
        public Setting()
        {
            InitializeComponent();
            LoadData();
        }
      
  
        public void LoadData()
        {
            var manger = new UserManger.ManagerUser();
            var inventoryServices = manger.GetUSER();
            gridControl2.DataSource = inventoryServices;
        }

    

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var Addusers = new Users();
            if (Addusers.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void Delete_user()
        {
            try
            {

                var manager = new UserManger.ManagerUser();
                string Id = "", username = "";
                if (gridView2.SelectedRowsCount <= 0) return;
                var selectedRows = gridView2.GetSelectedRows();
                foreach (var rowHandle in selectedRows)
                {
                    if (rowHandle < 0) continue;
                    Id = gridView2.GetRowCellValue(rowHandle, "Id").ToString();
                    username = gridView2.GetRowCellValue(rowHandle, "UserName").ToString();
                }
                var dialogResult = XtraMessageBox.Show($"Do you want to delete { username } ?", "Yes / No", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult != DialogResult.Yes) return;
                ManagerUser.DeleteUser(Id, username);
                LoadData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Delete_user();
        }
      
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var rows = gridView2.GetSelectedRows();
                foreach (var row in rows)
                    if (row >= 0)
                    {
                        var frm = new PermissionFrm.CrudPermissionFrm();
                        var Id = gridView2.GetFocusedRowCellValue(gridView2.Columns.ColumnByFieldName("Id")).ToString();
                        var UserName = gridView2.GetFocusedRowCellValue(gridView2.Columns.ColumnByFieldName("UserName")).ToString();
                        var Password = gridView2.GetFocusedRowCellValue(gridView2.Columns.ColumnByFieldName("Password")).ToString();
                        var Lock = gridView2.GetFocusedRowCellValue(gridView2.Columns.ColumnByFieldName("Lock")).ToString();
                        var Type = gridView2.GetFocusedRowCellValue(gridView2.Columns.ColumnByFieldName("Type")).ToString();
                        if (Id == "true")
                            frm.textEdit1.Text = Id;

                        else
                            frm.textEdit1.Text = Id;
                        frm.textEdit2.Text = UserName;
                        frm.textEdit3.Text = Password;
                        frm.textEdit4.Text = Lock;
                        frm.comboBoxEdit1.EditValue = Type;
                        frm.simpleButton1.Text = @"កែប្រែ";
                        if (frm.ShowDialog() == DialogResult.OK)
                            LoadData();
                    }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            //DXMouseEventArgs ea = e as DXMouseEventArgs;
            //DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            //GridHitInfo info = view.CalcHitInfo(ea.Location);
            //if (info.InRow || info.InRowCell)
            //{
            //    LoadData();
            //}
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            //if (gridView2.SelectedRowsCount > 0)
            //{
            //    PermissionFrm.CrudPermissionFrm permissionFrm = new PermissionFrm.CrudPermissionFrm();
            //    if (gridView2.SelectedRowsCount > 0)
            //    {
            //        string Id = gridView2.GetFocusedRowCellValue(gridView2.Columns.ColumnByFieldName("Id")).ToString();
            //        string UserName = gridView2.GetFocusedRowCellValue(gridView2.Columns.ColumnByFieldName("UserName")).ToString();
            //        string Password = gridView2.GetFocusedRowCellValue(gridView2.Columns.ColumnByFieldName("Password")).ToString();
            //        string Lock = gridView2.GetFocusedRowCellValue(gridView2.Columns.ColumnByFieldName("Lock")).ToString();
            //        string Type = gridView2.GetFocusedRowCellValue(gridView2.Columns.ColumnByFieldName("Type")).ToString();
            //        var permissiosFrm = new PermissionFrm.CrudPermissionFrm(int.Parse(Id), UserName, Password, int.Parse(Lock), Type);
            //        if (permissionFrm.ShowDialog() == DialogResult.OK)
            //        {
            //        }
            //        else { }
            //    }
            //}
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++) { Thread.Sleep(8); }
        }
    }
}