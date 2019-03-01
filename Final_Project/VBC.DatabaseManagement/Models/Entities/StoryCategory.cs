using System;
using System.Collections.Generic;

namespace VBC.DatabaseManagement.Models.Entities
{
    public partial class StoryCategory
    {
        public StoryCategory()
        {
            Story = new HashSet<Story>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SeoName { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Story> Story { get; set; }
    }
}
