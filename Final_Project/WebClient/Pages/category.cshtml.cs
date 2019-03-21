using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebClient.Pages
{
    public class categoryModel : PageModel
    {
        public void OnGet(string seoName, string categoryName)
        {
            this.SeoName = seoName;
            this.CategoryName = categoryName;
        }

        public string SeoName { get; set; }
        public string CategoryName { get; set; }
    }
}