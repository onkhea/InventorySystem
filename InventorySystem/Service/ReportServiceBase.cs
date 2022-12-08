using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using InventorySystem.Helper;

namespace InventorySystem.Service
{
    public class ReportServiceBase
    {
        public void ReportSv(ReportService reportService)
        {
            try
            {
                SqlConnection con = new SqlConnection(Myhelp.Sql);
                con.Open();
                List<ReportService> list = new List<ReportService>();
                SqlCommand cmd = new SqlCommand("Select * from INVENTORY WHERE StartDate BETWEEN  @startdate AND @enddate ", con);
                //cmd.Parameters.AddWithValue("@saller", Saller);
                //cmd.Parameters.AddWithValue("@startdate",);
                //cmd.Parameters.AddWithValue("@enddate", );
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
            }
            catch { MessageBox.Show("សូមជ្រើសរើសថ្ងៃ"); };

        }
    }
}