using System.Collections.Generic;

namespace Console._1___TipoReferencia
{
    internal class TestarPessoas
    {
        public static void ExecutaFisica()
        {
            var pessoaFisica1 = new PessoaFisica("Gregory", "Zimmer", "08561161906");
            var pessoaFisica2 = new PessoaFisica("Michel", "Konig", "09492200945");

            var pessoaFisicaRepository = new PessoaFisicaRepository();
            var msg1 = pessoaFisicaRepository.Create(pessoaFisica1);
            System.Console.WriteLine(msg1);
            var msg2 = pessoaFisicaRepository.Create(pessoaFisica2);
            System.Console.WriteLine(msg2);

            List<PessoaFisica> pessoasFisicas = pessoaFisicaRepository.Read();
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

            var pessoaJuridicaRepository = new PessoaJurisicaRepository();
            var msg3 = pessoaJuridicaRepository.Create(pessoaJuridica1);
            System.Console.WriteLine(msg3);
            var msg4 = pessoaJuridicaRepository.Create(pessoaJuridica2);
            System.Console.WriteLine(msg4);

            List<PessoaJuridica> pessoasJuridicas = pessoaJuridicaRepository.Read();
            foreach (var pessoaJuridica in pessoasJuridicas)
            {
                System.Console.WriteLine(pessoaJuridica.Saudar());
            }

            System.Console.ReadLine();
        }
    }
}
