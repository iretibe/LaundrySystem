using System;
using System.ComponentModel.DataAnnotations;

namespace LaundrySystem.UI.Models
{
    public class OrderDeatilModel
    {
        [Key]
        public Guid SaleId { get; set; }
        public string SaleNo { get; set; }
        public DateTime? SaleDate { get; set; }
        public decimal? SaleTotal { get; set; }
        public decimal? Balance { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public Guid? OrderStatusID { get; set; }
        public string OrderStatusName { get; set; }
        public Guid? ProductId { get; set; }
        public decimal? QtySold { get; set; }
        public decimal? SellingPrice { get; set; }
        public string ProductName { get; set; }
        //public string ProductImage { get; set; }
    }
}
