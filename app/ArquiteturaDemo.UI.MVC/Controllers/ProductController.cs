
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ArquiteturaDemo.Application;
using ArquiteturaDemo.Domain;

//using System.Web.Mvc;
using ArquiteturaDemo.Domain.Entities;

namespace ArquiteturaDemo.UI.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductApplication _productApplication;

        public ProductController(ProductApplication productApplication )
        {
            _productApplication = productApplication;                
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if( ModelState.IsValid)
            {
                _productApplication.Register(product);
                return RedirectToAction("index");
            }
            return View(product);
        }

        // GET: Product
        public ActionResult Index()
        {
            // Rever porque UI não enxerga repository
            // var products = _productApplication.
            // Será que esta esperando uma lista ? ***
            var products = _productApplication.Get().ToList();
            return View(products);
        }

    }
}