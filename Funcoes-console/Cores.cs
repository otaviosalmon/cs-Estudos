using System;

namespace Funcoes_console
{
    class ColorfulConsole
    {
        public static void Print(string menssagem, ConsoleColor newColor)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = newColor;
            Console.WriteLine(menssagem);
            Console.ForegroundColor = oldColor;
        }
    }
}

       
        
