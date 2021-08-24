using ProjetoBase.Domain;
using ProjetoBase.Maping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoBase.Context
{
    public class ProjetoBaseDataContext :DbContext
    {
        public ProjetoBaseDataContext()
            :base("ProjetoBaseConnectionString")
        {

        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoMaping());
            modelBuilder.Configurations.Add(new FornecedorMaping());

        }

    }
}