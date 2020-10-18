﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Tarefas.ViewModels
{
    
    public class AlterarSenhaViewModel
    {
        [Required(ErrorMessage = "Informe sua senha atual")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha atual")]
        [MinLength(4, ErrorMessage = "A senha deve ter pelo menos 4" + " caracteres")]
        public string SenhaAtual { get; set; }

        [Required(ErrorMessage = "Informe sua nova senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Nova senha")]
        [MinLength(4, ErrorMessage = "A nova senha deve ter pelo menos 4" + " caracteres")]
        public string NovaSenha { get; set; }

        [Required(ErrorMessage = "Confirme sua nova senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]
        [MinLength(4, ErrorMessage = "A senha deve ter pelo menos 4" + " caracteres")]
        [Compare(nameof(NovaSenha), ErrorMessage = "A senha e a confirmação" + " não estão iguais")]
        public string ConfirmacaoSenha { get; set; }
    }
}