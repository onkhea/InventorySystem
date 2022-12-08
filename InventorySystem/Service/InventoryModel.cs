using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils.Svg;

namespace InventorySystem.GUI.inventory
{
    public class InventoryModel
    {
        public string ID { get; set; }
        public string Saller { get; set; }
        public string Delivery { get; set; }
        public string Location { get; set; }
        public string Client { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        

        //public SvgImage SvgImage => returninven ? Properties.Resources.ReturnInvoice :
        //    Properties.Resources.CreditInvoice;
    }
}
