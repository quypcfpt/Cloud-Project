using System;
using System.Collections.Generic;

namespace VBC.DatabaseManagement.Models.Entities
{
    public partial class Story
    {
        public Story()
        {
            Chapter = new HashSet<Chapter>();
            Comment = new HashSet<Comment>();
            Rating = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int? AuthorId { get; set; }
        public bool? Approved { get; set; }
        public int? CategoryId { get; set; }
        public bool? Active { get; set; }
        public string PosterId { get; set; }
        public int? TotalVisit { get; set; }
        public string SeoName { get; set; }
        public string ImageUrl { get; set; }

        public virtual Author Author { get; set; }
        public virtual StoryCategory Category { get; set; }
        public virtual AspNetUsers Poster { get; set; }
        public virtual ICollection<Chapter> Chapter { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
    }
}
