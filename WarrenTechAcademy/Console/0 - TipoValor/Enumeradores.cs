namespace Console._0___TipoValor
{
    internal class Enumeradores
    {
        public static void Executar()
        {
            System.Console.WriteLine("Dias da semana: ");
            System.Console.WriteLine($"{DiasDaSemana.DOM} {(byte)DiasDaSemana.DOM}");
            System.Console.WriteLine($"{DiasDaSemana.SEG} {(byte)DiasDaSemana.SEG}");
            System.Console.WriteLine($"{DiasDaSemana.TER} {(byte)DiasDaSemana.TER}");
            System.Console.WriteLine($"{DiasDaSemana.QUA} {(byte)DiasDaSemana.QUA}");
            System.Console.WriteLine($"{DiasDaSemana.QUI} {(byte)DiasDaSemana.QUI}");
            System.Console.WriteLine($"{DiasDaSemana.SEX} {(byte)DiasDaSemana.SEX}");
            System.Console.WriteLine($"{DiasDaSemana.SAB} {(byte)DiasDaSemana.SAB} \n");

            DiasDaSemana seg = DiasDaSemana.SEG;
            System.Console.WriteLine(seg);
            DiasDaSemana ter = (DiasDaSemana)2;
            System.Console.WriteLine(ter);
        }
    }

    public enum DiasDaSemana
    {
        DOM,
        SEG,
        TER,
        QUA,
        QUI,
        SEX,
        SAB
    }
}
