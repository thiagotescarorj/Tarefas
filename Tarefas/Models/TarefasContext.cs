using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tarefas.Models
{
    public class TarefasContext : DbContext
    {
        public TarefasContext() : base("Tarefas")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

 
    }
}