using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tarefas.Models;

namespace Tarefas.ViewModels
{
    public class CadastroUsuarioViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [MaxLength(100, ErrorMessage = "O nome deve ter até 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o login")]
        [MaxLength(50, ErrorMessage = "O login deve ter até 50 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe permissão")]
        [Display(Name = "Permissão")]
        public TipoUsuario Permissao { get; set; }

        [Required(ErrorMessage = "Informe seu email")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(100, ErrorMessage = "O email deve ter até 100 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe sua senha")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "A senha deve ter pelo menos 4 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Confirme sua senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]
        [MinLength(4, ErrorMessage = "A senha deve ter pelo menos 4 caracteres")]
        [Compare(nameof(Senha), ErrorMessage = "A senha e a" + "confirmação não estão iguais")]
        public string ConfirmacaoSenha { get; set; }
    }
}