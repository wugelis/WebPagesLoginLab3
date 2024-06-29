using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebPagesLoginLab3.Models;

namespace WebPagesLoginLab3.Pages
{
    public class ProductPageModel : PageModel
    {
        public Product Product { get; set; }
        public void OnGet()
        {
            //Product = new Product
            //{
            //    Number = 1,
            //    Name = "測試產品",
            //    Description = "這是一個測試用的產品"
            //};
        }
    }
}
