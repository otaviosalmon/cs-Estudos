using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Running;

namespace Strings
{

    //Este programa demonstra várias operações com strings
    // como concatenação, comparação, formatação, manipulação de substrings, 
    // e manipulação de arrays de strings. Ele também inclui exemplos de desempenho
    // entre o uso de StringBuilder e concatenação direta de strings
    class Program
    {
        static void Main(string[] args)
        //BenchmarkDotNet é uma biblioteca para medir o desempenho de código C#.
        // BenchmarkRunner.Run(typeof(Program).Assembly) executa todos os benchmarks definidos no assembly atual.
        // typeof(Program).Assembly  o assembly onde a classe Program está definida,
        // o assembly é um arquivo compilado que contém código executável e metadados.
        // para ele rodar  corretamente voce precisa declarar os benchmarks
        // com o atributo [Benchmark] e adicionar a referência ao pacote BenchmarkDotNet.
        // neste codigo ele não ira rodar os benchmarks.

        {
            BenchmarkRunner.Run(typeof(Program).Assembly);
        }
       
        public static void DemoStringConcat()
        // essa função demonstra a diferença de desempenho entre o uso de
        // StringBuilder e a concatenação direta de strings.
        //StringBuilder é uma classe que permite construir strings de forma eficiente
        // ela funciona como um buffer dinâmico que pode ser modificado sem criar
        // novas instâncias de string a cada modificação, enquanto a concatenação direta
        // cria novas instâncias de string a cada operação, o que pode ser ineficiente.


        {
            var sw = new Stopwatch();
            sw.Start();
            var sb = new StringBuilder();
            for (var i = 0; i < 100000; i++)
            {
                sb.Append("TESTANDO STRING ");
            }

            sw.Stop();
            var elapsed1 = sw.ElapsedMilliseconds; // 5ms

            sw.Reset();

            sw.Start();
            var s = "";
            for (var i = 0; i < 100000; i++)
            {
                s += "TESTANDO STRING ";
            }   
            sw.Stop();
            var elapsed2 = sw.ElapsedMilliseconds; // 32765 ms

            Console.WriteLine($"StringBuilder levou {elapsed1}ms, String levou {elapsed2}ms.");
        }

