﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaundrySystem.UI.Entities
{
    public partial class tblSaleDetail
    {
        [Key]
        public Guid SaleDetailId { get; set; }
        public Guid? SaleID { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? ProductSuitTypeId { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? QtySold { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? SellingPrice { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? VAT { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? NHIL { get; set; }
        [Column(TypeName = "numeric(37, 4)")]
        public decimal? SaleDetailTotal { get; set; }
        [StringLength(100)]
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
    }
}