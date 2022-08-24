namespace Console._1___TipoReferencia
{
    internal class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }

        public PessoaFisica(string nome, string sobrenome, string cpf) : base(nome, sobrenome)
        {
            this.Cpf = cpf;
        }
                
        public override string Saudar()
        {
            return base.Saudar() + $", seu CPF é {this.Cpf}";
        }
    }
}
