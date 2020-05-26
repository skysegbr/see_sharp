using System;

namespace _04_revendedora_de_carros_usados
{
    class Program
    {
        static void Main(string[] args)
        {   
            Screens.Screens screans = new Screens.Screens();

            screans.AssembleScreensTop("teste");
            Console.WriteLine("Hello World!");
        }
    }
}
