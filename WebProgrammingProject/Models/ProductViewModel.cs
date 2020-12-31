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
        public string ProductName { get; set; }

        [Required]
        public short StockAmount { get; set; }

        [Required]
        public short SupplierID { get; set; }

        [Required]
        public int UnitsOnOrder { get; set; }

        [Required]
        public int Price { get; set; }

        [ForeignKey("SupplierID")]
        public SupplierViewModel Supplier { get; set; }

    }
}
