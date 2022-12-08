using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;

namespace InventorySystem.GUI.Class
{
    public  class Myhelper
    {
        public static void LoadUserControlToPanel(Control control, PanelControl panelControl)
        {
            panelControl.Controls.Clear();
            if (!panelControl.Controls.Contains(control))
            {
                panelControl.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                control.BringToFront();
            }
            else
            {
                control.BringToFront();
            }
        }
        public static void GetData()
        {
            var helper1 = new Myhelper();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable tb = new DataTable();
            da.Fill(tb);

        }
    }
}
