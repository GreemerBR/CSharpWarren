namespace Console._1___TipoReferencia
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        public virtual string Saudar()
        {
            return $"Olá {this.Nome} {this.Sobrenome}";
        }        
    }
}
