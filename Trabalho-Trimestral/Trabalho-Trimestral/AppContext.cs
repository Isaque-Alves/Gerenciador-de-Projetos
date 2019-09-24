using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_Trimestral.Models;

namespace Trabalho_Trimestral
{
    public class AppContext : DbContext
    {
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Desenvolvedor> Desenvolvedores { get; set; }
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Atribuicao> Atribuicoes { get; set; }
        public DbSet<Requisito> Requisitos { get; set; }

        public AppContext(DbContextOptions o) : base(o)
        {

        }
    }
}
