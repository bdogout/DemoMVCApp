using Dapper;
using DataLibraryMVC.DataAccess;
using DataLibraryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibraryMVC.BusinessLogic
{
    public static class ProductProcessor
    {
        public static int CreateProduct(string productSKU, string productClassification, 
            decimal productPrice, int productInStock, string productBrand) 
        {
            ProductModel data = new ProductModel()
            {
                ProductSKU = productSKU,
                ProductClassification = productClassification,
                ProductPrice = productPrice,
                ProductInStock = productInStock,
                ProductBrand = productBrand
            };

            string sql = @" insert into dbo.ProductTable (ProductSKU, ProductClassification, ProductPrice, ProductInStock, ProductBrand)
                            values (@ProductSKU, @ProductClassification, @ProductPrice, @ProductInStock, @ProductBrand);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static int DeleteProduct(string productSKU)
        {
            var p = new DynamicParameters();
            p.Add("@ProductSKU", productSKU); 
            

            string sql = @"delete from dbo.ProductTable
                            where ProductSKU = @ProductSKU;";

            return SqlDataAccess.DeleteData(sql, p);
        }

        public static List<ProductModel> LoadProducts() 
        {
            string sql = @"select Id, ProductSKU, ProductClassification, ProductPrice, ProductInStock, ProductBrand
                        from dbo.ProductTable;";

            return SqlDataAccess.LoadData<ProductModel>(sql);
        }

    }
}
