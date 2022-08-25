using System.Collections.Generic;

namespace Console._1___TipoReferencia
{
    internal class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        List<T> objetos;

        public BaseRepository()
        {
            this.objetos = new List<T>();
        }

        public virtual string Creat(T objeto)
        {
            this.objetos.Add(objeto);
            return $"O dado de id: {objeto.Id} foi salvo com sucesso!";
        }

        public virtual string Delete(int id)
        {
            this.objetos.RemoveAt(id);
            return $"O dado de id: {id} foi deletado com sucesso!";
        }

        public virtual List<T> Read()
        {
            return objetos;
        }

        public virtual string Update(T objeto)
        {
            return $"O dado de id: {objeto.Id} foi alterado com sucesso!";
        }
    }
}
