using ProjetoBase.Context;
using ProjetoBase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoBase.Domain;
using System.Data.Entity;

namespace ProjetoBase.Controllers
{
    [RoutePrefix("Produtos")]
    public class ProdutoController : Controller
    {
        ProjetoBaseDataContext _db = new ProjetoBaseDataContext();


        
        [Route("Criar")]
        public ActionResult Create()
        {
            var fornecedores = _db.Fornecedores.ToList();
            var model = new EditarProdutoViewModel
            {
                Nome = "",
                Preco = 0,
                FornecedorId = 0,
                FornecedorOpcao = new SelectList(fornecedores, "Id", "Nome")
            };

            return View(model);
        }

        [Route("Criar")]
        [HttpPost]       
        public ActionResult Create(EditarProdutoViewModel model)
        {
            var produto = new Produto();
            produto.Nome = model.Nome;
            produto.Preco = model.Preco;
            produto.FornecedorId = model.FornecedorId;
            _db.Produtos.Add(produto);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [Route("listar")]
        public ActionResult Index()
        {
            return View(_db.Produtos.ToList());
        }

        [Route("Editar")]
        public ActionResult Edit(int id)
        {
            var fornecedores = _db.Fornecedores.ToList();
            var produto = _db.Produtos.Find(id);
            var model = new EditarProdutoViewModel
            {
                Nome = produto.Nome,
                Preco = produto.Preco,
                FornecedorId = produto.FornecedorId,
                FornecedorOpcao = new SelectList(fornecedores, "Id", "Nome")
            };

            return View(model);
        }

        [Route("Editar")]
        [HttpPost]
        public ActionResult Edit(EditarProdutoViewModel model)
        {
            var produto = _db.Produtos.Find(model.Id);
            _db.Entry<Produto>(produto).State = EntityState.Modified;
            _db.SaveChanges();

            return RedirectToAction("Index");
        }


        /*[Route("Editar/{id:int}")]
        public ActionResult Edit(int id)
        {
            return View();
        } */




    }
}