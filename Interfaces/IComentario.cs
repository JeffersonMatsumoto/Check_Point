using System.Collections.Generic;
using Check_Point.Models;

namespace Check_Point.Interfaces
{
    public interface IComentario
    {
    List<ComentarioModel> Listar();
    List<ComentarioModel> ListarAtt();
    ComentarioModel Cadastrar(ComentarioModel comentario);//, UsuarioModel usuario
    
    // ComentarioModel Aprovar(string status);
    void Aprovar(int id);

    void Manter(int id);

    } 
}