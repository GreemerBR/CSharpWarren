namespace Console._0___TipoValor
{
    internal class TipoNumerico3
    {
        public static void Executa()
        {
            // Vai de -3,402823E+38 até 3,402823E+38
            float floatMin = float.MinValue;
            float floatMax = float.MaxValue;

            System.Console.WriteLine($@"Float
Min: {floatMin}
Máx: {floatMax}
");

            // Vai de -1,79769313486232E+308 até 1,79769313486232E+308 
            double doubleMin = double.MinValue;
            double doubleMax = double.MaxValue;

            System.Console.WriteLine($@"Double
Min: {doubleMin}
Máx: {doubleMax}
");

            // Vai de -79228162514264337593543950335 até 79228162514264337593543950335, utilizado para monetários
            decimal decimalMin = decimal.MinValue;
            decimal decimalMax = decimal.MaxValue;

            System.Console.WriteLine($@"Decimal
Min: {decimalMin}
Máx: {decimalMax}
");

            //  Exemplos
            double n1 = 10.10;
            double n2 = 20.20;
            double result1 = 30.30;

            System.Console.WriteLine($"{n1 + n2} - {result1}");
            System.Console.WriteLine($"{n1 + n2 == result1}\n");
            
            // Tem que usar esse m para informar que a gente está trabalhando com um número decimal
            decimal n3 = 10.10m;
            decimal n4 = 20.20m;
            decimal result2 = 30.30m;

            System.Console.WriteLine($"{n3 + n4} - {result2}");
            System.Console.WriteLine($"{n3 + n4 == result2}\n");
            
            // Tem que usar esse f para informar que a gente está trabalhando com um número decimal
            float n5 = 10.10f;
            float n6 = 20.20f;
            float result3 = 30.30f;

            System.Console.WriteLine($"{n5 + n6} - {result3}");
            System.Console.WriteLine($"{n5 + n6 == result3}\n");
        }
    }
}
