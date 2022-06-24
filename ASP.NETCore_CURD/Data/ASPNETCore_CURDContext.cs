using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NETCore_CURD.Models;

namespace ASP.NETCore_CURD.Data
{
    public class ASPNETCore_CURDContext : DbContext
    {
        public ASPNETCore_CURDContext (DbContextOptions<ASPNETCore_CURDContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NETCore_CURD.Models.Student>? Student { get; set; }
    }
}
