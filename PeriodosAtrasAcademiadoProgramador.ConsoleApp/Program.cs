using System;

namespace PeriodosAtrasAcademiadoProgramador.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime date_1 = ObterDataPeriodoAtras();
            DateTime date_2 = ObterDataAtual();

            TimeSpan Diff_dates = date_2.Subtract(date_1);

            Console.WriteLine();
            busqueExtenso(Diff_dates.Days, " e ");
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine();
            ApresentarMensagem("Diferença em Dias ==> " + Diff_dates.Days + " dias.", ConsoleColor.Green);
            Console.WriteLine();
            ApresentarMensagem("Exato TimeSpan nos Dias ==> " + Diff_dates.Days + " dias, " + Diff_dates.Hours + " Horas, " + Diff_dates.Minutes + " Minutos e " + Diff_dates.Seconds + " Segundos.", ConsoleColor.Green);
        }

        static DateTime ObterDataAtual()
        {

            DateTime dataatual;

            dataatual = DateTime.Now;

            return dataatual;
        }

        static DateTime ObterDataPeriodoAtras()
        {

            DateTime periodoatras;
            bool periodoatrasValida;
            do
            {
                Console.Write("Digite a data para comparar com a Data de Hoje: ");
                periodoatrasValida = DateTime.TryParse(Console.ReadLine(), out periodoatras);

                if (PeriodoatrasExcedeDiaDeHoje(periodoatras))
                {
                    periodoatrasValida = false;
                    ApresentarMensagem("Data não pode ser maior que hoje.", ConsoleColor.Red);
                }

                if (!periodoatrasValida)
                    ApresentarMensagem("Data inválida. Digite uma data válida no formato 'dd/MM/aaaa'.", ConsoleColor.Red);

            } while (!periodoatrasValida);

            return periodoatras;
        }

        static bool PeriodoatrasExcedeDiaDeHoje(DateTime periodoatras)
        {
            return periodoatras > DateTime.Today;
        }

        static void ApresentarMensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        public static void busqueExtenso(int valor, string separador)
        {

            if (valor < 20)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Diferença em dias escrito ==> " + RetorneValorString(valor) + " Dias. ");
            }

            if (valor > 19)
            {
                int len = valor.ToString().Length;

                if (len == 2)
                {
                    int ValorPrimario = int.Parse(valor.ToString().Substring(0, 1));
                    int ValorSecundario = int.Parse(valor.ToString().Substring(1, 1));
                    ValorPrimario = ValorPrimario * 10;
                    Console.Write(RetorneValorString(ValorPrimario) + (ValorSecundario > 0 ? separador + RetorneValorString(ValorSecundario) : ""));
                }
                else if (len == 3)
                {
                    int ValorPrimario = int.Parse(valor.ToString().Substring(0, 1));
                    int ValorSecundario = int.Parse(valor.ToString().Substring(1, 1));
                    int ValorTerciario = int.Parse(valor.ToString().Substring(2, 1));

                    ValorPrimario = ValorPrimario * 100;
                    ValorSecundario = ValorSecundario * 10;


                    Console.Write(RetorneValorString(ValorPrimario)
                                      + (ValorSecundario > 0 ? separador + RetorneValorString(ValorSecundario) : "")
                                      + (ValorTerciario > 0 ? separador + RetorneValorString(ValorTerciario) : ""));
                }
            }

        }

        public static string RetorneValorString(int identificador)
        {
            switch (identificador)
            {
                case 1: return "Um";
                case 2: return "Dois";
                case 3: return "Tres";
                case 4: return "Quatro";
                case 5: return "Cinco";
                case 6: return "Seis";
                case 7: return "Sete";
                case 8: return "Oito";
                case 9: return "Nove";

                case 10: return "Dez";
                case 11: return "Onze";
                case 12: return "Doze";
                case 13: return "Treze";
                case 14: return "Quatorze";
                case 15: return "Quinze";
                case 16: return "Dezesseis";
                case 17: return "Dezessete";
                case 18: return "Dezoito";
                case 19: return "Dezenove";

                case 20: return "Vinte";
                case 30: return "Trinta";
                case 40: return "Quarenta";
                case 50: return "Cinquenta";
                case 60: return "Sessenta";
                case 70: return "Setenta";
                case 80: return "Oitenta";
                case 90: return "Noventa";

                case 100: return "Cem";
                case 200: return "Duzentos";
                case 300: return "Trezentos";
                case 400: return "Quatrocentos";
                case 500: return "Quinhentos";
                case 600: return "Seicentos";
                case 700: return "Setecentos";
                case 800: return "Oitocentos";
                case 900: return "Novecentos";

                default: return "Valor inválido";
            }
        }
    }
}
