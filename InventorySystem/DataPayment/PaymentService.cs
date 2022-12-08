using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.DataPayment
{
   public  class PaymentService
    {
       public List<PaymentListname> GetPayment()
        {
            SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
            con.Open();
            List<PaymentListname> list = new List<PaymentListname>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PAYMENT",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                var payment = new PaymentListname()
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Client = dr["Client"].ToString(),
                    DebtAll = Convert.ToDouble(dr["DebtAll"]),
                    Location = dr["Location"].ToString(),
                    BuiltMoney = Convert.ToDouble(dr["BuiltMoney"]),
                    Remaining = Convert.ToDouble(dr["Remaining"]),
                };
                list.Add(payment);
            }
            dr.Close();
            con.Close();
            return list;
        }

        public void Addpay(PaymentListname payment)
        {
            SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into PAYMENT (Client,DebtAll,Location,BuiltMoney,Remaining) Values (@client,@DebtAll,@Location,@Built,@Remaining)", con);
            cmd.Parameters.AddWithValue("@client", payment.Client);
            cmd.Parameters.AddWithValue("@DebtAll", payment.DebtAll);
            cmd.Parameters.AddWithValue("@Location", payment.Location);
            cmd.Parameters.AddWithValue("@Built", payment.BuiltMoney);
            cmd.Parameters.AddWithValue("@Remaining", payment.Remaining);
            //cmd.Parameters.AddWithValue("@date", StartDate);
            //cmd.Parameters.AddWithValue("@date1", EndDate);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updatePay(PaymentListname payment)
        {
            SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE PAYMENT SET DebtAll=@DebtAll,Location=@Location,BuiltMoney=@Built,Remaining=@Remaining  WHERE Client=@client", con);
            cmd.Parameters.AddWithValue("@client", payment.Client);
            cmd.Parameters.AddWithValue("@DebtAll", payment.DebtAll);
            cmd.Parameters.AddWithValue("@Location", payment.Location);
            cmd.Parameters.AddWithValue("@Built", payment.BuiltMoney);
            cmd.Parameters.AddWithValue("@Remaining", payment.Remaining);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
