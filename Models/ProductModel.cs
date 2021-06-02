using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibraryMVC.Models
{
    public class ProductModel
    {
        public string ProductSKU { get; set; }
        public string ProductClassification { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductInStock { get; set; }
        public string ProductBrand { get; set; }

    }
}
