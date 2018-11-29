using AdicaoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicaoAPI.Controllers
{
    public class AdicaoContext : DbContext
    {
        public AdicaoContext() : base("BancoAdicoes"){}

        public DbSet<Adicao> Adicoes { get; set; }
    }
}