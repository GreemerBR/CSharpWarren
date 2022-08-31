using Data.Context;
using Data.Model;
using Data.Utils;

namespace Data.Respository
{
    public class UsuarioRepository : BaseRepository<Usuario>
    {
        public override string Create(Usuario entity)
        {
            entity.Senha = Criptografia.Criptografar(entity.Senha);
            return base.Create(entity);
        }

        public override string Update(Usuario entity)
        {
            entity.Senha = Criptografia.Criptografar(entity.Senha);
            return base.Update(entity);
        }

        public Usuario Logon(string email, string senha)
        {
            senha = Criptografia.Criptografar(senha);
            Usuario usuario = new Usuario();

            using (WarrenContext warrenContexto = new WarrenContext())
            {
                usuario = warrenContexto.Usarios.Where(u => u.Email == email && u.Senha == senha).FirstOrDefault();
            }

            return usuario;
        }
    }
}
