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

namespace InventorySystem.GUI.CheckStock
{
    public partial class StockBroken : DevExpress.XtraEditors.XtraForm
    {
        public StockBroken()
        {
            InitializeComponent();
        }

        private void StockBroken_Load(object sender, EventArgs e)
        {
            layoutControl1.Dock = DockStyle.Fill;
        }
    }
}