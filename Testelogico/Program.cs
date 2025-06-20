using System;

namespace Testelogico;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite quantos eventos deseja gerar: ");
            var n = int.Parse(Console.ReadLine());
            int[] eventos = new int[n];

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                eventos[i] = rnd.Next(0, 100); 
            }
            int bateria = 50;

            for (int i = 0; i < eventos.Length; i++)
            {
                if (i % 2 == 0)
                {
                 bateria += eventos[i];
                }
                else
                {
                    bateria -= eventos[i];
                }
                bateria = Math.Max(0, Math.Min(100, bateria));
                Console.WriteLine("Bateria atual = " + bateria + "%");
            }
            Console.WriteLine("Bateria final = " + bateria + "%");
        
        }
        
            
                
       }


    


