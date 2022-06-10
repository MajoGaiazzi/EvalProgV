using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudMvc.Models;

namespace CrudMvc.Data
{
    public class CrudMvcContext : DbContext
    {
        public CrudMvcContext (DbContextOptions<CrudMvcContext> options)
            : base(options)
        {
        }

        public DbSet<CrudMvc.Models.Curriculum> Curriculum { get; set; }
    }
}
