using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace AulaPOO
{
    internal class PessoaFisica
    {
        public string nome;
        public int idade;
        public string cpf;

        public void ListarDados(string nome, int idade, string cpf)
        {
            Console.WriteLine("Nome" + nome);
            Console.WriteLine("Idade" + idade);
            Console.WriteLine("CPF" + cpf);
        }
    }
}
