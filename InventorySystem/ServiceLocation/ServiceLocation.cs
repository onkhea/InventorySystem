using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.ServiceLocation
{
    public class ServiceLocation
    {
        public string Location { get; set; }
        public  List<ServiceLocation> GetLocal()
        {
            SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
            con.Open();
            
            List<ServiceLocation> li = new List<ServiceLocation>();
            var cmd = new  SqlCommand("SELECT Location FROM LOCATION", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ServiceLocation service = new ServiceLocation()
                {
                 Location = dr["Location"].ToString(),

                };
                
                li.Add(service);
            }
            
            con.Close();
            return li;
        }
    }
}
