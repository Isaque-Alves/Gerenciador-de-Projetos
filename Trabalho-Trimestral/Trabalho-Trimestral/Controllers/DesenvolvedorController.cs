using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trabalho_Trimestral.Filtros;
using Trabalho_Trimestral.Models;

namespace Trabalho_Trimestral.Controllers
{
    [LoginFilter]
    public class DesenvolvedorController : Controller
    {
        private AppContext Banco;

        public DesenvolvedorController(AppContext appContext)
        {
            Banco = appContext;
        }

        public IActionResult Index()
        {
            ViewBag.Desenvolvedores = Banco.Desenvolvedores.OrderBy(c => c.Nome);
            return View();
        }

        [LoginFilter(SomenteAdmin = true)]
        public IActionResult Novo()
        {
            return View("Form");
        }

        [LoginFilter(SomenteAdmin = true)]
        [HttpPost]
        public IActionResult Novo(Desenvolvedor desenvolvedor)
        {
            if (ModelState.IsValid)
            {
                Banco.Desenvolvedores.Add(desenvolvedor);
                Banco.SaveChanges();
            }
            else
            {
                return View("Form", desenvolvedor);
            }


            return RedirectToAction("index");
        }

        [LoginFilter(SomenteAdmin = true)]
        public IActionResult Editar(int id)
        {
            Desenvolvedor desenvolvedor = Banco.Desenvolvedores.Find(id);

            if (desenvolvedor == null)
            {
                return RedirectToAction("index");
            }

            return View("Form", desenvolvedor);
        }

        [LoginFilter(SomenteAdmin = true)]
        [HttpPost]
        public IActionResult Editar(Desenvolvedor desenvolvedor)
        {
            if (ModelState.IsValid)
            {
                Banco.Desenvolvedores.Update(desenvolvedor);
                Banco.SaveChanges();
            }
            else
            {
                return View("Form", desenvolvedor);
            }


            return RedirectToAction("index");
        }

        [LoginFilter(SomenteAdmin = true)]
        public IActionResult Excluir(int id)
        {
            Desenvolvedor desenvolvedor = Banco.Desenvolvedores.Find(id);

            if (desenvolvedor != null)
            {
                Banco.Desenvolvedores.Remove(desenvolvedor);
                Banco.SaveChanges();
            }

            return RedirectToAction("index");
        }
    }
}