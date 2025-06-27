using System;

namespace POO
{
    class Programa
    {
        static void Main(string[] args)
        {
            var pessoa1 = new Pessoa("Otávio", new DateTime(1994, 5, 25));
            // esta linha serve para criar um objeto do tipo Pessoa, passando o nome e a data de nascimento
            // pessoa1._nome = "Kaisinel"; // Acesso direto ao campo privado, não recomendado
            pessoa1.DefinirSobrenome("Salomão");
            // esta linha serve para definir o sobrenome da pessoa1, depois de ter criado o objeto

            var pessoa2 = new Pessoa(); // criando um objeto do tipo Pessoa sem parametros

            Console.WriteLine($"{pessoa1.ObterNomeCompleto()} tem {pessoa1.ObterIdade()}");
            Console.WriteLine(pessoa2.ObterNomeCompleto());
            pessoa1.Falar("Hello world!");

            Console.WriteLine(Pessoa.ObterNomeClasse()); // Chamada de método estático, não precisa de instância
        }
    }
}
