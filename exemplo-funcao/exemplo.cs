using System;



namespace exemplo_funcao
{
    class exemplo
    {
        // Função Main é o ponto de entrada do programa
        // ela é chamada quando o programa é executado.
        // e executa as funções que estão dentro dela.

        static void Main(string[] args)
        {
          PrintInput(mensagemExtra:"");
          PrintInput("a mais");
        }

        // a funcao PrintInput é uma função que imprime uma mensagem no console
        // e lê a entrada do usuário.
        // Ela recebe um parâmetro opcional chamado mensagemExtra

        private static void PrintInput(string mensagemExtra)
        {
            Console.WriteLine("Digite Algo" + mensagemExtra);
            var input = Console.ReadLine();
            Console.WriteLine(" Digite algo " + mensagemExtra + " que resulte em : " + input);
        }
    }

}
