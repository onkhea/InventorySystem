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

namespace InventorySystem.GUI.PaymentClient
{
    public partial class FrmPay : DevExpress.XtraEditors.XtraForm
    {
        public FrmPay()
        {
            InitializeComponent();
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var payment = new DataPayment.PaymentListname();
                var paymentservice = new DataPayment.PaymentService();
                payment.Client = textEdit1.Text.Trim();
                payment.Location = textEdit3.Text.Trim();
                payment.DebtAll = Convert.ToDouble(textEdit2.EditValue);
                payment.BuiltMoney = Convert.ToDouble(textEdit4.EditValue);
                payment.Remaining = Convert.ToDouble(textEdit5.EditValue);
                paymentservice.Addpay(payment);
                DialogResult = DialogResult.OK;
            }catch (Exception ex) { MessageBox.Show(ex.Message, "Erroer", MessageBoxButtons.YesNo, MessageBoxIcon.Error); }
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}