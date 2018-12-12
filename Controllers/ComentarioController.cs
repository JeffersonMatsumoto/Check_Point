using System;
using Check_Point.Models;
using Check_Point.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Check_Point.Controllers
{
    public class ComentarioController : Controller
    {
        [HttpGet]
        public IActionResult Cadastrar(){
            
            if(string.IsNullOrEmpty(HttpContext.Session.GetString("idUsuario")) && string.IsNullOrEmpty(HttpContext.Session.GetString("nomeUsuario"))){
                return RedirectToAction("Login", "Usuario");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form){
            string nomeUsuario = HttpContext.Session.GetString("nomeUsuario");
            ComentarioModel comentario = new ComentarioModel(texto: form["texto"], usuario: nomeUsuario);//, status: form["status"], dataCriacao: DateTime.Parse(form["dataCriacao"])
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            
            // comentario.Texto.TrimStart();//assim n funciona pq só ta passando.. teria que armazaenar numa variavel..
            // string comment = comentario.Texto.TrimStart();

            // if (string.IsNullOrEmpty(coment))
            if (string.IsNullOrEmpty(comentario.Texto.TrimStart()))
            {
                ViewBag.Mensagem = "Comentário inválido.";
                return View();
            }

            ComentarioModel comentario_ = comentarioRepositorio.Cadastrar(comentario);
            // comentario.Usuario.Nome = HttpContext.Session.GetString("nomeUsuario"); No service for type 'Microsoft.AspNetCore.Http.IHttpContextAccessor' has been registered.
            if (comentario_ == null)
            {
                ViewBag.Mensagem = "O campo de comentário está vazio.";
                return View();
            } else {
                // ViewBag.MensagemSucesso = "Comentário Cadastrado com sucesso."; //n exibe
                return RedirectToAction("Listar", "Comentario");
            }
        }

        [HttpGet]
        public IActionResult Listar(){
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();

            ViewData["Comentarios"] = comentarioRepositorio.Listar();
            return View(); 
        }

        [HttpGet]
        public IActionResult ListarAtt(){
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();

            ViewData["ComentariosAtt"] = comentarioRepositorio.ListarAtt();
            return View(); 
        }


        [HttpGet]
        public IActionResult Aprovar(int id){//Rejeitar
            
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            // ComentarioModel comentario = new ComentarioModel(texto: form["texto"], usuario: nomeUsuario); 
            // comentario.Status = "rejeitado";
            comentarioRepositorio.Aprovar(id);

            // if (comentario.Status == "rejeitado")
            // {
                ViewData["Comentarios"] = comentarioRepositorio.Listar();
            // }

            return View();
        }

        [HttpGet]
        public IActionResult Manter(int id){
            
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            comentarioRepositorio.Manter(id);

            ViewData["Comentarios"] = comentarioRepositorio.Listar();
            return RedirectToAction("Aprovar", "Comentario");//redirect pq return view() vai querer uma tela
        }
    }
}