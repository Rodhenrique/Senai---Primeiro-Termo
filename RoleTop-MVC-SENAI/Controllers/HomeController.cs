using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMvc.Models;
using RoletopMvc.Repositories;
using RoletopMvc.ViewModels;

namespace RoletopMvc.Controllers
{
    public class HomeController : AbstractController
    {
        public IActionResult Index()
        {
            return View(new RespostaViewModel() { NomeView = "Home", UsuarioEmail = ObterUsuarioSession(), UsuarioNome = ObterUsuarioNomeSession() });
        }
        [HttpGet]
        public IActionResult Agenda()
        {
            return View(new RespostaViewModel() { NomeView = "Home", UsuarioEmail = ObterUsuarioSession(), UsuarioNome = ObterUsuarioNomeSession() });
        }
        [HttpPost]
        public IActionResult Agenda2(IFormCollection form)
        {
                return RedirectToAction("Index", "Agendamento");
        }

        public IActionResult QuemSomos()
        {
            return View(new RespostaViewModel() { NomeView = "Home", UsuarioEmail = ObterUsuarioSession(), UsuarioNome = ObterUsuarioNomeSession() });
        }
    }
}
