using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebClient.Pages
{
    public class SingleChapterModel : PageModel
    {
        public void OnGet(int chapterId , int storyId)
        {
            
            this.chapterId = chapterId;
            this.storyId = storyId;
        }
        public int chapterId { get; set; }
        public int storyId { get; set; }
    }
}