using System.Collections.Generic;
using System.IO;
using Check_Point.Controllers;
using Check_Point.Interfaces;
using Check_Point.Models;

namespace Check_Point.Repositorios
{
    public class UsuarioRepositorio : IUsuario
    {
        public UsuarioModel Cadastrar(UsuarioModel usuario)
        {
            if (File.Exists("usuarios.csv"))
            {
                usuario.Id = File.ReadAllLines("usuarios.csv").Length + 1;
            } else {
                usuario.Id = 1;
            }

            using(StreamWriter sw = new StreamWriter("usuarios.csv", true)){
                if (string.IsNullOrEmpty(usuario.Nome) || string.IsNullOrEmpty(usuario.Email) || string.IsNullOrEmpty(usuario.Senha))
                {
                    return null;
                }else{
                    sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha}");
                }
            }

            return usuario;         
        }

        public List<UsuarioModel> Listar()
        {
           List<UsuarioModel> lsUsuarios = new List<UsuarioModel>();
            string[] linhas = System.IO.File.ReadAllLines("usuarios.csv");

            UsuarioModel usuario;

            foreach (var item in linhas)
            {
                
                if (string.IsNullOrEmpty(item)){
                    continue;
                }
                
                string[] linha = item.Split(";");
                usuario = new UsuarioModel(id: int.Parse(linha[0]), nome: linha[1], email: linha[2], senha: linha[3]);

                usuario.Id = int.Parse(linha[0]);

                usuario.Nome = linha[1];
                usuario.Email = linha[2];
                usuario.Senha = linha[3];

                lsUsuarios.Add(usuario);
                
            }

            return lsUsuarios;
        }

        public UsuarioModel Login(string email, string senha)
        {
            using (StreamReader sr = new StreamReader ("usuarios.csv")) {
                while (!sr.EndOfStream) {
                    var linha = sr.ReadLine ();

                    if (string.IsNullOrEmpty(linha))
                    {
                        continue;
                    }

                    string[] dados = linha.Split (";");

                    if (dados[2] == email && dados[3] == senha) {
                        UsuarioModel usuario = new UsuarioModel(
                            id: int.Parse (dados[0]),
                            nome: dados[1],
                            email: dados[2],
                            senha: dados[3]
                        );
                        // administrador = false;
                        // string emailCadastro;
                        // emailCadastro = dados[2];

                        // string senhaCadastro;
                        // senhaCadastro = dados[3];
                        // UsuarioController usuarioController = new UsuarioController();
                        // usuarioController.Login(emailCadastro, senhaCadastro);
                        return usuario;
                    }
                }
            }
            return null;
        }

        public UsuarioModel Logout()
        {
            throw new System.NotImplementedException();
        }
    }
}