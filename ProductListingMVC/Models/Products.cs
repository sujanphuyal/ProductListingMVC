using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductListingMVC.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [DataType(DataType.Text)]
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        [DataType(DataType.Text)]
        [Display(Name ="Supplier")]
        public string Supplier { get; set; }
    }
}
