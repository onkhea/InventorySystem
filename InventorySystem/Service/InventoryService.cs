using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.GUI.inventory
{
    public class InventoryService
    {

        public void AddUser(InventoryModel inventoryModel)
        {
           
                SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO INVENTORY(Saller,Delivery,Location,Client,Price,StartDate,EndDate) VALUES(@saller,@delivery,@location,@client,@price,@date,@date1)", con);
                cmd.Parameters.AddWithValue("@saller", inventoryModel.Saller);
                cmd.Parameters.AddWithValue("@delivery", inventoryModel.Delivery);
                cmd.Parameters.AddWithValue("@location", inventoryModel.Location);
                cmd.Parameters.AddWithValue("@client", inventoryModel.Client);
                cmd.Parameters.AddWithValue("@price", inventoryModel.Price);
                cmd.Parameters.AddWithValue("@date", inventoryModel.StartDate);
                cmd.Parameters.AddWithValue("@date1", inventoryModel.EndDate);
                cmd.ExecuteNonQuery();
                con.Close();


                    

        }
        public List<InventoryModel> GetAll()
        {

            SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Saller,Delivery,Location,Client,Price,StartDate,EndDate from INVENTORY", con);
            SqlDataReader dr = cmd.ExecuteReader();
            List<InventoryModel> li = new List<InventoryModel>();
            while (dr.Read())
            {
                InventoryModel service = new InventoryModel
                {
                    Saller = dr["Saller"].ToString(),
                    Delivery = dr["Delivery"].ToString(),
                    Location = dr["Location"].ToString(),
                    Client = dr["Client"].ToString(),
                    Price = Convert.ToDouble(dr["Price"]),
                    StartDate = Convert.ToDateTime(dr["StartDate"]),
                    EndDate = Convert.ToDateTime(dr["EndDate"]),
                };
                li.Add(service);
            }
            dr.Close();
            con.Close();
            return li;
        }
        public void OutStored(string Saller,string Delivery,string Location,string Client,string Price)
        {
            try
            {
                SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into OUTSTOCK (Saller,Delivery,Location,Client,Price) select Saller, Delivery, Location, Client, Price from INVENTORY WHERE Saller=@saller", con);
                cmd.Parameters.AddWithValue("@saller", Saller);
                cmd.Parameters.AddWithValue("@delivery",Delivery);
                cmd.Parameters.AddWithValue("@location", Location);
                cmd.Parameters.AddWithValue("@client", Client);
                cmd.Parameters.AddWithValue("@price", Price);
                //cmd.Parameters.AddWithValue("@date", StartDate);
                //cmd.Parameters.AddWithValue("@date1", EndDate);
                cmd.ExecuteNonQuery();
                con.Close();
             

            }
            catch
            {
                //return 0;
            }
        }
        public void ReturnStored(string Saller, string Location, string Client, string Price,string StartDate,string EndDate)
        {
            try
            {
                SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE INVENTORY  WHERE Saller=@saller", con);
                cmd.Parameters.AddWithValue("@saller", Saller);
                //cmd.Parameters.AddWithValue("@delivery", Delivery);
                cmd.Parameters.AddWithValue("@location", Location);
                cmd.Parameters.AddWithValue("@client", Client);
                cmd.Parameters.AddWithValue("@price", Price);
                cmd.Parameters.AddWithValue("@date", StartDate);
                cmd.Parameters.AddWithValue("@date1",EndDate);
                 cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch
            {
                
            }
        }
        public List<InventoryModel> GeneratData(InventoryModel inventoryModel)
        {
            SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
            List<InventoryModel> li = new List<InventoryModel>();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM INVENTORY WHERE StartDate BETWEEN '" + Convert.ToDateTime(inventoryModel.StartDate) + "'AND '" + Convert.ToDateTime(inventoryModel.EndDate) + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                InventoryModel inventoryModel1 = new InventoryModel();
                inventoryModel1.Saller = dr["Saller"].ToString();
                inventoryModel1.Delivery = dr["Delivery"].ToString();
                inventoryModel1.Location = dr["Location"].ToString();
                inventoryModel1.Client = dr["Client"].ToString();
                inventoryModel1.Price = Convert.ToDouble(dr["Price"]);
                inventoryModel1.StartDate = Convert.ToDateTime(dr["StartDate"]);
                inventoryModel1.EndDate = Convert.ToDateTime(dr["EndDate"]);
                li.Add(inventoryModel1);
            }
            dr.Close();
            con.Close();
            return li;

        }

    }
}
      