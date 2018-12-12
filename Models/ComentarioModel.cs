using System;

namespace Check_Point.Models
{
    public class ComentarioModel
    {
        public int Id { get; set; }
        public UsuarioModel Usuario { get; set; }
        public string Texto { get; set; }
        public string Status { get; set; }
        public DateTime DataCriacao { get; set; }


        public ComentarioModel(int id, string usuario, string texto, DateTime dataCriacao, string status)
        {
            this.Usuario = new UsuarioModel();
            this.Id = id;
            this.Usuario.Nome = usuario;
            this.Texto = texto;
            this.DataCriacao = dataCriacao;
            this.Status = status; 
        }
        public ComentarioModel(string texto, string usuario )//, string status, DateTime dataCriacao
        {
            this.Usuario = new UsuarioModel();
            this.Texto = texto;
            this.Usuario.Nome = usuario;
            this.DataCriacao = DateTime.Now;
        }

        public ComentarioModel(int id, string texto, DateTime dataCriacao)
        {
            this.Id = id;
            this.Texto = texto;
            this.DataCriacao = dataCriacao;
        }

        public ComentarioModel(string status)
        {
            this.Status = status; 
        }

        public ComentarioModel(){}
    }
}