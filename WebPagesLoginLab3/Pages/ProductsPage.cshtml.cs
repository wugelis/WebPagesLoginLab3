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
                new Product() { Name = "�i�֪G", Number = 1, Description = "�p�ح��~" },
                new Product() { Name = "������", Number = 2, Description = "�p�ح��~" },
                new Product() { Name = "�C�C�ť[", Number = 3, Description = "�p�ح��~" }
            };
        }
    }
}
