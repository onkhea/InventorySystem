using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using InventorySystem.GUI.Main;

namespace InventorySystem.GUI.UserManger
{
    public partial class Users : DevExpress.XtraEditors.XtraForm
    {
  

        public Users()
        {
            InitializeComponent();
        }

    

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {


                var manager = new ManagerUser();
                var storName = new StoreName();
                storName.UserName = (string)textEdit1.EditValue;
                storName.Password = (string)textEdit2.EditValue;
                storName.Type = (string)comboBoxEdit1.EditValue;
                manager.Adduser(storName);
                DialogResult = DialogResult.OK;


            }
            catch
            {
                MessageBox.Show("បំពេញលេខសំងាត់");
            }
                    
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {

        }
    }
}