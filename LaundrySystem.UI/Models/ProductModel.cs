using System;
using System.ComponentModel.DataAnnotations;

namespace LaundrySystem.UI.Models
{
    public class ProductModel
    {
        [Key]
        public Guid ProductID { get; set; }
        public Guid? ServiceID { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public string ProductDescription { get; set; }
        public DateTime? AddedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public string ServiceName { get; set; }
        public string UserName { get; set; }
    }
}
