using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class HomeController:Controller
    {      
        private IProductService _productService;
        private ICategoryService _categoryService;
        public HomeController(IProductService productService, ICategoryService categoryService)
        {
            this._productService=productService;
            this._categoryService=categoryService;
        }
        public IActionResult Index()
        {
            var productViewModel = new ProductListViewModel()
            {
                Products = _productService.GetHomePageProducts()
            };
            return View(productViewModel);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult MyView(string category)
        {
            var categoryViewModel = new CategoryListViewModel()
            {
                Categories=_categoryService.GetAll()
            };
            return View(categoryViewModel);
        }
        public IActionResult Hata()
        {
            return View();
        }
    }
}