using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebProgrammingProject.Models
{
    [Table("Suppliers")]
    public class SupplierViewModel
    {
        [Key]
        public short SupplierID { get; set; }

        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        public string ContactTitle { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }

        public string Region { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}