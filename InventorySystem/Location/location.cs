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

namespace InventorySystem.Location
{
    public partial class location : DevExpress.XtraEditors.XtraForm
    {
        public location()
        {
            InitializeComponent();
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void navabrItem1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           // gridControl1.DataSource =;
        }

        private void navBarControl2_Click(object sender, EventArgs e)
        {

        }
        private void LoadDatag2()
        {
            Service.SharedData sharedData = new Service.SharedData();
            sharedData.GetOutData();
            gridControl2.DataSource = sharedData.GetOutData();

        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem3_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ServiceLocation.ServiceLocation serviceLocation = new ServiceLocation.ServiceLocation();
            List<ServiceLocation.ServiceLocation> services = serviceLocation.GetLocal();
            gridControl1.DataSource = services;
            
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var rows = gridView1.GetSelectedRows();
                foreach (var row in rows)
                    if (row >= 0)
                    {
                       
                        var Location = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Location")).ToString();
                        //var Delivery = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Delivery")).ToString();
                        //var Location = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Location")).ToString();
                        //var Client = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Client")).ToString();
                        //var Price = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Price")).ToString();
                        //var StartDate = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("StartDate")).ToString();
                        //var EndDate = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("EndDate")).ToString();
                        LoadDatag2();
                       
                        //if (Saller == "true")
                        //    frm.textEdit1.Text = Saller;

                        //else
                        //    frm.textEdit1.Text = Saller;
                        //frm.textEdit2.Text = Delivery;
                        //frm.textEdit3.Text = Location;
                        //frm.textEdit4.Text = Client;
                        //frm.textEdit5.EditValue = Price;
                        //frm.simpleButton1.Text = @"នាំចេញ";
                        //if (frm.ShowDialog() == DialogResult.OK)
                        //    LoadData();
                    }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}