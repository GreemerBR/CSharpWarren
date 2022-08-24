using System.Collections.Generic;

namespace Console._1___TipoReferencia
{
    internal class BaseRepository : IRepositorycs
    {
        List<Pessoa> pessoas;

        public BaseRepository()
        {
            this.pessoas = new List<Pessoa>();
        }

        public string Creat(Pessoa pessoa)
        {
            this.pessoas.Add(pessoa);
            return $"Pessoa: {pessoa.Nome} {pessoa.Sobrenome} foi salva com sucesso!";
        }

        public string Delete(int id)
        {
            this.pessoas.RemoveAt(id);
            return $"Pessoa física de id: {id} foi deletada com sucesso!";
        }

        public List<Pessoa> Read()
        {
            return pessoas;
        }

        public string Update(Pessoa pessoa)
        {
            return $"Pessoa: {pessoa.Nome} {pessoa.Sobrenome} foi alterada com sucesso!";
        }
    }
}
