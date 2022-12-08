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

namespace InventorySystem.GUI.CheckStock.ControlStock.FrmAdd
{
    public partial class FrmAdd : DevExpress.XtraEditors.XtraForm
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void InsertData()
        {
            try
            {
                var Servicename = new ServiceName();
                var Servicestock = new ServiceStock();
                Servicename.StockItem = textEdit1.Text;
                Servicename.followType = textEdit2.Text;
                Servicename.Balance = textEdit3.Text;
                Servicename.DateCreate = Convert.ToDateTime(dateEdit1.EditValue);
                Servicename.CreateBy = textEdit4.Text;
                Servicename.EditeDate = Convert.ToDateTime(dateEdit1.EditValue);
                Servicename.EditeBy = textEdit5.Text;
                Servicestock.Insesrt(Servicename);
                DialogResult = DialogResult.OK;
            }
            catch (Exception) { XtraMessageBox.Show("សូមបំពេញថ្ងៃខែឆ្នាំ", "បញ្ចូលថ្ងៃខែឆ្នាំ", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            InsertData();
        }
        private void UpdateData()
        {
            try
            {
                var Servicename = new ServiceName();
                var Servicestock = new ServiceStock();
                Servicename.StockItem = textEdit1.Text;
                Servicename.followType = textEdit2.Text;
                Servicename.Balance = textEdit3.Text;
                Servicename.DateCreate = Convert.ToDateTime(dateEdit1.EditValue);
                Servicename.CreateBy = textEdit4.Text;
                Servicename.EditeDate = Convert.ToDateTime(dateEdit1.EditValue);
                Servicename.EditeBy = textEdit5.Text;
                Servicestock.Update(Servicename);
                DialogResult = DialogResult.OK;
            }
            catch (Exception) { XtraMessageBox.Show("សូមបំពេញថ្ងៃខែឆ្នាំំ", "បញ្ចូលថ្ងៃខែឆ្នាំ", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}