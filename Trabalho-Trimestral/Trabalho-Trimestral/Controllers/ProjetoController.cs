using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_Trimestral.Filtros;
using Trabalho_Trimestral.Models;

namespace Trabalho_Trimestral.Controllers
{
    [LoginFilter]
    public class ProjetoController : Controller
    {
        private AppContext Banco;

        public ProjetoController(AppContext appContext)
        {
            Banco = appContext;
        }

        public IActionResult Index()
        {
            ViewBag.Projetos = Banco.Projetos.OrderBy(c => c.DataEntrega);
            
            return View();
        }

        [LoginFilter(SomenteAdmin = true)]
        public IActionResult Novo()
        {
            return View("Form");
        }

        [LoginFilter(SomenteAdmin = true)]
        [HttpPost]
        public IActionResult Novo(Projeto projeto)
        {
            if (ModelState.IsValid)
            {
                Banco.Projetos.Add(projeto);
                Banco.SaveChanges();
            }
            else
            {
                return View("Form", projeto);
            }


            return RedirectToAction("index");
        }

        [LoginFilter(SomenteAdmin = true)]
        public IActionResult Editar(int id)
        {
            Projeto projeto = Banco.Projetos.Find(id);

            if (projeto == null)
            {
                return RedirectToAction("index");
            }

            return View("Form", projeto);
        }

        [LoginFilter(SomenteAdmin = true)]
        [HttpPost]
        public IActionResult Editar(Projeto projeto)
        {
            if (ModelState.IsValid)
            {
                Banco.Projetos.Update(projeto);
                Banco.SaveChanges();
            }
            else
            {
                return View("Form", projeto);
            }


            return RedirectToAction("index");
        }

        [LoginFilter(SomenteAdmin = true)]
        public IActionResult Excluir(int id)
        {
            Projeto projeto = Banco.Projetos.Find(id);

            if (projeto != null)
            {
                Banco.Projetos.Remove(projeto);
                Banco.SaveChanges();
            }

            return RedirectToAction("index");
        }
    }

  
        
    
}