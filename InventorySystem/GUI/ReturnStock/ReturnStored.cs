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

namespace InventorySystem.GUI.inventory
{
    public partial class ReturnStored : DevExpress.XtraEditors.XtraForm
    {

        public ReturnStored()
        {
           
            InitializeComponent();
        }
        private void ReturnStock()
        {

            try
            {
                var inventoryservice = new InventoryService();
                var Saller = textEdit1.Text.Trim();
                //var Delivery = textEdit2.Text;
                var Location = textEdit3.Text.Trim();
                var Client = textEdit4.Text.Trim();
                var Price = textEdit5.Text.ToString().Trim();
                var StartDate = dateEdit1.EditValue.ToString().Trim();
                var EndDate = dateEdit2.EditValue.ToString().Trim();
                var Btsave = simpleButton1.Text.Trim();
                inventoryservice.ReturnStored(Saller, Location, Client, Price,StartDate,EndDate);
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("please Input Price to int");
            }
        }
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            ReturnStock();
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}