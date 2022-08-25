using Console._1___TipoReferencia.Animais;
using Console._1___TipoReferencia.Pessoas;
using Console._1___TipoReferencia.Produtos;

namespace Console._1___TipoReferencia
{
    internal class Testes
    {
        public static void ExecutaPessoa()
        {
            /* 
             * Neste caso criamos objetos Pessoas baseados em PessoasFisica e PessoasJuridica
             * não vamos conseguir pegar as propriedades das classes filho, mas os métodos sobrescritos sim
             */
            Pessoa pessoa = new Pessoa("Gregory", "Zimmer");
            Pessoa pessoaF = new PessoaFisica("Michel", "Konig", "09492200945");
            Pessoa pessoaJ = new PessoaJuridica("Warren", "Investimentos", "12345678000199");

            /*
             * Foi necessário criar uma nova PessoaFisica e PessoaJuridica, passando as criadas anteriormente
             * utilizando uma conversão explicita para poder utilizar as propriedades que as filhas possuem
             */
            PessoaFisica pessoaF2 = (PessoaFisica)pessoaF;
            PessoaJuridica pessoaJ2 = (PessoaJuridica)pessoaJ;

            /*
             * Como dito ali em cima, aqui ele consegue pegar os métodos das PessoasFisica e Juridica
             * porque são sobrescrições do método que consta em Pessoa;
             */
            System.Console.WriteLine(pessoa.Saudar());
            System.Console.WriteLine(pessoaF.Saudar());
            System.Console.WriteLine(pessoaJ.Saudar());

            BaseRepository<Pessoa> repo = new BaseRepository<Pessoa>();
            repo.Creat(pessoa);
            repo.Creat(pessoaF2);
            repo.Creat(pessoaJ2);

            foreach (var p in repo.Read())
            {
                System.Console.WriteLine(p.Saudar());
            }

        }
        public static void ExecutaFisica()
        {
            var pessoaFisica1 = new PessoaFisica("Gregory", "Zimmer", "08561161906");
            var pessoaFisica2 = new PessoaFisica("Michel", "Konig", "09492200945");

            var pessoaFisicaRepository = new BaseRepository<Pessoa>();
            var msg1 = pessoaFisicaRepository.Creat(pessoaFisica1);
            System.Console.WriteLine(msg1);
            var msg2 = pessoaFisicaRepository.Creat(pessoaFisica2);
            System.Console.WriteLine(msg2);

            var pessoasFisicas = pessoaFisicaRepository.Read();
            foreach (var pessoaFisica in pessoasFisicas)
            {
                System.Console.WriteLine(pessoaFisica.Saudar());
            }

            System.Console.ReadLine();
        }
        public static void ExecutaJuridica()
        {
            var pessoaJuridica1 = new PessoaJuridica("Warren", "Invest", "12345678000122");
            var pessoaJuridica2 = new PessoaJuridica("Outro", "Invest", "12345678000125");

            var pessoaJuridicaRepository = new BaseRepository<Pessoa>();
            var msg3 = pessoaJuridicaRepository.Creat(pessoaJuridica1);
            System.Console.WriteLine(msg3);
            var msg4 = pessoaJuridicaRepository.Creat(pessoaJuridica2);
            System.Console.WriteLine(msg4);

            var pessoasJuridicas = pessoaJuridicaRepository.Read();
            foreach (var pessoaJuridica in pessoasJuridicas)
            {
                System.Console.WriteLine(pessoaJuridica.Saudar());
            }

            System.Console.ReadLine();
        }
        public static void ExecutaProduto()
        {
            var produto1 = new Produto("Boneco Ben 9", "Um boneco muito louco com 10 formas diferentes");

            var produtoRepository = new BaseRepository<Produto>();

            produtoRepository.Creat(produto1);

            var produtos = produtoRepository.Read();

            foreach (var produto in produtos)
            {
                System.Console.WriteLine(produto.Comprar());
            }

            System.Console.ReadLine();
        }
        public static void ExecutaAnimal()
        {
            var animal1 = new Animal("Clotilde", "Roedor", "Ratazana");

            var animalRepository = new BaseRepository<Animal>();

            animalRepository.Creat(animal1);

            var animais = animalRepository.Read();

            foreach (var animal in animais)
            {
                System.Console.WriteLine(animal.Comer());
            }

            System.Console.ReadLine();
        }
    }
}
