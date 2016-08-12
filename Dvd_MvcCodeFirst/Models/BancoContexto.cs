using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Dvd_MvcCodeFirst.Models
{
    public class BancoContexto : DbContext
    {

        public BancoContexto() : base("ConnDB")
        {

        }
        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Professor> Professsores { get; set; }

        public DbSet<Topico> Topicos { get; set; }

    }
}