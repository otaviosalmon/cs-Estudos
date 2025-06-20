using System;

namespace ifs
{
    class Ifs
    {
        

            static void Main(string[] args)
            {
                Console.WriteLine("Insira uma idade: \n");
                var input = Console.ReadLine();

                // Puxa seu valor da funcao ParseAge
                var age = ParseAge(input);

                string ageValue;
                if (age == -1)
                {
                    ageValue = "invalid";
                }
                else
                {
                    ageValue = age.ToString();
                }

                Console.WriteLine("Age is " + ageValue);

                //& é usado para operações bit a bit
                //que são operações usando numeros binários.
                //e tableas verdade, ele e o operador lógico "E"
                // && é o operador AND lógico, que avalia
                // se ambas as condições são verdadeiras.

                if (Check1() && Check2())
                {
                    //..
                }

                

                Console.WriteLine("------------");

                // Prints check1 and check2
                if (Check1() & Check2())
                {
                    // ..
                }

                bool result = true;
                result = !result;
                Console.WriteLine(result);

            }

            static bool Check1()
            {
                Console.WriteLine("Check1");
                return false;
            }
            // check 1 sera retornado no primeiro if
            // pois o operador && para de avaliar assim que encontra um false


            static bool Check2()
            {
                Console.WriteLine("Check2");
                return true;
            }
            // sera retornado check 1 e check 2 no segundo if
            // pois o operador & avalia ambas as condições
            // mesmo que uma delas seja falsa, 
            // ele ira avaliar bit a bit e retornar o resultado

            static int ParseAge(string input)
            {
                var isNumber = int.TryParse(input, out var age);
                // o TryParse tenta converter a string em um inteiro
                // e retorna true se a conversao for bem sucedida
                // e coloca o valor convertido na variavel age

                // se poder termine uma funcao rapidamente
                // se for uma linha de codigo
                // nao e necessario usar chaves
                if (!isNumber) return -1;
                bool isValidAge = age < 200 && age >= 0;
                if (!isValidAge) return -1;

                return age;
            }

    }

}

       
    


