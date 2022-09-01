using Data.Context;
using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Respository
{
    public class ProdutoRepository : BaseRepository<Produto>
    {
        public override List<Produto> GetAll()
        {
            List<Produto> list = new List<Produto>();

            using(WarrenContext warrenContext = new WarrenContext())
            {
                list = warrenContext.Produtos.Include("Categoria").ToList();
            }

            return list;
        }
    }
}
