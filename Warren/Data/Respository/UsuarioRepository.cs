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
    }
}
