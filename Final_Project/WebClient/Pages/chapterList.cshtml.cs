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
        public void OnGet(int chapterId ,String storyName, String storyDes)
        {
            this.chapterId = chapterId;
            this.storyName = storyName;
            this.storyDes = storyDes;
        }
        public String storyName { get; set; }
        public String storyDes { get; set; }
        public int chapterId { get; set; }
    }
}