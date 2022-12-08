using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.GUI.UserManger
{
    public class ManagerUser
    {
        public List<StoreName> GetUSER()
        {
            SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM  LOGIN", con);
            SqlDataReader dr = cmd.ExecuteReader();
            List<StoreName> li = new List<StoreName>();
            while (dr.Read())
            {
                StoreName user = new StoreName
                {
                    UserName = dr["UserName"].ToString(),
                    Password = dr["Password"].ToString(),
                  //  Lock = Convert.ToInt32(dr["Lock"]),
                    Type = dr["Type"].ToString(),

                };
                li.Add(user);
            }
            dr.Close();
            con.Close();
            return li;
        }
        public static void ShowUser()
        {
            StoreName storeName = new StoreName();
            SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOGIN");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
        }
        public  void  Adduser(StoreName storName)
        {
            try
            {
                SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO  LOGIN (UserName,Password,Type) VALUES(@username,@pass,@type)", con);
                cmd.Parameters.AddWithValue("@username", storName.UserName);
                cmd.Parameters.AddWithValue("@pass", storName.Password);
                //cmd.Parameters.AddWithValue("@lock", storName.Lock);
                cmd.Parameters.AddWithValue("@type", storName.Type);
                var row = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
              
            }
                
              
            
        }
         public static void DeleteUser(string Id,string username)
        {
            
                SqlConnection con = new SqlConnection(Helper.Myhelp.Sql);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE  LOGIN WHERE UserName=@username", con);
                cmd.Parameters.AddWithValue("@username", username);
                // cmd.Parameters.AddWithValue("@pass", storeName.Password);
                cmd.ExecuteNonQuery();
                con.Close();

        }
        public static void RoleUser(string Type, string UserName,string Id , string Password,string Lock)
        {
            
                var con = new SqlConnection(Helper.Myhelp.Sql);
                con.Open();
                var storname = new StoreName();
                SqlCommand cmd = new SqlCommand("UPDATE   LOGIN SET Type=@type,Password=@pass WHERE UserName=@username", con);
                cmd.Parameters.AddWithValue("@username", UserName);
                cmd.Parameters.AddWithValue("@pass", Password);
                cmd.Parameters.AddWithValue("@type", Type);
                cmd.ExecuteNonQuery();
                con.Close();
        }
    }
}