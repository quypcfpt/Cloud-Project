using System;
using System.Collections.Generic;

namespace VBC.DatabaseManagement.Models.Entities
{
    public partial class Author
    {
        public Author()
        {
            Story = new HashSet<Story>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Acitve { get; set; }

        public virtual ICollection<Story> Story { get; set; }
    }
}
