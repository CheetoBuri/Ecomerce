﻿namespace ASPCoreWebAppMVC.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int AgentID { get; set; }

        public Agent Agent { get; set; }
    }
}
