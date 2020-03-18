using System;

namespace _02_numero_de_votos
{

    
    class Program
    {
        static void Main(string[] args)
        {
            Screens screans = new Screens();

            screans.AssembleScreensTop("Sistema de tratativa de votos!");

            Console.WriteLine("Entre com os dados abaixo!");

            Console.ForegroundColor = ConsoleColor.Green;            
            Console.Write("Votos em branco: ");
            Console.ForegroundColor = ConsoleColor.White;
            var votosBrancos = int.Parse(Console.ReadLine()); 

            Console.ForegroundColor = ConsoleColor.Green;            
            Console.Write("Votos Nulos: ");
            Console.ForegroundColor = ConsoleColor.White;
            var votosNulos = int.Parse(Console.ReadLine()); 

            Console.ForegroundColor = ConsoleColor.Green;            
            Console.Write("Votos Valido: ");
            Console.ForegroundColor = ConsoleColor.White;
            var votosValidos = int.Parse(Console.ReadLine()); 

            var totalVotos = votosBrancos + votosNulos + votosValidos;

            Console.ForegroundColor = ConsoleColor.Red;     
            Console.WriteLine();  
            Console.Write("Total de votos:                     " );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(totalVotos);    

            Console.ForegroundColor = ConsoleColor.Cyan;    
            Console.Write("Votos Valido referente ao total:    ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine((float)(votosValidos * 100) / totalVotos + " %");                
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Votos em Branco referente ao total: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine((float)(votosBrancos * 100) / totalVotos + " %");  

            Console.ForegroundColor = ConsoleColor.Cyan;         
            Console.Write("Votos Nulos referente ao total:     ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine((float)(votosNulos * 100) / totalVotos + " %");  



            screans.AssembleScreensFooter();
            
            Console.ReadKey();
            Console.ResetColor();

        }
    }
}
