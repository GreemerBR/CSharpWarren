using System;

namespace Console._0___TipoValor
{
    internal class TipoNumerico
    {
        public void Executa()
        {
            // Para o C# podemos usar o tipo primitívo byte, com letra minúscula, enquanto para o .Net é melhor a classe Byte, com letra maiúscula, para entregar com outras
            //linguagens

            sbyte valor1 = 0; // Vai de -128 até 127 por conta do binário de 8 bites, com números negativos
            sbyte sBteMin = sbyte.MinValue; // Vai buscar o valor minimo possivel
            sbyte sBteMax = sbyte.MaxValue; // Vai buscar o valor máximo possivel

            System.Console.WriteLine($@"Sbyte
Min: {sBteMin}
Máx: {sBteMax}
");

            byte valor2 = 0; // Vai de 0 até 255 por conta do binário de 8 bites
            byte byteMin = Byte.MinValue; 
            byte byteMax = Byte.MaxValue;

            System.Console.WriteLine($@"Byte
Min: {byteMin}
Máx: {byteMax}
");

            short valor3 = 0; // Vai de - 32768 até 32767 por conta do binário de 16 bites, com números negativos
            short shortMin = short.MinValue;
            short shortMax = short.MaxValue;

            System.Console.WriteLine($@"Short
Min: {shortMin}
Máx: {shortMax}
");
            
            ushort valor4 = 0; // Vai de 0 até 65535 por conta do binário de 16 bites
            ushort uShortMin = ushort.MinValue;
            ushort uShortMax = ushort.MaxValue;

            System.Console.WriteLine($@"UShort
Min: {uShortMin}
Máx: {uShortMax}
");

            Int16 valor5 = 0; // Vai de - 32768 até 32767 por conta do binário de 16 bites, com números negativos
            Int16 int16Min = Int16.MinValue;
            Int16 int16Max = Int16.MaxValue;

            System.Console.WriteLine($@"Int16
Min: {int16Min}
Máx: {int16Max}
");

            UInt16 valor6 = 0; // Vai de 0 até 65535 por conta do binário de 16 bites
            UInt16 uInt16Min = UInt16.MinValue;
            UInt16 uInt16Max = UInt16.MaxValue;

            System.Console.WriteLine($@"UInt16
Min: {uInt16Min}
Máx: {uInt16Max}
");

            int valor7 = 0; // Vai de - 2147483648 até 2147483647 por conta do binário de 32 bites, com números negativos
            int intMin = int.MinValue;
            int intMax = int.MaxValue;

            System.Console.WriteLine($@"Int
Min: {intMin}
Máx: {intMax}
");

            uint valor8 = 0; // Vai de 0 até 4294967295 por conta do binário de 32 bites
            uint uIntMin = uint.MinValue;
            uint uIntMax = uint.MaxValue;

            System.Console.WriteLine($@"UInt
Min: {uIntMin}
Máx: {uIntMax}
");

            Int32 valor9 = 0; // Vai de - 2147483648 até 2147483647 por conta do binário de 32 bites, com números negativos
            Int32 int32Min = Int32.MinValue;
            Int32 int32Max = Int32.MaxValue;

            System.Console.WriteLine($@"Int32
Min: {int32Min}
Máx: {int32Max}
");

            UInt32 valor10 = 0; // Vai de 0 até 4294967295 por conta do binário de 32 bites
            UInt32 uInt32Min = UInt32.MinValue;
            UInt32 uInt32Max = UInt32.MaxValue;

            System.Console.WriteLine($@"UInt32
Min: {uInt32Min}
Máx: {uInt32Max}
");

            long valor11 = 0; // Vai de - 9223372036854775808 até 9223372036854775807 por conta do binário de 64 bites, com números negativos
            long longMin = long.MinValue;
            long longMax = long.MaxValue;

            System.Console.WriteLine($@"Long
Min: {longMin}
Máx: {longMax}
");

            ulong valor12 = 0; // Vai de 0 até 18446744073709551615 por conta do binário de 64 bites
            ulong uLongMin = ulong.MinValue;
            ulong uLongMax = ulong.MaxValue;

            System.Console.WriteLine($@"ULong
Min: {uLongMin}
Máx: {uLongMax}
");

            Int64 valor13 = 0; // Vai de - 9223372036854775808 até 9223372036854775807 por conta do binário de 64 bites, com números negativos
            Int64 int64Min = Int64.MinValue;
            Int64 int64Max = Int64.MaxValue;

            System.Console.WriteLine($@"Int64
Min: {int64Min}
Máx: {int64Max}
");

            UInt64 valor14 = 0; // Vai de 0 até 18446744073709551615 por conta do binário de 64 bites
            UInt64 uInt64Min = UInt64.MinValue;
            UInt64 uInt64Max = UInt64.MaxValue;

            System.Console.WriteLine($@"UInt64
Min: {uInt64Min}
Máx: {uInt64Max}
");
        }
    }
}
