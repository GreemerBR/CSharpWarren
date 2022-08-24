using Console._99___Exercicios;

namespace Console._0___TipoValor
{
    internal class TestarValores
    {
        public static void Executa()
        {
            BemVindo.Mensagem(); // Chamada de método estático

            TipoNumerico TipoNumerico = new TipoNumerico();
            TipoNumerico.Executa();

            TipoNumerico2.Executa();

            _000Cadastro.Exercicio01();

            TipoNumerico3.Executa();

            TipoBooleano.Executar();

            Enumeradores.Executar();

            Enumeradores2.Executar();

            Estruturas.Executa();
        }
    }
}
