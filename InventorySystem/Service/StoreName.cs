using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.GUI.UserManger
{
    public class StoreName
    {
        public int  Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Lock { get; set; }
        public string Type { get; set; }
    }
}
