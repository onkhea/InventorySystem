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
    public partial class CheckPayment : DevExpress.XtraEditors.XtraForm
    {
        public CheckPayment()
        {
            InitializeComponent();
            loadDataPay();
        }
        private void loadDataPay()
        {
            DataPayment.PaymentService payment = new DataPayment.PaymentService();
            var paymentget = payment.GetPayment();
            gridControl1.DataSource = paymentget;
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
                loadDataPay();
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Erroer", MessageBoxButtons.YesNo, MessageBoxIcon.Error); }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoubleClick_Update(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            foreach (var row in rows)
                if (row >= 0)
                {
                    var frmpay = new UpdatePaymentcs();
                    var Client = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Client")).ToString();
                    var DebtAll = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("DebtAll")).ToString();
                    var Location = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Location")).ToString();
                    var BuiltMoney = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("BuiltMoney")).ToString();
                    var Remaining = gridView1.GetFocusedRowCellValue(gridView1.Columns.ColumnByFieldName("Remaining")).ToString();

                    frmpay.textEdit1.Text = Client;
                    frmpay.textEdit2.Text = DebtAll;
                    frmpay.textEdit3.Text = Location;
                    frmpay.textEdit4.Text = BuiltMoney;
                    frmpay.textEdit5.Text = Remaining;
                    if (frmpay.ShowDialog() == DialogResult.OK)
                        loadDataPay();

                }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void CheckPayment_Load(object sender, EventArgs e)
        {

        }
    }
}