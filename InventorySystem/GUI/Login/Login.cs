using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using InventorySystem.Helper;

namespace InventorySystem.GUI.Login
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            WindowsFormsSettings.LoadApplicationSettings();
            InitializeComponent();


        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureEdit2_EditValueChanged_1(object sender, EventArgs e)
        {

        }
        private void Login_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++) { Thread.Sleep(10); }
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txtUserName.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';

            }
            else if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                Properties.Settings.Default.UserName = txtUserName.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save();
            }
            if (checkBox1.Checked == false)
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(Myhelp.Sql);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Select * From LOGIN WHERE UserName=@username and Password=@pass", con);
            //cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            //cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
            //SqlDataReader dr = cmd.ExecuteReader();
            //simpleButton1.Enabled = false;
            //simpleButton1.Text = @"ដំណើរការ...";
            //if (dr.HasRows)
            //{
            //    dr.Read();
            //    if (dr[4].ToString() == "Admin")
            //    {
            //        Myhelp.Type = "A";
            //    }
            //    else if (dr[4].ToString() == "Users")
            //    {
            //        Myhelp.Type = "U";
            //    }

                //SplashScreenManager.ShowForm(this, typeof(Waiting_1), true, true, false);
                this.Hide();
                Main.Main mm = new Main.Main();
                mm.Show();
                //MessageBox.Show("Wellcome",textBox1.Text,);
            ////}
            
            ////else
            ////{
            ////    MessageBox.Show("Incorrect");

            ////}
        }
    }
    
}
