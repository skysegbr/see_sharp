using System;

namespace _01_idade_pessoa
{
    class Program
    {
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        static void Main(string[] args)
        {
            String idade = "";


            Console.Clear();
            Console.Write("Entre com a idade: ");
            Console.SetCursorPosition(19, 0);

            while (true)
            {
                var k = Console.ReadKey().Key.ToString();
                idade += k;
                var p = Console.CursorLeft;
                if ((p == 21) || (p == 24))
                {
                    Console.Write("/");
                }

                if (p >= 29)
                {
                    break;
                }
            }

            Console.SetCursorPosition(0, 2);
            idade = idade.Replace("D", "");
            var dia = int.Parse(idade.Substring(0, 2));


            dia = 30 - dia;

            dia += (int.Parse(idade.Substring(2, 2)) * 30);
            var ano = int.Parse(idade.Substring(4, 4));
            var anoAtual = int.Parse(DateTime.Now.ToString("yyyy"));

            dia += (anoAtual - ano) * 365;

            var diaAtual = int.Parse(DateTime.Now.ToString("dd"));
            dia += diaAtual;


            Console.WriteLine("Ano de nascimento: " + ano);
            Console.WriteLine("Ano atual:         " + anoAtual);
            Console.WriteLine("Sua idade em anos: " + (anoAtual - ano));
            Console.WriteLine("Sua Idade em dias: " + dia);

            Console.ReadKey();
        }
    }
}
