using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Pessoa
    {
        public static string ObterNomeClasse() // metodo estatico, pode ser chamado sem instanciar a classe
        {
            return "Pessoa";
        }

        private string _nome;

        // Somente leitura
        public string ObterNome() // metodo publico que retorna o nome, mas nao permite alteracao
        {
            return _nome;
        }

        // Somente escrita
        private void DefinirNome(string nome) // nao retornara nada por isso void
        {
            _nome = nome;
        }

        private string _sobrenome; // pode ser acessado diretamente por qualquer metodo dentro da classe 

        public void DefinirSobrenome(string sobrenome)
        {
            _sobrenome = sobrenome;
        }

        public string ObterSobrenome() // metodo publico que retorna o sobrenome
        {
            return _sobrenome;
        }

        public string ObterNomeCompleto() // metodo publico que retorna o nome completo
        {
            return $"{_nome} {_sobrenome}";
        }

        private DateTime _dataNascimento;

        public int ObterIdade() // metodo publico que calcula a idade com base na data de nascimento
        {
            return (int)(DateTime.Now - _dataNascimento).TotalDays / 365;
        }

        // Construtor com parâmetros
        public Pessoa(string nome, DateTime dataNascimento) // construtor que recebe nome e data de nascimento
        {
            _nome = nome;
            _dataNascimento = dataNascimento;
        }

        // Construtor padrão
        public Pessoa() // construtor sem parametros, inicializa com valores padrao
        {
        } // overloading de construtor // serve para cirar objetos sem parametros
          // e preencher os valores depois

        public void Falar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
