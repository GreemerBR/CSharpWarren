namespace Console._0___TipoValor
{
    internal class Estruturas
    {
        public static void Executa()
        {
            var p1 = new PessoaClasse();
            p1.Nome = "Chimbinha";
            System.Console.WriteLine(p1.Nome);

            var p2 = new PessoaStruct();
            p2.Nome = "Jojo";
            System.Console.WriteLine(p2.Nome);
            
            var p3 = new PessoaClasse();
            p3 = p1;
            System.Console.WriteLine(p3.Nome);

            var p4 = new PessoaStruct();
            p4 = p2;
            System.Console.WriteLine(p4.Nome);

            p1.Nome = "Chimbinha, melhor guitarrusta do mundo";
            p2.Nome = "Jojo melhor dançarina > Shakira";

            System.Console.WriteLine("\nValores alterados:");
            System.Console.WriteLine(p1.Nome);
            System.Console.WriteLine(p2.Nome);
            System.Console.WriteLine(p3.Nome);
            System.Console.WriteLine(p4.Nome);
        }
    }

    struct PessoaStruct
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public byte Idade { get; set; }
    }

    class PessoaClasse
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public byte Idade { get; set; }

        // Se não fizesse como foi feito acima, teria que ser feito da forma abaixo
        //private string nome;
        //private string sobrenome;
        //private byte idade;

        //public string GetNome()
        //{
        //    // this pq está falando do parâmetro nome dessa classe
        //    return this.nome;
        //}

        //public void SetNome(string nome)
        //{
        //    this.nome = nome;
        //}
    }
}
