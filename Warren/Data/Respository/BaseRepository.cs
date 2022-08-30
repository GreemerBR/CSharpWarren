using Data.Context;
using Data.Model;

namespace Data.Respository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual string Create(T entity)
        {
            using (WarrenContext warrenContext = new WarrenContext())
            {
                warrenContext.Set<T>().Add(entity);
                warrenContext.SaveChanges();
            }
            return "Objeto criado";
        }
        public virtual string Delete(int id)
        {
            T entity = GetById(id);

            using (WarrenContext warrenContext = new WarrenContext())
            {
                if (entity != null)
                {
                    warrenContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    warrenContext.SaveChanges();
                }

            }
            return "Objeto deletado";
        }

        public virtual List<T> GetAll()
        {
            List<T> list = new List<T>();

            using (WarrenContext warrenContext = new WarrenContext())
            {
                list = warrenContext.Set<T>().ToList();
            }

            return list;
        }

        public virtual T GetById(int id)
        {
            T entity = null;

            using (WarrenContext warrenContext = new WarrenContext())
            {
                entity = warrenContext.Set<T>().Find(id);
            }

            return entity;
        }

        public virtual string Update(T entity)
        {
            using (WarrenContext warrenContext = new WarrenContext())
            {
                warrenContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                warrenContext.SaveChanges();
            }
            return "Objeto alterado";
        }
    }
}
