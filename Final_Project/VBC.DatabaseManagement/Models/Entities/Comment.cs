using System;
using System.Collections.Generic;

namespace VBC.DatabaseManagement.Models.Entities
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Detail { get; set; }
        public int? StoryId { get; set; }
        public DateTime? CreateTime { get; set; }

        public virtual Story Story { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
