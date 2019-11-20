using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_Trimestral.Filtros;
using Trabalho_Trimestral.Models;

namespace Trabalho_Trimestral.Controllers
{
    public class HomeController : Controller
    {
        private AppContext Banco;

        public HomeController(AppContext appContext)
        {
            Banco = appContext;
        }

        [LoginFilter]
        public IActionResult Index()
        {
            //ViewBag.Bugs = Banco.Bugs.Include(p => p.Requisito).OrderBy(c => c.Prioridade).OrderBy(o => o.DataCadastro);
            ViewBag.RequisitosBugs = Banco.Requisitos.Include(c => c.Bugs).OrderBy(c => c.Descricao).Where(c => c.Bugs.Count() > 0);
            ViewBag.Requisitos = Banco.Requisitos.Include("Atribuicoes").Include("Atribuicoes.Desenvolvedor").OrderBy(c => c.DataCadastro).ToList();
            ((List<Requisito>) ViewBag.Requisitos).Sort(Requisito.ComparaDatas);
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
