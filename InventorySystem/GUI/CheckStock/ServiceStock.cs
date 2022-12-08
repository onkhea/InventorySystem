using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.GUI.CheckStock
{
    public  class ServiceStock
    {
        public List<ServiceName> GetData()
        {
            SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ManagerStock",con);
            List<ServiceName> list = new List<ServiceName>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                var servicenaem = new ServiceName
                {
                    StockItem = dr["StockItem"].ToString(),
                    followType = dr["followType"].ToString(),
                    Balance = dr["Balance"].ToString(),
                    DateCreate = Convert.ToDateTime(dr["DateCreate"]),    
                    CreateBy = dr["CreateBy"].ToString(),    
                    EditeDate= Convert.ToDateTime(dr["EditeDate"]),
                    EditeBy= dr["EditeBy"].ToString(),
                };
                list.Add(servicenaem);
            }
            dr.Close();
            con.Close();
            return list;
        }
        public void Insesrt(ServiceName serviceName)
        {
            SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ManagerStock ( StockItem,followType,Balance,DateCreate,CreateBy,EditeDate,EditeBy) values (@StockItem,@followType,@Balance,@DateCreate,@CreateBy,@EditeDate,@EditeBy)", con);
            cmd.Parameters.AddWithValue("@StockItem", serviceName.StockItem);
            cmd.Parameters.AddWithValue("@followType", serviceName.followType);
            cmd.Parameters.AddWithValue("@Balance", serviceName.Balance);
            cmd.Parameters.AddWithValue("@DateCreate", serviceName.DateCreate);
            cmd.Parameters.AddWithValue("@CreateBy", serviceName.CreateBy);
            cmd.Parameters.AddWithValue("@EditeDate", serviceName.EditeDate);
            cmd.Parameters.AddWithValue("@EditeBy", serviceName.EditeBy);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Update(ServiceName serviceName)
        {
            SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE ManagerStock set StockItem=@StockItem,followType=@followType,Balance=@Balance,DateCreate=@DateCreate,CreateBy=@CreateBy,EditeDate=@EditeDate,EditeBy=@EditeBy Where StockItem=@StockItem", con);
            cmd.Parameters.AddWithValue("@StockItem", serviceName.StockItem);
            cmd.Parameters.AddWithValue("@followType", serviceName.followType);
            cmd.Parameters.AddWithValue("@Balance", serviceName.Balance);
            cmd.Parameters.AddWithValue("@DateCreate", serviceName.DateCreate);
            cmd.Parameters.AddWithValue("@CreateBy", serviceName.CreateBy);
            cmd.Parameters.AddWithValue("@EditeDate", serviceName.EditeDate);
            cmd.Parameters.AddWithValue("@EditeBy", serviceName.EditeBy);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Delete(string StockItem,string followType)
        {
            SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete ManagerStock Where StockItem=@StockItem",con);
            cmd.Parameters.AddWithValue("@StockItem",StockItem);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
