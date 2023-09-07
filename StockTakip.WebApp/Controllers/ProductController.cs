﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StockTakip.WebAPP.Models;
using StockTakip.WebAPP.Repository;

namespace StockTakip.WebAPP.Controllers
{
    public class ProductController : Controller
    {
        private readonly BaseDbContext _baseDbContext;

        public ProductController(BaseDbContext baseDbContext)
        {
            _baseDbContext = baseDbContext;
        }
        public IActionResult Index() {
            var products = _baseDbContext.Products.ToList();
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _baseDbContext.Add(product);
            _baseDbContext.SaveChanges();
            return RedirectToAction("Index","Product");

        }
        public IActionResult Details(int id)
        {
            Product? product = _baseDbContext.Products.SingleOrDefault(x => x.Id == id);
            return View(product);
        }
        [HttpGet]
        public IActionResult Update(int id) {

            var product = _baseDbContext.Products.Find(id);

        return View(product);
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            _baseDbContext.Products.Update(product);
            

            _baseDbContext.SaveChanges();
            
            return RedirectToAction("Details", "Product");


        }
        [HttpGet]
        public IActionResult Delete(int id) {
            var product = _baseDbContext.Products.Find(id);
            _baseDbContext.Products.Remove(product);
            _baseDbContext.SaveChanges();
            return RedirectToAction("Index","Product");







        }





    }




}


