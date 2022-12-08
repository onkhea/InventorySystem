using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorySystem.GUI.Class;

namespace InventorySystem.Service
{
    public class SharedData
    {
        public string Saller { get; set; }
        public string Delivery { get; set; }
        public string Location { get; set; }
        public string Client { get; set; }
        public double Price { get; set; }
        public  void SharedDb()
        {
            SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
            con.Open();
            SqlCommand cmd = new SqlCommand(" insert into OUTSTOCK (Saller,Delivery,Location,Client,Price) select Saller, Delivery, Location, Client, Price from INVENTORY ", con);
            //cmd.Parameters.AddWithValue("@saller",Saller);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public List<SharedData> GetOutData()
        {

            SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Saller,Delivery,Location,Client,Price from OUTSTOCK", con);
            SqlDataReader dr = cmd.ExecuteReader();
            List<SharedData> li = new List<SharedData>();
            while (dr.Read())
            {
                SharedData service = new SharedData
                {
                    Saller = dr["Saller"].ToString(),
                    Delivery = dr["Delivery"].ToString(),
                    Location = dr["Location"].ToString(),
                    Client = dr["Client"].ToString(),
                    Price = Convert.ToDouble(dr["Price"]),
                    //StartDate = Convert.ToDateTime(dr["StartDate"]),
                    //EndDate = Convert.ToDateTime(dr["EndDate"]),
                };
                li.Add(service);
            }
            dr.Close();
            con.Close();
            return li;
        }
        public static void Delete(string saller,string price)
        {
            SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
            con.Open();
            SqlCommand cmd = new SqlCommand(" Delete INVENTORY where Saller=@saller ", con);
            cmd.Parameters.AddWithValue("@saller",saller);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
