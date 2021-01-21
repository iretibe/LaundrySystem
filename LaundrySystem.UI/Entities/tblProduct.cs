﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaundrySystem.UI.Entities
{
    public partial class tblProduct
    {
        [Key]
        public Guid ProductID { get; set; }
        public Guid? ServiceID { get; set; }
        [StringLength(500)]
        public string ProductName { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public string ProductDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AddedDate { get; set; }
        public Guid? CreatedBy { get; set; }
    }
}