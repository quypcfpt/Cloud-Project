using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace VBC.DatabaseManagement.Identity
{
    class VBCIdentityDBContext: IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
       public VBCIdentityDBContext()
        {

        }

        public VBCIdentityDBContext(DbContextOptions<VBCIdentityDBContext> options)
           : base(options)
        {
        }


    }
}
