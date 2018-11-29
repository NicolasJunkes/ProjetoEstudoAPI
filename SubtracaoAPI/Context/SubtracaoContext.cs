using SubtracaoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SubtracaoAPI.Context
{
    public class SubtracaoContext :DbContext
    {
        public SubtracaoContext():base("BancoSubtracao"){}

        DbSet<Subtracao> Subtracoes { get; set; }
    }
}