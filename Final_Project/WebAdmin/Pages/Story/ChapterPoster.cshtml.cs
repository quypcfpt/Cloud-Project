using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAdmin.Pages.Story
{
    public class ChapterPosterModel : PageModel
    {
        public void OnGet(int storyId)
        {
            this.StoryId = storyId;
        }

        public int StoryId { get; set; }
    }
}