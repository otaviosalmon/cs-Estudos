// Funcoes podem ser usadas para organizar o código e torná-lo mais legível e reutilizável.
// Elas permitem dividir o código em partes menores e mais gerenciáveis
// facilitando a manutenção e a compreensão do programa como um todo.
// elas podem ser privadas ou publicas, dependendo do escopo desejado.

// Funcoes publicas podem ser acessadas de fora da classe,
// enquanto funcoes privadas só podem ser acessadas dentro da classe em que foram definidas.
// Funcoes podem ter parâmetros de entrada e retornar valores de saída.
// Os parâmetros de entrada permitem que você passe informações
// para a função quando ela é chamada e os valores de retorno permitem
// que a função retorne um resultado após a execução.
// elas podem ser "void" se não retornarem nada ou
// podem ter um tipo de retorno específico, como int, string, double, etc.

using System;
using System.Reflection.PortableExecutable;

namespace Funcoes_console
{
    class Funcoes
    {
        static float peso = 75;
        // esta linha de código define uma variável chamada weight do tipo
        // float e atribui a ela o valor 75. Como ela esta fora de qualquer função,
        // ela pode ser acessada por qualquer função dentro da mesma classe.
        // como ela possue static ela é privada e pode ser acessada por qualquer 
        // função dentro da mesma classe.

        static void Main(string[] args)
        {
            ColorfulConsole.Print(" Todo programa começara assim: ", ConsoleColor.Blue);
            ColorfulConsole.Print(" Ola!!!! Tudo bem???", ConsoleColor.Green);
            ColorfulConsole.Print(" Estou aqui para te ajudar", ConsoleColor.Yellow);
            
            Console.Write("Digite algo");
            //Printa o imput
            var input = Console.ReadLine();
            Console.WriteLine(input);

            Console.WriteLine("Digite de novo");
            var input1 = Console.ReadLine();
            Console.WriteLine(input1);

            Console.WriteLine(" Peso Antes : " + peso);
            {
                peso = 100;
                float altura = 1.619f;
                var IMC = peso/ (altura * altura);
            }
            // os valores contidos neste escopo são temporarios e não podem
            // ser acessados fora dele.

            Console.WriteLine(" Peso Depois : " + peso);

            const float impostos = 0.2f;
            const float valorGeladeira = 1000f;
            var precoDpsImposto = CalcularPreco(valorGeladeira,  impostos);
        }

        private static float CalcularPreco(float precoAntes, float imposto)
        {
            var precoTotal = precoAntes * (1 + imposto);
            return precoTotal;
        }

        static void Algo()
        {
            {
                float altura = 1.619f;
                var IMC = peso / (altura * altura);

            }
        }

    }
}


// Para criar funcoes identifique os blocos de código que podem ser
// reutilizados e em diferentes partes do programa.
// e separe os em funcoes apra organiza-los
