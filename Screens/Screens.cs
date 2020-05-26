using System;

namespace Screens
{
    public class Screens
                 
    {
        public void AssembleScreensTop(String message)
        {


            var sizeMessage = message.Length;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0, 1);
            Console.Write("------------------------------------------------------------");
            
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Math.Abs((60 - sizeMessage) / 2) , 2);
            Console.Write(message); 

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("------------------------------------------------------------");
            
            
            
            
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Hello World!");


            //Console.WriteLine((char)197);
            //Console.WriteLine((char)170);

            //Console.WriteLine("╔═╗");
            //Console.WriteLine("╚═╝");
            //Console.ReadKey();
            Console.ResetColor();

        }

        public void AssembleScreensFooter()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.ResetColor();

        }
    }

}
