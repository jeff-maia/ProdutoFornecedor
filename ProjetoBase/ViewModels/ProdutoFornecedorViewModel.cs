using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBase.ViewModels
{
    public class ProdutoFornecedorViewModel
    {
        [Required(ErrorMessage ="*")]    
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "*")]
        public int FornecedorId { get; set; }
    }
}