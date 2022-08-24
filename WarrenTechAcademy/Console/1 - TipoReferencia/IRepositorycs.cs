using System.Collections.Generic;

namespace Console._1___TipoReferencia
{
    internal interface IRepositorycs
    {
        string Creat(Pessoa pessoa);
        List<Pessoa> Read();
        string Update(Pessoa pessoa);
        string Delete(int id);
    }
}
