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
    public partial class UpdatePaymentcs : DevExpress.XtraEditors.XtraForm
    {
        public UpdatePaymentcs()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var payment = new DataPayment.PaymentListname();
                var paymentservice = new DataPayment.PaymentService();
                payment.Client = textEdit1.Text.Trim();
                payment.DebtAll = Convert.ToDouble(textEdit2.EditValue);
                payment.Location = textEdit3.Text.Trim();
                payment.BuiltMoney = Convert.ToDouble(textEdit4.EditValue);
                payment.Remaining = Convert.ToDouble(textEdit5.EditValue);
                paymentservice.updatePay(payment);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex) {XtraMessageBox.Show(ex.Message, "Erroer", MessageBoxButtons.YesNo, MessageBoxIcon.Error); }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdatePaymentcs_Load(object sender, EventArgs e)
        {

        }
    }
}