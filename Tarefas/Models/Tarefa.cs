using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tarefas.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }


        [Display(Name = "Concluído")]
        public bool Concluido { get; set; }

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}