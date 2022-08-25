using System.Collections.Generic;

namespace Console._1___TipoReferencia
{
    internal interface IRepository<T>
    {
        string Creat(T objeto);
        List<T> Read();
        string Update(T objeto);
        string Delete(int id);
    }
}
