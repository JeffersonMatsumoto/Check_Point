using System.Collections.Generic;
using Check_Point.Models;

namespace Check_Point.Interfaces
{
    public interface IUsuario
    {
    List<UsuarioModel> Listar();
    UsuarioModel Cadastrar(UsuarioModel usuario);
    UsuarioModel Login(string email, string senha);
    UsuarioModel Logout();
    }
}