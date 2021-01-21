﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaundrySystem.UI.Entities
{
    public partial class tblContact
    {
        [Key]
        public Guid ContactId { get; set; }
        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }
        [Required]
        [StringLength(100)]
        public string CustomerEmail { get; set; }
        [StringLength(100)]
        public string CustomerTelephone { get; set; }
        [Required]
        [StringLength(100)]
        public string CustomerSubject { get; set; }
        [Required]
        public string CustomerMessage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MessageDate { get; set; }
    }
}