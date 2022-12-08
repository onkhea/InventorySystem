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
using InventorySystem.GUI.OutStock;
using static System.Windows.Forms.DataFormats;

namespace InventorySystem.GUI.inventory
{
    public partial class OutStored : DevExpress.XtraEditors.XtraForm
    { 
        public OutStored()
        {
            
            InitializeComponent();
            LoadData();
            LoadDatag2();
        }
        //public FormAdd(Inventory formadd)
        //{
            
        //    InitializeComponent();
        //}

 
            //try
            //{
            //    //var inven = new InventoryService();
            //    //var invenMo = new InventoryModel();
            //    //invenMo.Saller = textEdit1.Text;
            //    //invenMo.Delivery = textEdit2.Text;
            //    //invenMo.Location = textEdit3.Text;
            //    //invenMo.Client = textEdit4.Text;
            //    //invenMo.Price = Convert.ToDouble(textEdit5.EditValue);
            //    //invenMo.StartDate = Convert.ToDateTime(dateEdit1.Text);
            //    //invenMo.EndDate = Convert.ToDateTime(dateEdit2.Text);
            //    //inven.OutStored(invenMo);
            //    MessageBox.Show("successful", "OutStored?", MessageBoxButtons.YesNo);
            //}catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        


        private void OutStored_Load(object sender, EventArgs e)
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
            //try
            //{
            //    var rows = gridView1.GetSelectedRows();
            //    foreach (var row in rows)
            //        if (row >= 0)
            //        {
            //            var frm = new frmOut();
            //            var Saller = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Saller")).ToString();
            //            var Delivery = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Delivery")).ToString();
            //            var Location = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Location")).ToString();
            //            var Client = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Client")).ToString();
            //            var Price = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Price")).ToString();
            //            if (Saller == "true")
            //                frm.textEdit1.Text = Saller;

            //            else
            //                frm.textEdit1.Text = Saller;
            //            frm.textEdit2.Text = Delivery;
            //            frm.textEdit3.Text = Location;
            //            frm.textEdit4.Text = Client;
            //            frm.textEdit5.EditValue = Price;
            //            frm.simpleButton1.Text = @"នាំចេញ";
            //            if (frm.ShowDialog() == DialogResult.OK)
                           LoadData();


            //        }
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var rows = gridView1.GetSelectedRows();
                foreach (var row in rows)
                    if (row >= 0)
                    {
                        var frm = new frmOut();
                        var Saller = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Saller")).ToString();
                        var Delivery = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Delivery")).ToString();
                        var Location = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Location")).ToString();
                        var Client = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Client")).ToString();
                        var Price = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Price")).ToString();
                        if (Saller == "true")
                            frm.textEdit1.Text = Saller;

                        else
                            frm.textEdit1.Text = Saller;
                        frm.textEdit2.Text = Delivery;
                        frm.textEdit3.Text = Location;
                        frm.textEdit4.Text = Client;
                        frm.textEdit5.EditValue = Price;
                        frm.simpleButton1.Text = @"នាំចេញ";
                        if (frm.ShowDialog() == DialogResult.OK)
                            LoadData();
                        LoadDatag2();


                    }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDatag2()
        {
            Service.SharedData sharedData = new Service.SharedData();
            sharedData.GetOutData();
         // gridControl2.DataSource = sharedData.GetOutData();
          
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
    }
}