using System;
using System.Collections.Generic;
using System.Text;

namespace AulaPOO
{
    internal class Professor : PessoaFisica
    {
        public string formacao;
        public string cargo;
        public double salario;

        public void ListarProfessor(string formacao, string cargo, double salario)
        {
            base.ListarDados(this.nome, this.idade, this.cpf);

            Console.WriteLine("Formação acadêmica" + formacao);
            Console.WriteLine("Cargo na Instituição" + cargo);
            Console.WriteLine("Salário" + salario);
        }

        public void cadastrarDisciplina()
        {
            Console.WriteLine("Em qual disciplina deseja cadastrar o professor?");
            string disciplina = Console.ReadLine();
            Console.WriteLine("O professor foi cadastrado na disciplina" + disciplina);
        }
    }
}
