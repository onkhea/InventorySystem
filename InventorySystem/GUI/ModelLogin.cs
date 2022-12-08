using InventorySystem.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LandIdCreater.App.Helper
{
    public class ModelLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int  ID { get; set; }
        public int  Lock { get; set; }
        public string Type { get; set; }
    }
}
