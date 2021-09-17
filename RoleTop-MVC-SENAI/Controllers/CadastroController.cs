using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMvc.Enums;
using RoletopMvc.Models;
using RoletopMvc.Repositories;
using RoletopMvc.ViewModels;

namespace RoletopMvc.Controllers {
    public class CadastroController : AbstractController {
        ClienteRepository clienterepository = new ClienteRepository ();
        public IActionResult Index () {
            return View (new RespostaViewModel () { NomeView = "Cadastro", UsuarioEmail = ObterUsuarioSession (), UsuarioNome = ObterUsuarioNomeSession () });
        }
        public IActionResult CadastrarCliente (IFormCollection form) {
            ViewData["Action"] = "Cadastro";
        var urlFoto = "";
            try {
                Cliente cliente = new Cliente (form["nome"], form["email"], form["telefone"], DateTime.Parse (form["data"]), form["cpf"], form["senha"], form["csenha"]);
                cliente.TipoUsuario = (uint) TipoUsuario.CLIENTE;

                if(form.Files.Count.Equals(0))
                {
                    urlFoto = $"wwwroot\\{PATH_USUARIO}";
                    cliente.URLFotoPerfil = urlFoto;
                }
                else{
                    urlFoto = $"wwwroot\\{PATH_FOTOS}\\{cliente.Telefone}\\perfil\\";
                    cliente.URLFotoPerfil = urlFoto;
                }

                    GravarFoto (form.Files, urlFoto);

                clienterepository.Inserir (cliente);

                return View ("Sucesso", new RespostaViewModel () { NomeView = "Cadastro", UsuarioEmail = ObterUsuarioSession (), UsuarioNome = ObterUsuarioNomeSession () });
            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro", new RespostaViewModel () { NomeView = "Cadastro", UsuarioEmail = ObterUsuarioSession (), UsuarioNome = ObterUsuarioNomeSession () });
            }
        }
        public async void GravarFoto (IFormFileCollection arquivos, string urlFoto) {
            foreach (var foto in arquivos) {
                System.IO.Directory.CreateDirectory (urlFoto).Create ();
                var file = System.IO.File.Create (urlFoto + foto.FileName);
                await foto.CopyToAsync (file);
                file.Close ();
            }
        }
    }
}