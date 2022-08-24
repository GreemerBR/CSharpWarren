using System;

namespace Console._0___TipoValor
{
    internal class TipoBooleano
    {
        public static void Executar()
        {
            // Vai ser true ou false
            bool gostaDeHarryPotter = true;
            Boolean gostaDeSenhorDosAneis = false;

            bool ehMaior = 10 > 11;
            bool ehIgual = 10 + 11 == 21;

            System.Console.WriteLine($@"Bool
10 > 11 ? {ehMaior}
10 + 11 = 21 ? {ehIgual}
");

            if (ehMaior)
            {
                System.Console.WriteLine("10 é maior que 11? Sim");
            }
            else
            {
                System.Console.WriteLine("10 é maior que 11? Não");
            }
        }
    }
}
