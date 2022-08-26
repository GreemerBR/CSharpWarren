using Data.Model;

namespace Data.Respository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public string Create(T entity)
        {
            return "Animal criado";
        }

        public string Delete(int id)
        {
            return "Animal deletado";
        }

        public List<T> GetAll()
        {
            List<T> list = new List<T>();
            return list;
        }

        public T GetById(int id)
        {
            T model = null;
            return model;
        }

        public string Update(T entity)
        {
            return "Animal alterado";
        }
    }
}
