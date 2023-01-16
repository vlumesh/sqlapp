﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sqlapp.Models;
using sqlapp.Services;

namespace sqlapp.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        { 
            _productService= productService;
        }

        public List<Product> Products;

        public void OnGet()
        {
           // ProductService productsService = new ProductService();
            Products = _productService.GetProducts();
        }
    }
}