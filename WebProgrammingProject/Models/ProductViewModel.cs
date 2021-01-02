using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingProject.Models
{
    [Table("Products")]
    public class ProductViewModel
    {
        [Key]
        public short ProductID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Amount in Stock")]
        public short StockAmount { get; set; }

        [Required]
        public short SupplierID { get; set; }

        [Required]
        public int UnitsOnOrder { get; set; }

        [Required]
        [Display(Name = "Price")]
        public int Price { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [ForeignKey("SupplierID")]
        public SupplierViewModel Supplier { get; set; }

    }
}
