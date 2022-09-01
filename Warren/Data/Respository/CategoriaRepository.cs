using Data.Context;
using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Respository
{
    public class CategoriaRepository : BaseRepository<Categoria>
    {
        public override List<Categoria> GetAll()
        {
            List<Categoria> list = new List<Categoria>();

            using (WarrenContext warrenContext = new WarrenContext())
            {
                list = warrenContext.Categorias.Include("Produtos").ToList();
            }

            return list;
        }
    }
}
