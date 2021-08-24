using ProjetoBase.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ProjetoBase.Maping
{
    public class FornecedorMaping : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorMaping()
        {
            ToTable("Fornecedor");

            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(30).IsRequired();

            HasMany(x => x.Produto).WithRequired(x => x.Fornecedor);

        }


    }
}