using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebPagesLoginLab3.Models;

namespace WebPagesLoginLab3.Pages
{
    public class ProductsPageModel : PageModel
    {
        public List<Product> Products { get; set; }

        public void OnGet()
        {
            Products = new List<Product>()
            {
                new Product() { Name = "可樂果", Number = 1, Description = "聯華食品" },
                new Product() { Name = "蝦味先", Number = 2, Description = "聯華食品" },
                new Product() { Name = "七七乳加", Number = 3, Description = "聯華食品" }
            };
        }
    }
}
