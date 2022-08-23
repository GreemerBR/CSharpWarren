namespace Console
{
    internal class BemVindo
    {
        // Passo argumentos e recebo parâmetros
        // Esse método não tem parâmetros, então quando chamado não receberá nenhum argumento
        public static void Mensagem()
        {
            System.Console.WriteLine("Seja bem-vindo! \n");
            System.Console.Write("Digite seu nome: ");
            string nome = System.Console.ReadLine();
            System.Console.WriteLine($"\n Olá {nome}");
            System.Console.ReadLine();
        }
    }
}
