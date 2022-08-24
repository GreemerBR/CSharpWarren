namespace Console._1___TipoReferencia
{
    internal class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }

        public PessoaJuridica(string nome, string sobrenome, string cnpj) : base(nome, sobrenome)
        {
            this.Cnpj = cnpj;
        }

        public override string Saudar()
        {
            return base.Saudar() + $", seu CNPJ é {this.Cnpj}";
        }
    }
}
