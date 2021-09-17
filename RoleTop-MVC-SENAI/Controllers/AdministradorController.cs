using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMvc.Enums;
using RoletopMvc.Models;
using RoletopMvc.Repositories;
using RoletopMvc.ViewModels;

namespace RoletopMvc.Controllers {
    public class AdministradorController : AbstractController {
        PedidoRepository pedidoRepository = new PedidoRepository ();
        MensagemRepository mensagemRepository = new MensagemRepository ();
        DashboardViewModel dashboardViewModel = new DashboardViewModel ();

        public IActionResult ADM () {
            var ninguemLogado = string.IsNullOrEmpty (ObterUsuarioTipoSession ());

            if (!ninguemLogado && (uint) TipoUsuario.ADMINISTRADOR == uint.Parse (ObterUsuarioTipoSession ())) {
                var pedidos = pedidoRepository.ObterTodos ();

                foreach (var pedido in pedidos) {
                    switch (pedido.Status) {
                        case (uint) StatusPedido.APROVADO:
                            dashboardViewModel.PedidosAprovados++;
                            break;
                        case (uint) StatusPedido.REPROVADO:
                            dashboardViewModel.PedidosReprovados++;
                            break;
                        default:
                            dashboardViewModel.PedidosPendentes++;
                            dashboardViewModel.Pedidos.Add (pedido);
                            break;
                    }
                }
                dashboardViewModel.NomeView = "Dashboard";
                dashboardViewModel.UsuarioEmail = ObterUsuarioSession ();

                var emailCliente = HttpContext.Session.GetString (SESSION_CLIENTE_EMAIL);
                var pedidosCliente = pedidoRepository.ObterTodosPorCliente (emailCliente);

                var mensagem = mensagemRepository.ObterTodos ();

                foreach (var item in mensagem) {

                    dashboardViewModel.Mensagem.Add (item);
                }

                return View (dashboardViewModel);
            } else {
                return View ("Erro", new RespostaViewModel () { NomeView = "Dashboard", Mensagem = "Você não tem permissão para acessar o dashboard" });
            }
        }

        public IActionResult mensagem (IFormCollection form) {

            var ninguemLogado = string.IsNullOrEmpty (ObterUsuarioTipoSession ());

            if (!ninguemLogado && (uint) TipoUsuario.ADMINISTRADOR == uint.Parse (ObterUsuarioTipoSession ())) {

                dashboardViewModel.UsuarioEmail = ObterUsuarioSession ();

                var emailCliente = HttpContext.Session.GetString (SESSION_CLIENTE_EMAIL);
                var pedidosCliente = pedidoRepository.ObterTodosPorCliente (emailCliente);

                var mensagem = mensagemRepository.ObterTodos ();

                dashboardViewModel.NomeView = "Mensagem";

                foreach (var item in mensagem) {

                    dashboardViewModel.Mensagem.Add (item);
                }

                return View (dashboardViewModel);
            } else {
                return View ("Erro", new RespostaViewModel () { NomeView = "Dashboard", Mensagem = "Você não tem permissão para acessar o dashboard" });
            }
        }
        public IActionResult EnviarEmail (IFormCollection form) {
            string email;
            string titulo;
            string mensagem;

            try {
                mensagem = form["resposta"];
                titulo = form["tituloDoTexto"];
                email = form["emaildamensagem"];

                if (mensagem.Equals("") || titulo.Equals("")) {
                    return View ("Erro", new RespostaViewModel ("sua mensagem não foi enviada!!!") { NomeView = "ADM", UsuarioEmail = ObterUsuarioSession (), UsuarioNome = ObterUsuarioNomeSession () });
                }

                SendMail (email, titulo, mensagem);
                return View ("Sucesso", new RespostaViewModel ("sua mensagem foi enviada com sucesso!!!") { NomeView = "ADM", UsuarioEmail = ObterUsuarioSession (), UsuarioNome = ObterUsuarioNomeSession () });

            } catch (System.Exception) {
                return View ("Erro", new RespostaViewModel ("sua mensagem não foi enviada!!!") { NomeView = "ADM", UsuarioEmail = ObterUsuarioSession (), UsuarioNome = ObterUsuarioNomeSession () });
            }
        }
        public bool SendMail (string email, string titulo, string mensagem) {
            try {
                //         // Estancia da Classe de Mensagem
                MailMessage _mailMessage = new MailMessage ();
                //         // Remetente
                _mailMessage.From = new MailAddress ("roletop.senai@gmail.com");

                // Destinatario seta no metodo abaixo

                //Contrói o MailMessage
                _mailMessage.CC.Add (email);
                _mailMessage.Subject = $"{titulo}";
                _mailMessage.IsBodyHtml = true;
                _mailMessage.Body = $"<b>Olá Tudo bem ??</b><p>{mensagem}</p>";

                //CONFIGURAÇÃO COM PORTA
                SmtpClient _smtpClient = new SmtpClient ("smtp.gmail.com", Convert.ToInt32 ("587"));

                //CONFIGURAÇÃO SEM PORTA
                // SmtpClient _smtpClient = new SmtpClient(UtilRsource.ConfigSmtp);

                // Credencial para envio por SMTP Seguro (Quando o servidor exige autenticação)
                _smtpClient.UseDefaultCredentials = false;
                _smtpClient.Credentials = new NetworkCredential ("roletop.senai@gmail.com", "senai@132");

                _smtpClient.EnableSsl = true;

                _smtpClient.Send (_mailMessage);

                return true;

            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}