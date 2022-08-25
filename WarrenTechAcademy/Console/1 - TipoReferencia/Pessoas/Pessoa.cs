namespace Console._1___TipoReferencia.Pessoas
{
    internal class Pessoa : BaseModel
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public virtual string Saudar()
        {
            return $"Olá {this.Nome} {this.Sobrenome}.";
        }        
    }
}
