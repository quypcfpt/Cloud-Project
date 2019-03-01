using System;
using System.Collections.Generic;
using System.Text;

namespace VBC.DatabaseManagement.ViewModels
{
     public class StoryCategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SeoName { get; set; }
        public bool? Active { get; set; }
    }
}
