using ProjetoBase.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoBase.Domain;
using ProjetoBase.Context;
using System.Data.Entity;

namespace ProjetoBase.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {

        private ProjetoBaseDataContext _db = new ProjetoBaseDataContext();

        public bool Create(Fornecedor fornecedor)
        {
            try
            {
                _db.Fornecedores.Add(fornecedor);
                _db.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
            

           
        }

        public void Delete(int id)
        {
            var fornecedor = _db.Fornecedores.Find(id);
            _db.Fornecedores.Remove(fornecedor);
            _db.SaveChanges();

        }

        

        public List<Fornecedor> Get()
        {
            return _db.Fornecedores.ToList();
        }

        public Fornecedor Get(int id)
        {
            return _db.Fornecedores.Find(id);
        }

        public List<Fornecedor> GetByname(string name)
        {
            return _db.Fornecedores.Where(x => x.Nome.Contains(name)).ToList();
        }

        public bool Update(Fornecedor fornecedor)
        {
            try
            {
                _db.Entry<Fornecedor>(fornecedor).State = EntityState.Modified;
                _db.Fornecedores.Add(fornecedor);
                _db.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }


        public void Dispose()
        {
            _db.Dispose();
        }
    }
}