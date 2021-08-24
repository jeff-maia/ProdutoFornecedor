using ProjetoBase.Domain;
using ProjetoBase.Repositories;
using ProjetoBase.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBase.Controllers
{
    [RoutePrefix("Fornecedores")]
    public class FornecedorController : Controller
    {
        private IFornecedorRepository repository;

        public FornecedorController()
        {
            repository = new FornecedorRepository();
        }

        [Route("listar")]
        public ActionResult Index()
        {
            var fornecedores = repository.Get();
            return View(fornecedores);
        }

        [Route("Criar")]
        public ActionResult Create()
        {
            return View();
        }

        [Route("Criar")]
        [HttpPost]
        public ActionResult Create(Fornecedor fornecedor)
        {
            if (repository.Create(fornecedor))
                return RedirectToAction("Index");

            return View(fornecedor);
        }

        [Route("Editar/{id:int}")]
        public ActionResult Edit(int id)
        {
            var fornecedor = repository.Get(id);
            return View(fornecedor);
        }


        [Route("Editar/{id:int}")]
        [HttpPost]
        public ActionResult Edit(Fornecedor fornecedor)
        {
            if(repository.Update(fornecedor))
                return RedirectToAction("Index");

            return View(fornecedor);
        }

        [Route("Excluir/{id:int}")]
        public ActionResult Delete(int id)
        {
            var fornecedor = repository.Get(id);
            return View(fornecedor);
        }

        [Route("Excluir/{id:int}")]
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            repository.Delete(id);
            return RedirectToAction("Index");
        }


    }
}