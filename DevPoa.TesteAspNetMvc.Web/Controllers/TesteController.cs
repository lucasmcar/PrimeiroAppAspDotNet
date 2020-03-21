using DevPoa.TesteAspNetMvc.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevPoa.TesteAspNetMvc.Web.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }
        /*
         * Toda action é publica
         * Toda action retorna SEMPRE um ActionResult
         */

        [HttpPost] //Definindo que é envio via post
        public ActionResult Index([Bind(Exclude = "Ativo")]Pessoa pessoa)
        {
            //String nome = formCollection["nome"];
            //ViewBag.Mensagem = pessoa.Nome;
            //ViewBag.PessoaInformada = pessoa;

            //Verifica se as validações das anottations são validas
            if(ModelState.IsValid)
            {
                return View("Saudacao", pessoa);
            }
            else
            {
                return View(pessoa);
            }

        }
    }
    
}