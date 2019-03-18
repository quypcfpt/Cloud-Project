using System;
using System.Collections.Generic;
using System.Text;

namespace VBC.DatabaseManagement.ViewModels
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool? Acitve { get; set; }
    }
}
