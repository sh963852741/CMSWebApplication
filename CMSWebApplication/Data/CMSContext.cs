using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CMSWebApplication.Models;

namespace CMSWebApplication.Data
{
    public class CMSContext : DbContext
    {
        public CMSContext (DbContextOptions<CMSContext> options)
            : base(options)
        {
        }

        public DbSet<CMSWebApplication.Models.Notice>? Notice { get; set; }
    }
}
