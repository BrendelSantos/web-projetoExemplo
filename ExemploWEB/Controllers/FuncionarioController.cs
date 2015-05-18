using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exemplo.Infraestrutura.Database;
using Exemplo.Dominio.Interfaces;
using Exemplo.Dominio.Classes;

namespace ExemploWEB.Controllers
{
    public class FuncionarioController : Controller
    {
        public IExemplo IExemplo { get; set; }
        public IFuncionarios funcionarios { get; set; }

        //
        // GET: /Funcionario/
        public ActionResult Index()
        {
            List<Funcionario> func = funcionarios.Listar().ToList<Funcionario>();
            return View(func);
        }
	}
}