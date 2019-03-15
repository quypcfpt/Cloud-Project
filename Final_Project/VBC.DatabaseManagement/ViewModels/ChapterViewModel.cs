using System;
using System.Collections.Generic;
using System.Text;

namespace VBC.DatabaseManagement.ViewModels
{
     public class ChapterViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? TotalVisit { get; set; }
        public int? IsApproved { get; set; }
        public bool? Active { get; set; }
        public int? Position { get; set; }
        public int? StoryId { get; set; }
    }
}
