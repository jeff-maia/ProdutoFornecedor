using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBase.ViewModels
{
    public class EditarProdutoViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "R$")]
        public double Preco { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Fornecedor")]
        public int FornecedorId { get; set; }
        public SelectList FornecedorOpcao { get; set; }

    }
}
