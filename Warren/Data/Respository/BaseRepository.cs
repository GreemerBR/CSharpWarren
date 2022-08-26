using Data.Context;
using Data.Model;

namespace Data.Respository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual string Create(T entity)
        {
            using (WarrenContext warrencontext = new WarrenContext())
            {
                warrencontext.Set<T>().Add(entity);
                warrencontext.SaveChanges();
            }
            return "Objeto criado";
        }
        public virtual string Delete(int id)
        {
            T entity = GetById(id);

            using (WarrenContext warrencontext = new WarrenContext())
            {
                warrencontext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                warrencontext.SaveChanges();
            }
            return "Objeto deletado";
        }

        public virtual List<T> GetAll()
        {
            List<T> list = new List<T>();

            using (WarrenContext warrencontext = new WarrenContext())
            {
                list = warrencontext.Set<T>().ToList();
            }

            return list;
        }

        public virtual T GetById(int id)
        {
            T entity = null;

            using (WarrenContext warrencontext = new WarrenContext())
            {
                entity = warrencontext.Set<T>().Find(id);
            }

            return entity;
        }

        public virtual string Update(T entity)
        {
            using (WarrenContext warrencontext = new WarrenContext())
            {
                warrencontext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                warrencontext.SaveChanges();
            }
            return "Objeto alterado";
        }
    }
}
