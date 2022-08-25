namespace Console._1___TipoReferencia.Produtos
{
    internal class Produto : BaseModel
    {

        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Produto(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public virtual string Comprar()
        {
            return $"O produto: {this.Nome}, foi comprado com sucesso.";
        }
    }
}
