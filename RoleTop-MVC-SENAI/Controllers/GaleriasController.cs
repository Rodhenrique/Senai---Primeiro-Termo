using Microsoft.AspNetCore.Mvc;
using RoletopMvc.ViewModels;

namespace RoletopMvc.Controllers
{
    public class GaleriasController : AbstractController
    {
        public IActionResult Galeria()
        {
            return View( new RespostaViewModel(){NomeView = "Galeria",UsuarioEmail = ObterUsuarioSession(),UsuarioNome = ObterUsuarioNomeSession()});
        }
         public IActionResult GaleriaCliente()
        {
            return View(new RespostaViewModel(){NomeView = "Galeria",UsuarioEmail = ObterUsuarioSession(),UsuarioNome = ObterUsuarioNomeSession()});
        }

         public IActionResult GaleriaDonos()
        {
            return View(new RespostaViewModel(){NomeView = "Galeria",UsuarioEmail = ObterUsuarioSession(),UsuarioNome = ObterUsuarioNomeSession()});
        }
         public IActionResult Buscar()
        {
            return View(new RespostaViewModel(){NomeView = "Galeria",UsuarioEmail = ObterUsuarioSession(),UsuarioNome = ObterUsuarioNomeSession()});
        }


    }
}