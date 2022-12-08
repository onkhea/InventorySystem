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

namespace InventorySystem.GUI.OutStock
{
    public partial class frmOut : DevExpress.XtraEditors.XtraForm
    {
        public frmOut()
        {
            InitializeComponent();
        }
        public void OutStock()
        {
            try
            {
                InventoryService service = new InventoryService();
                var Saller = textEdit1.Text.Trim();
                var Delivery = textEdit2.EditValue.ToString().Trim();
                var Locatoin = textEdit3.EditValue.ToString().Trim();
                var Client = textEdit4.Text.Trim();
                var Price = textEdit5.EditValue.ToString().Trim();
                var Btsave = simpleButton1.Text.Trim();
               service.OutStored(Saller, Delivery, Locatoin, Client, Price);
                DialogResult = DialogResult.OK;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OutStock();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOut_Load(object sender, EventArgs e)
        {

        }
    }
}