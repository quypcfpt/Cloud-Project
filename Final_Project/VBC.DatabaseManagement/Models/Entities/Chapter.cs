using System;
using System.Collections.Generic;

namespace VBC.DatabaseManagement.Models.Entities
{
    public partial class Chapter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? TotalVisit { get; set; }
        public bool? IsApproved { get; set; }
        public bool? Active { get; set; }
        public int? Position { get; set; }
        public int? StoryId { get; set; }

        public virtual Story Story { get; set; }
    }
}
