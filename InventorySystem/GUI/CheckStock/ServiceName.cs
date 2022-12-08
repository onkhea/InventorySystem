using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.GUI.CheckStock
{
    public class ServiceName
    {
      public string StockItem { get; set; }
      public string followType { get; set; }
      public string  Balance { get; set; }
      public DateTime DateCreate { get; set; } = DateTime.Now;
      public string CreateBy { get; set; }
      public DateTime EditeDate { get; set; } = DateTime.UtcNow;
      public string  EditeBy { get; set; }
    }
}
