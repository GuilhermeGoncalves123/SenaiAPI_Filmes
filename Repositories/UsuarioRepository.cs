

using System.Linq;
using api_filmes_senai.Context;
using api_filmes_senai.Domains;
using api_filmes_senai.Interfaces;
using api_filmes_senai.Utilss;

namespace API_Filmes_senai.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Filmes_Context _context;

        public UsuarioRepository(Filmes_Context context)
        {
            _context = context;
        }

        public Usuario BuscarPorEmailSenha(string email, string senha)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuarios.FirstOrDefault(u =>  u.Email == email)!;
                if (usuarioBuscado != null)
                {
                   bool confere = Criptografia.ComprarHash(senha, usuarioBuscado.Senha!);
                    if (confere) { 
                    return usuarioBuscado;
                    }
                }
                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuarios.Find(id)!;
                if (usuarioBuscado == null)
                {
                    return usuarioBuscado!;
                }
                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            try
            {
                _context.Usuarios.Add(novoUsuario);

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
