namespace Console._0___TipoValor
{
    internal class TipoNumerico2
    {
        public static void Executa()
        {
            char letra = 'A';
            char charMin = char.MinValue;
            char charMax = char.MaxValue;

            System.Console.WriteLine($@"Char
Min: {charMin}
Máx: {charMax}
{letra}
Letra A no ASC: {(byte)letra}
");
        }
    }
}
