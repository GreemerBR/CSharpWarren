namespace Console._99___Exercicios
{
    internal class _000Cadastro
    {
        /* Crie um sistema de cadastro de pessoas
         * 1 - O sistema deve exibir uma mensagem de boas vindas
         * 2 - Deve solicitar as seguintes informações ao usuário:
         *  Nome, Sobrenome e Idade
         * 3 - Ao fim da execução, deve exibir o nome completo e idade, juntamente com mensagem de desperida
         */

        public static void Exercicio01()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Green;
            System.Console.Write(@"Olá, bem vindo ao sistema de cadastro de usuário!

Por favor, informe seu nome: ");
            string nome = System.Console.ReadLine();
            System.Console.Write("Por favor, informe seu sobrenome: ");
            string sobrenome = System.Console.ReadLine();
            System.Console.Write("Por favor, informe a sua idade: ");
            byte idade = System.Convert.ToByte(System.Console.ReadLine());

            System.Console.Clear();

            System.Console.ForegroundColor = System.ConsoleColor.Blue;
            System.Console.WriteLine($@"
Cadastro realizado com sucesso:

Nome completo: {nome} {sobrenome}, Idade: {idade}

Agradecemos sua preferencia em realizar seu cadastro conosco! Tenha um ótimo dia.");
        }
    }
}
