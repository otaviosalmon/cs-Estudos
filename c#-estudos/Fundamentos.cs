using System;

namespace OlaMundo
{

    public class Fundamentos
    {

        public static void fundamentos(string[] args)


        {
            //int e usado em 32 bits, long e usado em 64 bits.
            int minhaIdadeint = 20; // Declarando uma variável inteira chamada MinhaIdade e atribuindo o valor 20 a ela.



            string meuNome = "Otávio"; // String e usado para armazenar textos, como nomes ou mensagens.



            long minhaIdadelong = 20; // Declarando uma variável inteira chamada MinhaIdade e atribuindo o valor 20 
            
            //float e usado em 32 bits, double e usado em 64 bits.

            float peso = 80.5f; // Declarando uma variável float chamada peso e atribuindo o valor 80.5 a ela.



            double altura = 1.75; // Declarando uma variável double chamada altura e atribuindo o valor 1.75 a ela.



            // decimal e usado exclusivamente para dinheiro e contas cientificas
            //( decimal) e usado para conversao de outros tipos de valores para decimal como o float e o double.
            decimal money = (decimal)10000000000000000000000.156465465465465464654654654654654654654654;



            //char e usado para armazenar um unico caractere, como letras ou simbolos.
            char letra = 'a';



            //bool e usado para armazenar valores booleanos, como verdadeiro ou falso.
            bool verdadeiro = true; // Declarando a variavel como true
            bool falso = false; // Declarando a variavel como false



            // var e usado para declarar variaveis sem especificar o tipo
            // O compilador infere o tipo com base no valor atribuído.
            var variavelNome = "junin"; // O compilador infere que variavelNome é do tipo string.
            var variavelNumero = 22; // O compilador infere que variavelNumero é do tipo int.



            Console.WriteLine(variavelNome);
            Console.WriteLine(variavelNumero);



            // Para adicionar numeros inteiros, use o operador +.
            int soma = 10 + 5;



            // Podem se usar 2 variaveis em uma operação para declarar outra
            int soma2 = soma + soma;



            //para multiplicar numeros inteiros, use o operador *.
            soma2 = soma2 * 2;



            var somaFloat = soma2 + 2.0f;



            var somaDecimail = (decimal)somaFloat + 2.0m; // O m indica que o valor é decimal.



            Console.WriteLine(somaDecimail);



            // Tambem podemos usar var para declarar Strings
            // e outros valores primitivos, como int, float, double e decimal.
            var ola = "Olá, mundo!";




            // O operador + pode ser usado para concatenar strings e outros tipos de dados.
            var olaTotal = meuNome + " , " + ola;
            var olaTotalVezes = olaTotal + 1;
            Console.WriteLine(olaTotalVezes);



            // uma variavel + uma string = uma string
            // para armazenar como string use as aspas duplas ("")
            // e para armazenar como char use aspas simples ('').
            var a = 'a';



            // quando um char e convertido para int, ele retorna o valor inteiro do caractere.
            // Por exemplo, o caractere 'a' tem o valor inteiro 97 na tabela ASCII.
            Console.WriteLine(a + " is " + (int)a);




            // O caractere 'b' tem o valor inteiro 98 na tabela ASCII.
            var b = 'b';
            Console.WriteLine(b + " is " + (int)b);



            //o resultado da soma de dois caracteres e o valor inteiro do caractere resultante.
            var ab = a + b;
            Console.WriteLine(" a + b = " + ab);
            Console.WriteLine(" Qual simbolo vai após Z  em ASCII? ");
            // char + int = char




            // Aqui nos convertemos o valor do char Z para ASCII adicionando 1 a ele 
            // e dpois convertemos o resultado de volta para char.
            var depoisDeZ = Convert.ToChar('Z' + 1);
            Console.WriteLine("Resposta : " + depoisDeZ);



            // Não se pode subtrair strings, mas podemos subtrair char.
            // O resultado da subtração de dois caracteres é o valor inteiro do caractere resultante.
            Console.WriteLine(" Letras no alfabeto : " + ('z' - 'a'));



            // Voce so pode multiplicar e dividir numeros
            // Dividir um inteiro por outro inteiro resulta em um inteiro.
            var divisaoResult = 1 / 100; // O resultado é 0, pois a parte decimal é descartada.
            Console.WriteLine("Divisão de inteiros: " + divisaoResult);



            // Para obter um resultado decimal, pelo menos um dos números deve ser decimal.
            // Isso pode ser feito adicionando um "m" ou "f" ao final do número.
            // Ou seja dividir um inteiro por um numero com decimal mantem a parte decimal.
            var divisaoResultFracao = 1 / 100.0;
            Console.WriteLine(" Divisão de decimais/Frações : " + divisaoResultFracao);



            var cem = 100;



            var cemCentenas = cem * 100.0f;
            Console.WriteLine(cemCentenas);



            // Se quiser um valor imutavel use const (constante)
            const double pi = 3.1459; // O valor de pi é uma constante e não pode ser alterado.



            // pi = 3.14; // Isso causaria um erro, pois pi é uma constante.



            Console.WriteLine(" Insira Seu nome: ");
            String nome = Console.ReadLine();
            // Lê uma linha de texto do console e armazena na variável nome.
            // O método Console.ReadLine() lê a entrada do usuário até que ele pressione Enter.
            Console.WriteLine("Ola de novo " + nome + "!");

        }

    }
}