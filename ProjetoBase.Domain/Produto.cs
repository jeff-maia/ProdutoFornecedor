using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBase.Domain
{
    public class Produto
    {
        
        public int Id { get; set; } 
        public string Nome { get; set; }        
        public double Preco { get; set; }

        public Fornecedor Fornecedor { get; set; }
        public int FornecedorId { get; set; }
    }
}