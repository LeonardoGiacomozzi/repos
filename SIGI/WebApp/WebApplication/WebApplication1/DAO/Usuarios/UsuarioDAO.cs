using SIGI.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.DAO.Usuarios
{
    public class UsuarioDAO
    {
        public void Adiciona(Usuario usuario)
        {
            using (var context = new SIGIContext())
            {
                context.Usuario.Add(usuario);
                context.SaveChanges();
            }
        }

        public IList<Usuario> Listar()
        {


            using (var context = new SIGIContext())
            {
                var lista = context.Usuario.ToList();
                var adm = lista.First();
                lista.Remove(adm);
                return lista;
            }


        }



        public Usuario Buscar(Usuario usuario)
        {
            using (var context = new SIGIContext())
            {
                Usuario usuarioBanco = context.Usuario.FirstOrDefault((u => u.Login == usuario.Login));
                if(usuarioBanco!=null) {
                    return (usuario.Senha == usuarioBanco.Senha ? usuarioBanco : null);
                }
                return null;
            }
        }
        public Usuario BuscarPorId(int id)
        {
            using (var context = new SIGIContext())
            {
                Usuario usuarioBanco = context.Usuario.FirstOrDefault((u => u.ID == id));
                if (usuarioBanco != null)
                {
                    return usuarioBanco;
                }
                return null;
            }
        }



        public void Alterar(Usuario usuario)
        {


            using (var context = new SIGIContext())
            {
                Usuario usuarioBanco = context.Usuario.FirstOrDefault(u => u.ID == usuario.ID);
                usuarioBanco.Login = (usuario.Login != null ? usuario.Login : usuarioBanco.Login);
                usuarioBanco.Senha = (usuario.Senha != null ? usuario.Senha : usuarioBanco.Senha);
                usuarioBanco.Status = usuario.Status;


                context.SaveChanges();
            }


        }

        public void Deletar(int id)
        {
            using (var context = new SIGIContext())
            {
                var usuario = context.Usuario.Find(id);
                context.Usuario.Remove(usuario);
                context.SaveChanges();

            }
        }

        public IList<EStatus> ListaStatos() {

            List<EStatus> status = new List<EStatus>();
            status.Add(EStatus.Administrador);
            status.Add(EStatus.Funcionario);
            return status;
        }
    }
}