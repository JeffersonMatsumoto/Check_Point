using System;

namespace Check_Point.Models
{
    // [Serializable]
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        // public bool Administrador { get; set; }
        public string Tipo { get; set; }//adm ou user
        // public string Sexo { get; set; }
        public UsuarioModel()
        {

        }

        // public UsuarioModel(string sexo)
        // {
        //     this.Sexo = sexo;
        // }

        // public UsuarioModel(string nome)
        // {
        //     this.Nome=nome;
        // }

        public UsuarioModel(string nome, string email, string senha, string tipo)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Tipo = Tipo;
        }
        
        public UsuarioModel(int id, string nome, string email, string senha)//,bool administrador
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            // this.Administrador = administrador;
        }
    }
}