using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Check_Point.Interfaces;
using Check_Point.Models;
using Check_Point.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Check_Point.Controllers {
    public class UsuarioController : Controller {
        [HttpGet]
        public IActionResult Cadastrar () {
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio ();
            List<ComentarioModel> lsComentarios = new List<ComentarioModel> ();
            ViewData["ComentariosAtt"] = comentarioRepositorio.ListarAtt ();
            return View ();
        }

        [HttpPost]
        public IActionResult Cadastrar (IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel (nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                tipo: form["tipo"]);
                // sexo: form["sexo"]

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();

            { //VERSÃO ATUAL

                // if(usuario_ == null){
                //     ViewBag.Mensagem = "Um ou mais campos estão em branco, seu preenchimento é obrigatório.";
                //     return View();
                // } else {
                //     // ViewBag.Mensagem = "User Cadastrado"; // n exibe
                //     return RedirectToAction("Login", "Usuario");
                // }

            }

            { //VERSÃO APRIMORADA

                // if (usuario.Email == "admin@carfel.com" && usuario.Senha == "admin")
                // {
                //     usuario.Tipo = "adm";
                // } else {
                //     usuario.Tipo = "comum";
                // }

                // if ((!string.IsNullOrEmpty(usuario.Nome)) && (!string.IsNullOrEmpty(usuario.Email)) && (!string.IsNullOrEmpty(usuario.Senha))){     
                // return RedirectToAction("Login", "Usuario");
                // }
            }
                
                //DO WHILE
                if ((!string.IsNullOrEmpty (usuario.Nome)) && (!string.IsNullOrEmpty (usuario.Email)) && (!string.IsNullOrEmpty (usuario.Senha))) {

                    bool dadosCorretos1 = false;
                    bool dadosCorretos2 = false;
                    bool dadosCorretos3 = false;

                    if (Regex.IsMatch (usuario.Nome, @"[1234567890,/;@.\\]")) {
                        // ViewBag.MensagemErroNOME = "Caractere(s) inserido(s) inválido(s).";
                        TempData["MensagemErroNOME"] = "Caractere(s) inserido(s) inválido(s)";
                        // return View();
                    } else if (usuario.Nome.Length == 1) {
                        // ViewBag.MensagemErroNOME = "Mínimo de caracteres inválido";
                        TempData["MensagemErroNOME"] = "Mínimo de caracteres inválido.";
                    } else if (string.IsNullOrEmpty (usuario.Nome)) { // quando poe - no colchete do regex ele delimita.. ex: \-/. vai bugar.. 
                        // ViewBag.MensagemErroNOME = "O campo *Nome* está vazio. Por favor insira seu nome.";
                        TempData["MensagemErroNOME"] = "O campo *Nome* está vazio. Por favor insira seu nome.";
                    } else {
                        dadosCorretos1 = true;
                    }

                    if (string.IsNullOrEmpty (usuario.Email)) {
                        // ViewBag.MensagemErroEMAIL = "O campo *E-mail* está vazio. Por favor insira seu e-mail.";
                        TempData["MensagemErroEMAIL"] = "O campo *E-mail* está vazio. Por favor insira seu e-mail.";
                        // return View();
                    } else if ((!usuario.Email.Contains("@")) || (!usuario.Email.Contains(".com"))){
                        TempData["MensagemErroEMAIL"] = "O campo *E-mail* está inválido. Por favor insira um e-mail válido.";
                    } else {
                        dadosCorretos2 = true;
                    }

                    if (string.IsNullOrEmpty (usuario.Senha)) {
                        // ViewBag.MensagemErroSENHA = "O campo *Senha* está vazio. Por favor insira sua senha.";
                        TempData["MensagemErroSENHA"] = "O campo *Senha* está vazio. Por favor insira sua senha.";
                        // return View(); 
                    } else if (usuario.Senha.Length < 6) {
                        // ViewBag.MensagemErroSENHA = "O campo *Senha* exige no mínimo, 6 digitos. No máximo, 12 digitos.";
                        TempData["MensagemErroSENHA"] = "O campo *Senha* exige no mínimo, 6 digitos. No máximo, 12 digitos.";
                    } else if (usuario.Senha.Length >= 12) {
                        // ViewBag.MensagemErroSENHA = "O campo *Senha* aceita no máximo, 12 digitos.";
                        TempData["MensagemErroSENHA"] = "O campo *Senha* aceita no máximo, 12 digitos.";
                    } else {
                        dadosCorretos3 = true;
                    }
                    

                    if (dadosCorretos1 == true && dadosCorretos2 == true && dadosCorretos3 == true) {
                        UsuarioModel usuario_ =  usuarioRepositorio.Cadastrar(usuario); //usuario_ para diferenciar
                        return RedirectToAction ("Login", "Usuario");
                    }
                    // dadosCorretos = true;
                // return RedirectToAction("Cadastrar", "Usuario");
                }
                // UsuarioModel usuario_ =  usuarioRepositorio.Cadastrar(usuario); //usuario_ para diferenciar
                    return RedirectToAction("Cadastrar", "Usuario");

                // if ((!string.IsNullOrEmpty(usuario.Nome)) && (!string.IsNullOrEmpty(usuario.Email)) && (!string.IsNullOrEmpty(usuario.Senha))){     
                // if ((!string.IsNullOrEmpty(usuario.Nome)) && (!string.IsNullOrEmpty(usuario.Email)) && (!string.IsNullOrEmpty(usuario.Senha))){     
                //     return RedirectToAction("Login", "Usuario");
                // }
                // return View();
        }

        [HttpGet]
        public IActionResult Listar () {
            if (HttpContext.Session.GetString("tipoUsuario") != "adm")
            {
                return RedirectToAction("Login", "Usuario");
            }
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            ViewData["Usuarios"] = usuarioRepositorio.Listar ();
            return View ();
        }

        [HttpGet]
        public IActionResult Login () {
            return View ();
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();

            if (string.IsNullOrEmpty (form["email"])) {
                ViewBag.Mensagem = "O campo *E-mail* está vazio. Digite seu e-mail.";
                return View ();
            } else if (string.IsNullOrEmpty (form["senha"])) {
                ViewBag.Mensagem = "O campo *Senha* está vazio. Digite sua senha.";
                return View ();
            }

            UsuarioModel usuario = usuarioRepositorio.Login (form["email"], form["senha"]);

            // if (usuario.Email == "admin@carfel.com" && usuario.Senha == "admin")
            // {
            //     usuario.Tipo = "adm";
            // } else {
            //     // usuario.Tipo = "comum";
            //     return View();
            // }

            { //VERSÃO ANTERIOR
                // if (usuario != null){
                //     HttpContext.Session.SetString("idUsuario", usuario.Id.ToString());
                //     HttpContext.Session.SetString("nomeUsuario", usuario.Nome.ToString());
                //     return RedirectToAction ("Cadastrar", "Comentario");
                // } 

                //ADM
                // while(usuario != null){
                // if (usuario.Id == 1){
                // HttpContext.Session.SetString("idUsuario", usuario.Id.ToString());
                // HttpContext.Session.SetString("nomeUsuario", usuario.Nome.ToString());
                // return RedirectToAction ("Aprovar", "Comentario");
                // }
                // }
                // return RedirectToAction ("Cadastrar", "Comentario");
                // ViewBag.Mensagem = "Usuário inválido, digite novamente";
                // return View ();
            }

            { //VERSÃO 1.0
                // if (usuario == null){

                // if (usuario.Email != form["email"]){
                // ViewBag.Mensagem = "eb";
                // return View();
                // }
                // ViewBag.Mensagem = "Usuário inválido, digite novamente";

                #region Validação
                // if(usuario.Email == null) {
                //     ViewBag.Mensagem = "O e-mail inserido não foi cadastrado ou está incorreta. Por favor tente novamente.";//Usuário inválido, digite novamente
                //     return View ();
                // }
                // if(usuario.Senha == null) {
                //     ViewBag.Mensagem = "A senha inserida está incorreta. Por favor tente novamente.";//Usuário inválido, digite novamente
                //     return View ();
                // }
                #endregion
                // return View ();
                // }

                // if (usuario.Email == form["email"]){
                //     ViewBag.Mensagem = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
                //     return View();
                // }
            }

            { //VERSÃO ATUAL

            if(HttpContext.Session.GetString("tipoUsuario") != null){
                HttpContext.Session.Remove("tipoUsuario");
            }

                if (usuario == null) {
                    ViewBag.Mensagem = "Usuário inválido, digite novamente";
                    return View ();
                } else {
                    HttpContext.Session.SetString ("idUsuario", usuario.Id.ToString ());
                    HttpContext.Session.SetString ("nomeUsuario", usuario.Nome.ToString ());

                    if (usuario.Email == "admin@carfel.com" && usuario.Senha == "admin") {
                        //Armazena na sessão o tipo de usuário
                        HttpContext.Session.SetString ("tipoUsuario", "adm");

                        usuario.Tipo = "adm";

                        if (usuario.Tipo == "adm") {
                            return RedirectToAction ("Aprovar", "Comentario");
                        }
                        
                        // if (usuario.Tipo == "adm") {
                        //     return RedirectToAction ("Listar", "Usuario");
                        // }

                    }
                    return RedirectToAction ("Cadastrar", "Comentario");
                }

            }

            { //VERSÃO APRIMORADA

                // if (usuario.Email == emailCadastrado) && usuario.Senha == senhaCadastrada)){     
                //     return RedirectToAction("Cadastrar", "Comentario");
                // }

                // if (string.IsNullOrEmpty(usuario.Senha))
                // {
                //     ViewBag.Mensagem = "O campo *Senha* está vazio. Digite sua senha.";
                //     return View();
                // } else if (usuario.Senha != senhaCadastrada){
                //     ViewBag.Mensagem = "Senha inválida, digite novamente";
                //     return View();
                // }

                // if (usuario.Id == 1){
                //     HttpContext.Session.SetString("idUsuario", usuario.Id.ToString());
                //     HttpContext.Session.SetString("nomeUsuario", usuario.Nome.ToString());
                //     return RedirectToAction ("Aprovar", "Comentario");
                // }

                // if (usuario != null){
                //     HttpContext.Session.SetString("idUsuario", usuario.Id.ToString());
                //     HttpContext.Session.SetString("nomeUsuario", usuario.Nome.ToString());
                // }
                //     return RedirectToAction ("Cadastrar", "Comentario");

            }
        }

        [HttpGet]
        public IActionResult Logout () {
            HttpContext.Session.Remove("nomeUsuario");
            HttpContext.Session.Remove("senhaUsuario");
            HttpContext.Session.Remove("tipoUsuario");;
            HttpContext.Session.Clear();
            return RedirectToAction ("Login", "Usuario");
        }
    }
}

// https://pt.stackoverflow.com/questions/193376/c-string-contains-n%C3%A3o-funciona-nem-mesmo-derivados-de-busca-em-string
// https://stackoverflow.com/questions/10419106/checking-multiple-contains-on-one-string
// https://stackoverflow.com/questions/7476922/net-regex-error-x-y-range-in-reverse-order

// httpcontext.Session.clear()