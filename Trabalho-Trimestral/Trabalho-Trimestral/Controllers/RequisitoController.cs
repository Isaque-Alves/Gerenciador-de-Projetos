using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trabalho_Trimestral.Filtros;
using Trabalho_Trimestral.Models;

namespace Trabalho_Trimestral.Controllers
{
    [LoginFilter]
    public class RequisitoController : Controller
    {
        private AppContext Banco;

        public RequisitoController(AppContext appContext)
        {
            Banco = appContext;
        }

        public IActionResult Index()
        {
            ViewBag.Requisitos = Banco.Requisitos.Include("Atribuicoes").Include("Atribuicoes.Desenvolvedor").OrderBy(c => c.DataCadastro);
            


            return View();
        }

        [LoginFilter(SomenteAdmin = true)]
        public IActionResult Novo()
        {
            ViewBag.Desenvolvedores = Banco.Desenvolvedores.OrderBy(d => d.Nome);
            return View("Form");
        }

        [LoginFilter(SomenteAdmin = true)]
        [HttpPost]
        public IActionResult Novo(Requisito requisito)
        {
            if (ModelState.IsValid)
            {
                Banco.Requisitos.Add(requisito);
                Banco.SaveChanges();

                foreach (int id in requisito.Desenvolvedores)
                {
                    Banco.Atribuicoes.Add(new Atribuicao {
                        DesenvolvedorId = id,
                        RequisitoId = requisito.Id,
                        Desenvolvedor = Banco.Desenvolvedores.Find(id),
                        Requisito = Banco.Requisitos.Find(requisito.Id)
                    });

                }
                Banco.SaveChanges();
                
            }
            else
            {
                ViewBag.Desenvolvedores = Banco.Desenvolvedores.OrderBy(d => d.Nome);
                return View("Form", requisito);
            }


            return RedirectToAction("index");
        }

        [LoginFilter(SomenteAdmin = true)]
        public IActionResult Editar(int id)
        {
            Requisito requisito = Banco.Requisitos.Find(id);

            if (requisito == null)
            {
                return RedirectToAction("index");
            }

            return View("Form", requisito);
        }

        [LoginFilter(SomenteAdmin = true)]
        [HttpPost]
        public IActionResult Editar(Requisito requisito)
        {
            if (ModelState.IsValid)
            {
                Banco.Requisitos.Update(requisito);
                Banco.SaveChanges();
            }
            else
            {
                return View("Form", requisito);
            }


            return RedirectToAction("index");
        }

        [LoginFilter(SomenteAdmin = true)]
        public IActionResult Excluir(int id)
        {
            Requisito requisito = Banco.Requisitos.Find(id);

            if (requisito != null)
            {
                Banco.Requisitos.Remove(requisito);
                Banco.SaveChanges();
            }

            return RedirectToAction("index");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            
            ViewBag.Development = Banco.Desenvolvedores.Select(c => new SelectListItem
            {
                Text = c.Nome,
                Value = c.Id.ToString()
            });
        }

    }
}