using System;

namespace DemoKuber
{
    public class MenuItem
    {
        public DateTime Date { get; set; }

        public int ItemId { get; set; }

        public int ItemPrice { get; set; }

        public string Active { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public string DeliveryFree { get; set; }
    }
}
