using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.DataPayment
{
    public  class PaymentListname
    {
        public int ID { get; set; }
        public string Client { get; set; }
        public double DebtAll { get; set; }
        public string Location { get; set; }
        public double BuiltMoney { get; set; }
        public double Remaining { get; set; }
    }
}
