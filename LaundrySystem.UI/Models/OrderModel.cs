using System.Collections.Generic;
using System;

namespace LaundrySystem.UI.Models
{
    public class OrderModel
    {
        public decimal? SaleTotal { get; set; }
        public decimal? Discount { get; set; }
        public decimal? NetTotal { get; set; }
        public decimal? Balance { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? ServiceId { get; set; }
        public string CustomerName { get; set; }
        public string ServiceName { get; set; }

        public IEnumerable<OrderDetailModel> ListOfOrderDetails { get; set; }
    }
}