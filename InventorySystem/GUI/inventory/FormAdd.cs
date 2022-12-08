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
    public partial class FormAdd : DevExpress.XtraEditors.XtraForm
    {
        private readonly Inventory formadd;

        public FormAdd(Inventory formadd)
        {
            this.formadd = formadd;
            InitializeComponent();
        }

        public FormAdd()
        {
            InitializeComponent();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var inven = new InventoryService();
                var invenMo = new InventoryModel();
                invenMo.Saller = txtSell.Text;
                invenMo.Delivery = txtDelivery.Text;
                invenMo.Location = txtLocation.Text;
                invenMo.Client = txtClient.Text;
                invenMo.Price = Convert.ToDouble(txtPrice.EditValue);
                invenMo.StartDate = Convert.ToDateTime(txtStartDate.EditValue);
                invenMo.EndDate = Convert.ToDateTime(TxtEnddate.EditValue);
                inven.AddUser(invenMo);
                DialogResult = DialogResult.OK;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtSell.ResetText();
            txtDelivery.ResetText();
            txtLocation.ResetText();
            txtClient.ResetText();
            txtPrice.ResetText();
            txtStartDate.ResetText();
            TxtEnddate.ResetText();
            txtSell.Focus();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}