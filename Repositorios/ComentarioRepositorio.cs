using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Check_Point.Interfaces;
using Check_Point.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Check_Point.Repositorios
{
    public class ComentarioRepositorio : IComentario
    {
        public void Aprovar(int id)
        {
            string[] linhas = System.IO.File.ReadAllLines("comentarios.csv");
            for (int i = 0; i < linhas.Length; i++)//percorrer linhas do arquivo
            {
                string[] linha = linhas[i].Split(";");//split pra separar as colunas da linha

                if (id.ToString() == linha[0])//verificar se o id é valido, o id da linha é o id passado
                {
                    linhas[i] = "";
                    break;
                }
            }
            System.IO.File.WriteAllLines("comentarios.csv", linhas);
            // ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
        }

        public void Manter(int id)
        {
            string[] linhas = System.IO.File.ReadAllLines("comentarios.csv");
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");

                if(id.ToString() == linha[0]){
                    linha[4] = "Aprovado";
                    linhas[i] = $"{linha[0]};{linha[1]};{linha[2]};{linha[3]};{linha[4]}";
                    break;
                }
            }
                id = 0;
            System.IO.File.WriteAllLines("comentarios.csv", linhas);
        }

        public ComentarioModel Cadastrar(ComentarioModel comentario)
        {
            if (File.Exists("comentarios.csv"))
            {
                comentario.Id = File.ReadAllLines("comentarios.csv").Length + 1;
            } else {
                comentario.Id = 1;
            }

            using(StreamWriter sw = new StreamWriter("comentarios.csv", true)){
            
            if (!File.Exists("comentarios.csv"))
            {
                StreamWriter sr = new StreamWriter ("comentarios.csv");
            }
                if (string.IsNullOrEmpty(comentario.Texto))
                {
                    return null;
                }else{
                // if (comentario.Texto.Contains(" ")){
                //     comentario.Texto.TrimStart();
                //     comentario.Texto.TrimEnd();
                // }
                    // comentario.Usuario.Nome = HttpContext.Session.GetString("nomeUsuario");//Pegar o nome do usuário da sessão
                    // comentario.DataCriacao = DateTime.Now;
                    // comentario.Usuario.Nome.ToString();
                    // comentario.Texto.Replace("\n", "x");
                    comentario.Status = "Pendente";
                    comentario.Texto = char.ToUpper(comentario.Texto[0]) + comentario.Texto.Substring(1);
                    sw.WriteLine($"{comentario.Id};{comentario.Usuario.Nome};{comentario.Texto.Replace(System.Environment.NewLine, " ").Trim()};{comentario.DataCriacao};{comentario.Status}");
                    // sw.WriteLine($"{comentario.Id};{comentario.Usuario};{comentario.Texto};{comentario.Status};{comentario.DataCriacao}");
                }
            }

            return comentario;
        }

        public List<ComentarioModel> Listar(){
            List<ComentarioModel> lsComentarios = new List<ComentarioModel>();
            string[] linhas = System.IO.File.ReadAllLines("comentarios.csv");

            ComentarioModel comentario;

            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item)){
                    continue;
                }
                    
                string[] linha = item.Split(";");
                comentario = new ComentarioModel(id: int.Parse(linha[0]), usuario: linha[1], texto: linha[2], dataCriacao: DateTime.Parse(linha[3]), status: linha[4]);//0 é o id, 1 é o texto e 2 é a data de criação
                
                // System.Console.WriteLine("qnt" + linha.Length);
                comentario.Id = int.Parse(linha[0]);
                comentario.Usuario.Nome = linha[1];
                comentario.Texto = linha[2];
                // comentario.Status = linha[2];
                comentario.DataCriacao = DateTime.Parse(linha[3]);
                comentario.Status = linha[4];

                lsComentarios.Add(comentario);
                
            }

            // return lsComentarios;
            return lsComentarios .OrderBy (x => x.DataCriacao).Reverse ().ToList () ;
        }

        public List<ComentarioModel> ListarAtt(){
            List<ComentarioModel> lsComentarios = new List<ComentarioModel>();
            string[] linhas = System.IO.File.ReadAllLines("comentarios.csv");

            ComentarioModel comentario;

            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item)){
                    continue;
                }
                
                string[] linha = item.Split(";");
                
                comentario = new ComentarioModel(id: int.Parse(linha[0]), usuario: linha[1], texto: linha[2], dataCriacao: DateTime.Parse(linha[3]), status: linha[4]);//0 é o id, 1 é o texto e 2 é a data de criação
                if (comentario.Status == "Aprovado")
                {
                // System.Console.WriteLine("qnt" + linha.Length);
                comentario.Id = int.Parse(linha[0]);
                comentario.Usuario.Nome = linha[1];
                comentario.Texto = linha[2];
                // comentario.Status = linha[2];
                comentario.DataCriacao = DateTime.Parse(linha[3]);
                comentario.Status = linha[4];

                lsComentarios.Add(comentario);
                }
            }

            return lsComentarios .OrderBy (x => x.DataCriacao).Reverse ().ToList () ;
        }

        // public List<ComentarioModel> ListarRejeitado(){
        //     List<ComentarioModel> lsComentarios = new List<ComentarioModel>();
        //     string[] linhas = System.IO.File.ReadAllLines("comentarios.csv");

        //     ComentarioModel comentario;

        //     foreach (var item in linhas)
        //     {
        //         if (string.IsNullOrEmpty(item)){
        //             continue;
        //         }
                
        //         string[] linha = item.Split(";");
                
        //         comentario = new ComentarioModel(id: int.Parse(linha[0]), usuario: linha[1], texto: linha[2], dataCriacao: DateTime.Parse(linha[3]), status: linha[4]);//0 é o id, 1 é o texto e 2 é a data de criação
        //         if (comentario.Status == "Rejeitado")
        //         {
        //         // System.Console.WriteLine("qnt" + linha.Length);
        //         comentario.Id = int.Parse(linha[0]);
        //         comentario.Usuario.Nome = linha[1];
        //         comentario.Texto = linha[2];
        //         // comentario.Status = linha[2];
        //         comentario.DataCriacao = DateTime.Parse(linha[3]);
        //         comentario.Status = linha[4];

        //         lsComentarios.Add(comentario);
        //         }
        //     }

        //     return lsComentarios;
        // }
    }
}

// https://www.w3schools.com/bootstrap/tryit.asp?filename=trybs_modal&stacked=h