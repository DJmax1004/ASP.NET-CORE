using _06_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Contexts
{
    public class CorridaContext : DbContext
    {
        public DbSet<Corrida> Corridas { get; set; }
        public CorridaContext(DbContextOptions options) : base(options) { }
        
        
    }
}
