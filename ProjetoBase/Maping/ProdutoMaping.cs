using ProjetoBase.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ProjetoBase.Maping
{
    public class ProdutoMaping : EntityTypeConfiguration<Produto>
    {

        public ProdutoMaping()
        {
            ToTable("Produto");

            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(30).IsRequired();
            Property(x => x.Preco).IsRequired();
        }
    }
}