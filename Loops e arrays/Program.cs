using System;
using System.Diagnostics;

namespace Loops_e_arrays
{

    // Demonstração de como funcionam loops e arrays em C#.
    // Este exemplo inclui a comparação de dois métodos de ordenação, SlowSort e FastSort,
    // para ilustrar a diferença de desempenho entre eles. Alem disso, o código demonstra
    // como manipular strings, passar arrays por referência, lidar com referências nulas e
    // tratar exceções de índice fora do intervalo. Também inclui uma função para adicionar elementos a um array.
    class Program
    {
        private static int[] array;
        // um array e declarado usando [] e pode ser inicializado com valores ou vazio.
        // Arrays são estruturas de dados que armazenam uma coleção de elementos do mesmo tipo.

        static void Main(string[] args)
        {
            ComparacaoSubOtimizada();
        }
        // A função ComparacaoSubOtimizada compara dois métodos de ordenação, SlowSort e FastSort,
        // onde SlowSort é uma implementação ineficiente e FastSort é uma implementação otimizada.
        // A função mede o tempo de execução de cada método usando Stopwatch e exibe os resultados no console.


        public static void ComparacaoSubOtimizada()
        {
            // Stopwatch é uma classe que permite medir o tempo de execução de um bloco de código.
            var sw = new Stopwatch();
            sw.Start();  

            SlowSort();

            sw.Stop();
            Console.WriteLine($"Tempo de execução do SlowSort: {sw.ElapsedMilliseconds} ms");
            sw.Reset();//Reseta o Cronometro

            sw.Start();

            FastSort();

            sw.Stop();
            Console.WriteLine($"Tempo de execução do FastSort: {sw.ElapsedMilliseconds} ms");
            sw.Reset();
        }

        
        private static void SlowSort()
        {
            //Essa função simula uma ordenação lenta, ela funciona
            // mas não é eficiente. Ela cria um array de inteiros com 2048 elementos,
            // e imprime os primeiros 100 números ordenados. A ordenação é feita de forma ineficiente,
            // onde cada elemento do array é atribuído ao seu índice, simulando uma operação de ordenação.

            int[] unsortedArray = new int[2048];
            // Inicializa o array com valores de 0 a 2047
            System.Console.WriteLine("Os primeiros 100 numeros sao: ");
            for (int i = 0; i < 99; i++)
            {
                int[] sortedArray = Sort(unsortedArray);
                System.Console.Write(sortedArray[i] + " ");
            }
        }

        private static void FastSort()
        {
            //Essa função simula uma ordenação rápida, ela funciona
            // dmesma forma que a SlowSort, mas é otimizada para ser mais eficiente

            int[] unsortedArray = new int[2048];
            System.Console.WriteLine("Os primeiros 100 numeros sao: ");
            int[] sortedArray = Sort(unsortedArray);
            for (int i = 0; i < 99; i++)
            {
                System.Console.Write(sortedArray[i] + " ");
            }
        }

        public static int[] Sort(int[] array)
        {
            // Essa função simula uma ordenação de array, mas na verdade não realiza uma ordenação real.
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int ii = 0; ii < array.Length; ii++)
                {
                    result[ii] = ii; // Simula uma operação de ordenação
                }
            }

            return result;
        }

        private void StringDemo()
        {
            // A função CapitalizeFirstV1 tenta modificar a string diretamente, mas strings são imutáveis em C#.
            var name = "otavio";
            Console.WriteLine(" Nome Antes: " + name);
            CapitalizeFirstV1(name);

            Console.WriteLine(" Nome Depois V1 : " + name);
            name = CapitalizeFirstV2(name);
            Console.WriteLine(" Nome Depois V2 : " + name);
        }

        private static void CapitalizeFirstV1(String name)
        {
            var firstLetter = name[0].ToString().ToUpper();
            name = firstLetter + name.Substring(1, name.lenght - 1);
            Console.WriteLine(" In between V1: " + name);

        }

        private static string CapitalizeFirstV2(string name)
        {
            var firstLetter = name[0].ToString().ToUpper();
            name = firstLetter + name.Substring(1, name.Length - 1);
            Console.WriteLine(" In between V2: " + name);
            return name;
        }

        private static void DemoPassByReference()
        {
            var array = new[] { 1, 2, 3 };
            SetAllElementsOfArrayTo(array, 10);
            foreach (var number in array)
            {
                Console.WriteLine(number + " ");
            }
        }

        private static void SetAllElementsOfArrayTo(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = number;
            }
        }

        private static void DemoNullReference()
        {
            Console.WriteLine(array[0]);
        }

        private static void DemoOutOfRange()
        {
            var array = new int[0];
            Console.WriteLine(array[0]);
        }

        private static void DemoAppendToArray()
        {
            // Essa função demonstra como adicionar um número a um array existente,
            // criando um novo array com tamanho aumentado. 
            // Ela imprime o array original e o novo array expandido.

            var array = new int[0];
            var expandedArray = AppendToArray(array, 10);
            Console.WriteLine(array);

            foreach (var number in expandedArray)
            {
                Console.WriteLine(number + " ");
            }
        }
        private static int[] AppendToArray(int[] array, int numberToBeAdded)
        {
            //Essa função adiciona um número a um array existente, criando um novo array com tamanho aumentado.

            var array2 = new int[array.Length + 1];
            for (var i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            array2[array2.Length - 1] = numberToBeAdded;
            return array2;
        }
    }
}

