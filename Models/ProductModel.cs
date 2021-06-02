using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealMVCPrototype.Models
{
    public class ProductModel
    {
        /// <summary>
        /// Unique identifier for a specific product.
        /// </summary>
        [Display(Name = "Product SKU")]
        [Required(ErrorMessage = "You need to enter a unique SKU for this product!")]
        public string ProductSKU { get; set; }

        /// <summary>
        /// A classification to help group product types for packaging relevant data.
        /// </summary>
        [Display(Name = "Product Classification")]
        [Required(ErrorMessage = "You need to enter a classification for this product!")]
        public string ProductClassification { get; set; }

        /// <summary>
        /// Price of one unit of a product
        /// </summary>
        [Display(Name = "Product Price")]
        [Required(ErrorMessage = "You need to enter a price for this product!")]
        public decimal ProductPrice { get; set; }

        /// <summary>
        /// Current on hand quantity if it is already known.
        /// </summary>
        [Display(Name = "Product On Hand Quantity")]
        public int ProductInStock { get; set; }

        /// <summary>
        /// Associates a brand with a product for further packaging of relevant data.
        /// </summary>
        [Display(Name = "Product Brand")]
        [Required(ErrorMessage = "You need to enter a Brand for this product!")]
        public string ProductBrand { get; set; }
    }
}