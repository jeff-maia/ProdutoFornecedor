using ProjetoBase.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBase.Repositories.Contracts
{
    public interface IFornecedorRepository : IDisposable
    {
        

        List<Fornecedor> Get();
        Fornecedor Get(int id);
        List<Fornecedor> GetByname(string name);
        bool Create(Fornecedor fornecedor);
        bool Update(Fornecedor fornecedor);
        void Delete(int id);



    }
}