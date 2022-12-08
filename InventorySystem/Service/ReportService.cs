using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using InventorySystem.Helper;

namespace InventorySystem.Service
{
    public class ReportService
    {
        public string Saller { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public void ReportSv()
        {
            try
            {
                SqlConnection con = new SqlConnection(Myhelp.Sql);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from INVENTORY WHERE StartDate BETWEEN  @startdate AND @enddate ", con);
                cmd.Parameters.AddWithValue("@saller", Saller);
                cmd.Parameters.AddWithValue("@startdate", StartDate);
                cmd.Parameters.AddWithValue("@enddate", EndDate);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
            }
            catch { MessageBox.Show("សូមជ្រើសរើសថ្ងៃ"); };
           
        }
    }
}
