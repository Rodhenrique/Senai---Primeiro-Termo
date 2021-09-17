using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMvc.Models;
using RoletopMvc.Repositories;
using RoletopMvc.ViewModels;

namespace RoletopMvc.Controllers
{
    public class DashClienteController : AbstractController
    {
        private PedidoRepository pedidoRepository = new PedidoRepository();
        ClienteRepository clienteRepository = new ClienteRepository();
        Cliente cliente = new Cliente();
        public IActionResult Dashboard(IFormCollection form)
        {
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var pedidosCliente = pedidoRepository.ObterTodosPorCliente(emailCliente);

            var buscar = clienteRepository.ObterPor(emailCliente);

            cliente = buscar;

            var urlFoto = Directory.GetFiles(cliente.URLFotoPerfil).FirstOrDefault();
            var urlRelativa = urlFoto.Replace(Directory.GetCurrentDirectory(), "").Replace("\\", "/").Replace("wwwroot", "");

            return View(new HistoricoViewModel() { alugars = pedidosCliente, NomeView = "Dashboard", UsuarioEmail = ObterUsuarioSession(), UsuarioNome = ObterUsuarioNomeSession(), URLFoto = urlRelativa });
        }
        public IActionResult Dados(IFormCollection form)
        {
            Cliente cliente = new Cliente();
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var pedidosCliente = pedidoRepository.ObterTodosPorCliente(emailCliente);
            var buscar = clienteRepository.ObterPor(emailCliente);

            var nome = form["nome"];
            var email = form["email"];
            var emailconfir = form["emailconfir"];
            var telefone = form["telefone"];
            var senha = form["senha"];
            var senhaConfirma = form["confirma"];
            
            return View(new HistoricoViewModel() { cliente = buscar, NomeView = "Dados", UsuarioEmail = ObterUsuarioSession(), UsuarioNome = ObterUsuarioNomeSession() });
        }

        public IActionResult Mensagem(IFormCollection form)
        {
             var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var pedidosCliente = pedidoRepository.ObterTodosPorCliente(emailCliente);
            var buscar = clienteRepository.ObterPor(emailCliente);

            Mensagem mensagem = new Mensagem();
            MensagemRepository mensagemRepository = new MensagemRepository();
            
            mensagem.MensagemDoCliente = form["mensagem"];
            mensagem.Email = form["emaildamensagem"];
            mensagem.Objetivo = form["objetivo"];
            mensagem.Data = DateTime.Now;

            mensagemRepository.Inserir(mensagem);

            return View("Sucesso", new RespostaViewModel("sua mensagem foi enviada com sucesso!!!"){cliente = buscar,NomeView = "Dashboard", UsuarioEmail = ObterUsuarioSession(), UsuarioNome = ObterUsuarioNomeSession() });
        }
        

    }
}