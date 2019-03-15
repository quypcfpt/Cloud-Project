using System;
using System.Collections.Generic;
using System.Text;
using VBC.DatabaseManagement.Identity;
using VBC.DatabaseManagement.Models.Entities;

namespace VBC.DatabaseManagement.ViewModels
{
    public class StoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int? Approved { get; set; }
        public int? TotalVisit { get; set; }
        public string SeoName { get; set; }
        public string ImageUrl { get; set; }
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }
        public string PosterName { get; set; }
        public int TotalChapters { get; set; }
        public int? CategoryId { get; set; }
        public bool? Active { get; set; }
        public string PosterId { get; set; }
        public int? AuthorId { get; set; }
    }
}
