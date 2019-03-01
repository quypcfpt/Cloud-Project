using System;
using System.Collections.Generic;

namespace VBC.DatabaseManagement.Models.Entities
{
    public partial class Rating
    {
        public int Id { get; set; }
        public int? StoryId { get; set; }
        public string UserId { get; set; }
        public int? Point { get; set; }

        public virtual Story Story { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
