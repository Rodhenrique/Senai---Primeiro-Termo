using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMvc.Enums;
using RoletopMvc.Models;
using RoletopMvc.Repositories;
using RoletopMvc.ViewModels;

namespace RoletopMvc.Controllers {
    public class AgendamentoController : AbstractController {
        ClienteRepository clienteRepository = new ClienteRepository ();
        PedidoRepository pedidoRepository = new PedidoRepository ();
        SomRepository somRepository = new SomRepository ();
        IluminacaoRepository iluminacaoRepository = new IluminacaoRepository ();
        SalaoRepository salaoRepository = new SalaoRepository ();

        public IActionResult Index () {
            PedidosViewModels pedido = new PedidosViewModels ();

            pedido.Opcaos = iluminacaoRepository.ObterValor ();
            pedido.Opcaos1 = somRepository.ObterValor ();
            pedido.Eventos = salaoRepository.ObterValor ();

            var usuarioLogado = ObterUsuarioSession ();
            var nomeUsuarioLogado = ObterUsuarioNomeSession ();
            
            if (!string.IsNullOrEmpty (nomeUsuarioLogado)) {
                pedido.NomeCliente = nomeUsuarioLogado;
            }

            var clienteLogado = clienteRepository.ObterPor (usuarioLogado);
            if (clienteLogado != null) {
                pedido.cliente = clienteLogado;
            }
            pedido.NomeView = "Pedido";
            pedido.UsuarioEmail = usuarioLogado;
            pedido.UsuarioNome = nomeUsuarioLogado;

            return View (pedido);
        }
        public IActionResult Registrar (IFormCollection form) {
            ViewData["Action"] = "Agendamento";

            try {
                Alugar alugar = new Alugar ();
                Cliente cliente = new Cliente ();
                Salao salao = new Salao ();

                var OpcaoSom = form["som"];
                if (OpcaoSom != ("Sim") && OpcaoSom != ("não")) {
                    return View ("Erro", new RespostaViewModel ("Opções invalida Agendamento Não Efetuado!!!") { NomeView = "Agendamento", UsuarioEmail = ObterUsuarioSession (), UsuarioNome = ObterUsuarioNomeSession () });
                } else {
                    var OpcaoIluminacao = form["ilumina"];

                    if (OpcaoIluminacao != ("Sim") && OpcaoIluminacao != ("não")) {
                        return View ("Erro", new RespostaViewModel ("Opções invalida Agendamento Não Efetuado!!!") { NomeView = "Agendamento", UsuarioEmail = ObterUsuarioSession (), UsuarioNome = ObterUsuarioNomeSession () });

                    } else {

                        Som som = new Som (OpcaoSom, somRepository.valor ());

                        Iluminacao iluminacao = new Iluminacao (OpcaoIluminacao, iluminacaoRepository.valor ());

                        if (OpcaoSom.Equals ("Sim")) {
                            alugar.PrecoTotal += somRepository.valor ();
                            alugar.selecionaSom = "/img/agora.png";
                        } else {
                            alugar.selecionaSom = "/img/icons8-x-16.png";
                        }

                        if (OpcaoIluminacao.Equals ("Sim")) {
                            alugar.PrecoTotal += iluminacaoRepository.valor ();
                            alugar.selecionaIlumina = "/img/agora.png";
                        } else {
                            alugar.selecionaIlumina = "/img/icons8-x-16.png";
                        }
                        cliente.Email = form["email"];

                        alugar.DataDoPedido = DateTime.Now;

                        alugar.TipoEvento = form["eventos"];

                        alugar.Descricao = form["descricao"];

                        alugar.Pagamento = form["forma"];

                        alugar.organizado = form["organizado"];

                        alugar.iluminacao = iluminacao;
                        alugar.som = som;

                        alugar.cliente = cliente;

                        var valorSalao = salaoRepository.valor ();

                        alugar.PrecoTotal += valorSalao;

                        pedidoRepository.Inserir (alugar);

                        return View ("Sucesso", new RespostaViewModel () { NomeView = "Agendamento", UsuarioEmail = ObterUsuarioSession (), UsuarioNome = ObterUsuarioNomeSession () });
                    }
                }
            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro", new RespostaViewModel () { NomeView = "Agendamento", UsuarioEmail = ObterUsuarioSession (), UsuarioNome = ObterUsuarioNomeSession () });
            }
        }
        public IActionResult Aprovar (ulong id) {
            var pedido = pedidoRepository.ObterPor (id);

            pedido.StatusNome = "APROVADO";

            pedido.Status = (uint) StatusPedido.APROVADO;

            if (pedidoRepository.Atualizar (pedido)) {
                return RedirectToAction ("ADM", "Administrador");
            } else {
                return View ("Erro", new RespostaViewModel ("Não foi possivel aprovar este pedido") { NomeView = "Dashboard", UsuarioEmail = ObterUsuarioSession (), UsuarioNome = ObterUsuarioNomeSession () });
            }
        }
        public IActionResult Reprovar (ulong id) {
            var pedido = pedidoRepository.ObterPor (id);
            pedido.StatusNome = "REPROVADO";

            pedido.Status = (uint) StatusPedido.REPROVADO;

            if (pedidoRepository.Atualizar (pedido)) {
                return RedirectToAction ("ADM", "Administrador");
            } else {
                return View ("Erro", new RespostaViewModel ("Não foi possivel aprovar este pedido") { NomeView = "Dashboard", UsuarioEmail = ObterUsuarioSession (), UsuarioNome = ObterUsuarioNomeSession () });
            }
        }
    }
}