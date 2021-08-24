using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ProjetoBase.Domain
{
    public class Fornecedor
    {
        public Fornecedor()
        {
            this.Produto = new List<Produto>();
        }

    
        public int Id { get; set; }

       
        public string Nome { get; set; }


        public IList<Produto> Produto { get; set; }
        
    }
}