        public static void DemoSubstring()
        {
            var word = "Olá mundo!";

            string result;
            result = word.Substring(4); // mundo!
            Console.WriteLine($"word.Substring(4)={result}");
            result = word.Substring(0, 3); // Olá
            Console.WriteLine($"word.Substring(0, 3)={result}");
            result = word[..3]; // Olá
            Console.WriteLine($"word[..3]={result}");
            result = word[4..]; // mundo! 
            Console.WriteLine($"word[4..]={result}");
            result = word[..^1]; // Olá mundo
            // o mesmo que word.Length -1 == ^1
            Console.WriteLine($"word[..^1]={result}");
            result = word[^1..]; // !
            Console.WriteLine($"word[^1..]={result}");
            // lá mund!
            Console.WriteLine($"word[1..^1]={word[1..^1]}");

            var numbers = new[] { 1, 2, 3 };
            var lessNumbers = numbers[..^1];
        }
        public static void DemoStringCompare()
        {
            // ordena os nomes em ordem alfabética.

            var a = "a";
            var b = "b";

            var aToB = a.CompareTo(b); // -1
            if (aToB == -1)
            {
                Console.WriteLine("a < b");
            }
            var bToA = b.CompareTo(a); // 1
            if (bToA == 1)
            {
                Console.WriteLine("b > a");
            }

            const string A = "A";
            var aToA = a.CompareTo(A); // 0
            if (aToA == 0)
            {
                Console.WriteLine("a == A");
            }

            const string name1 = "Kaisinel";
            const string name2 = "Julian";
            var name1ToName2 = name1.CompareTo(name2); // 0

            const string smile = "😀";
            const string laughing = "😁";

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Compare(smile, laughing);

            Compare("cc", "ccc");
        }
        private static void Compare(string word1, string word2)
        // Compara duas strings e imprime o resultado da comparação.
        {
            var word1ToWord2 = word1.CompareTo(word2);
            // CompareTo é um método que compara duas strings e retorna um inteiro.
            // Se o primeiro argumento for menor que o segundo, retorna um valor negativo.
            // Se forem iguais, retorna zero. Se o primeiro for maior que o segundo, retorna um valor positivo.
            // Ele é nativo do c#
            switch (word1ToWord2)
            {
                case -1:
                    Console.WriteLine($"{word1} < {word2}");
                    break;
                case 0:
                    Console.WriteLine($"{word1} == {word2}");
                    break;
                case 1:
                    Console.WriteLine($"{word1} > {word2}");
                    break;
            }
        }
        public static void DemoJoinReplace()
        {
            var arr = new[] { "João", "Maria", "Jenkins", "Ada" };

            //arr.Join()// - não faça assim.
            //O Join é usado para juntar todos os elementos do array
            // neste caso ele ira separar cada elemento usando a ,

            var joined = string.Join(',', arr); // João,Maria,Jenkins,Ada
            Console.WriteLine($"string.Join(',', arr)={joined}");
            joined = joined.Replace(",", ", "); // João, Maria, Jenkins, Ada
            Console.WriteLine($"joined.Replace(\",\", \", \")={joined}");
            arr = joined.Split(", "); // { "João", "Maria", "Jenkins", "Ada" }
            Console.WriteLine($"joined.Split(\", \")={joined}");
            joined = $"Nomes das pessoas: {joined}."; // Nomes das pessoas: João, Maria, Jenkins, Ada.
            Console.WriteLine(joined);
        }
        public static void DemoFormatting()
        {
            const string name = "Tom";
            const string profession = "Bombeiro";
            var sentence = "Esta pessoa é " + name + ", sua profissão é " + profession;
            // nao exiba deste jeito acima

            //exiba deste jeito abaixo
            var sentence2 = $"Esta pessoa é {name,-20}, sua profissão é {profession,20}.";

            var sentence3 = string.Format("Esta pessoa é {0,-20}, sua profissão é {1, 20}.", name, profession);
            // string.Format cria uma string formatada subistituindo {} por valores das variaveis
            // com opções de alinhamento e formatação, aqui {0,-20} ira inserir o valor da variavel nome
            // alinhado a esquerda em um campo de 20 caracteres e {1,20} ira fazer a direita
            // a saida sera Esta pessoa é Tom                 , sua profissão é         Bombeiro.
            Console.WriteLine(sentence);
            Console.WriteLine(sentence2);
            Console.WriteLine(sentence3);



            // float
            // . vs ,nl-NL  en-IN  Invariant
            var a = 1;
            var b = 12345.1230;
            string wordF, wordN, wordC, wordP;

            //CultureInfo.CurrentCulture é uma propriedade que define a cultura atual
            //do ambiente de execução. Por exemplo, ela pode ser usada para formatar números,
            //datas e moedas de acordo com as convenções culturais específicas.
            // neste caso foi declarado como dos paises baixos

            CultureInfo.CurrentCulture = new CultureInfo("nl-NL");
            wordF = $"{b:F5}"; // 12345,12300 // ponto flutuante com 5 casas
            wordN = $"{b:N5}"; // 12.345,12300 // número de milhas com 5 casas decimais
            wordC = $"{b:C5}"; // € 12.345,1230 // moeda com 5 casas decimais
            wordP = $"{b:P5}"; // 1.234.512.30000% // porcentagem com 5 casas decimais
            var scientific = $"{b:E2}"; // 1,23E+004 // notação científica com 2 casas decimais

            CultureInfo.CurrentCulture = new CultureInfo("en-GB");
            wordF = $"{b:F5}"; // 12345.12300
            wordN = $"{b:N5}"; // 12,345.12300
            wordC = $"{b:C5}"; // £12,345.12300
            wordP = $"{b:P5}"; // 1,234,512.300000%

            // CultureInfo.InvariantCulture é uma cultura neutra que não está associada
            // a nenhuma região específica. Ela é usada para garantir que a formatação
            // e a análise de números, datas e moedas sejam consistentes em diferentes ambientes.
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            wordF = $"{b:F5}"; // 12345.12300
            wordN = $"{b:N5}"; // 12,345.12300
            wordC = $"{b:C5}"; // ¤12,345.12300 //¤- means unspecified currency.
            wordP = $"{b:P5}"; // 1,234,512.30000 %

            // 00001
            var wordD = $"{a:D5}"; // 00001 // numero inteiro com 5 digitos
            var word0 = $"{a:00000}"; // 00001 // outra forma de fazer o mesmo

            var paddLeft = name.PadLeft(5); // "  Tom" // adiciona espaços à esquerda
            var padRight = name.PadRight(5); // "Tom  " // adiciona espaços à direita
            var original = padRight.Trim(); // "Tom" // remove espaços à esquerda e à direita
        }
        public static void DemoParsing()
        {
            var numericString = "11";
            var word = "abc";

            var resultParse = int.Parse("1"); // 1. Se falhar, lança exceção
            var isSuccess = int.TryParse(word, out resultParse); // retorna true, resultParse = 1. Se falhar retorna false.

            var resultConvertNumber = Convert.ToInt32(numericString); // 11
            var resultConvertWord = Convert.ToInt32(word);
        }
        public static void DemoStringEquality()
        {
            string a1 = "a";
            string a2 = "a";
            object a3 = (object)"a"; // a3 é um objeto que contém uma string "a"
            object a4 = (object)"a"; // a4 é outro objeto que contém uma string "a", mas é uma referência diferente

            bool result;

            //a1 == a2
            result = a1 == a2; // true // == é usado para comparar referências de objetos, mas no caso de strings, ele compara o conteúdo.
            result = a1.Equals(a2); // true // equals é um método que compara o conteúdo das strings
            result = a1 == "a"; // true
            result = a4 == a3; // false, porque as referências não coincidem.

            a1 = null;
            result = a1 == a2; // false // a1 é null, então não pode ser igual a a2
            result = string.Equals(a1, a2); // false // string.Equals é um método que compara o conteúdo das strings, mas a1 é null, então não pode ser igual a a2
            result = a1.Equals(a2); // erro // a1 é null, então não pode chamar o método Equals
        }
    }
}