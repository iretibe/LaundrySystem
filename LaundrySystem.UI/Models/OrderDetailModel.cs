using System;

namespace LaundrySystem.UI.Models
{
    public class OrderDetailModel
    {
        public Guid? SaleID { get; set; }
        public Guid? ProductId { get; set; }        
        public string ProductName { get; set; }
        public decimal? QtySold { get; set; }
        public decimal? SellingPrice { get; set; }
        public decimal? SaleDetailTotal { get; set; }
    }
}