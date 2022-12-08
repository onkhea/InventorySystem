using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using InventorySystem.GUI.Class;
using InventorySystem.GUI.Main;
using InventorySystem.GUI.UserManger;

namespace InventorySystem.GUI.PermissionFrm
{
    public partial class CrudPermissionFrm : DevExpress.XtraEditors.XtraForm
    {
      

        public CrudPermissionFrm()
        {
            InitializeComponent();
          
        }

        public CrudPermissionFrm(int Id,string UserName,string Password,int Lock,string Type)
        {
            InitializeComponent();
            textEdit1.Text = (Id).ToString();
            textEdit2.Text = (UserName).ToString();
            textEdit3.Text = (Password).ToString();
            textEdit4.Text = (Lock).ToString();
            textEdit1.Text = (Type).ToString();


        }

       
        public void Update_Role()
        {
            try
            {
                var Id = textEdit1.Text.Trim();
                var UserName = textEdit2.EditValue.ToString().Trim();
                var Password = textEdit3.EditValue.ToString().Trim();
                var Lock = textEdit4.Text.Trim();
                var Type = comboBoxEdit1.EditValue.ToString().Trim();
                var Btsave = simpleButton1.Text.Trim();
                ManagerUser.RoleUser(Type, UserName, Id, Password, Lock);
                DialogResult = DialogResult.OK;
            }
        catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void CrudPermissionFrm_Load(object sender, EventArgs e)
        {
           
        }


        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            
            Update_Role();
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}