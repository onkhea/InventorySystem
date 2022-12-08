using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;
using InventorySystem.GUI.inventory;

namespace InventorySystem.GUI.ReportPrint
{
    public partial class Payment : DevExpress.XtraReports.UI.XtraReport
    {
      

        public Payment()
        {
            InitializeComponent();
        }

     

        public Payment(List<InventoryModel> inventoryModel1)
        {
            InitializeComponent();
            objectDataSource1.DataSource = inventoryModel1;
        }


    }
}
