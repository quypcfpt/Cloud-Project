using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebClient.Pages
{
    public class chapterListModel : PageModel
    {
        public void OnGet(string seoName ,String storyName, String storyDes)
        {
            this.SeoName = seoName;
            this.StoryName = storyName;
            this.StoryDes = storyDes;
        }
        public String StoryName { get; set; }
        public String StoryDes { get; set; }
        public string SeoName { get; set; }
    }
}