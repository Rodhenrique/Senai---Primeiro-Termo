using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoletopMvc.Controllers
{
    public class AbstractController : Controller
    {
        protected const string SESSION_CLIENTE_EMAIL = "email_cliente";
        protected const string SESSION_CLIENTE_NOME = "nome_cliente";
        protected const string SESSION_CLIENTE_TIPO = "cliente_tipo";
        protected const string PATH_FOTOS = "img\\fotos";
        protected const string PATH_USUARIO = "img\\fotos\\usuario";

        protected string ObterUsuarioSession()
        {
            var nomeUsuario = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            if (!string.IsNullOrEmpty(nomeUsuario))
            {
                return nomeUsuario;
            }
            else
            {
                return "";
            }
        }
        protected string ObterUsuarioNomeSession()
        {
            var nomeUsuario = HttpContext.Session.GetString(SESSION_CLIENTE_NOME);
            if (!string.IsNullOrEmpty(nomeUsuario))
            {
                return nomeUsuario;
            }
            else
            {
                return "";
            }
        }
        protected string ObterUsuarioTipoSession()
        {
            var tipoUsuario = HttpContext.Session.GetString(SESSION_CLIENTE_TIPO);
            if (!string.IsNullOrEmpty(tipoUsuario))
            {
                return tipoUsuario;
            }
            else
            {
                return "";
            }
        }
    }
}