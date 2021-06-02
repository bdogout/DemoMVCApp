using RealMVCPrototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibraryMVC;
using DataLibraryMVC.BusinessLogic;



namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult TestScaf()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProductCreation()
        {
            ViewBag.Message = "Product Creation Page.";

            return View();
        }

        public ActionResult DeleteProduct(ProductModel model)
        {
            ViewBag.Message = "Product Creation Page.";

            var productToDelete = new DataLibraryMVC.Models.ProductModel();

            productToDelete.ProductSKU = model.ProductSKU;

            return View(productToDelete);
        }

        public ActionResult ViewProducts()
        {
            ViewBag.Message = "All products.";

            var data = ProductProcessor.LoadProducts();
            List<ProductModel> products = new List<ProductModel>();

            foreach (var row in data)
            {
                products.Add(new ProductModel
                {
                    ProductSKU = row.ProductSKU,
                    ProductClassification = row.ProductClassification,
                    ProductPrice = row.ProductPrice,
                    ProductInStock = row.ProductInStock,
                    ProductBrand = row.ProductBrand
                });

            }

            return View(products);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProductCreation(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated  = ProductProcessor.CreateProduct(model.ProductSKU, 
                    model.ProductClassification, 
                    model.ProductPrice, 
                    model.ProductInStock, 
                    model.ProductBrand);
                
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}