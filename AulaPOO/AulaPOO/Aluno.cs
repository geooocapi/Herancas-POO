using System;
using System.Collections.Generic;
using System.Text;

namespace AulaPOO
{
    internal class Aluno : PessoaFisica
    {
        public string Rm;
        public string Curso;

        public void listarAluno(string Rm, string Curso)
        {
           base.ListarDados(this.nome, this.idade, this.cpf);

            Console.WriteLine("O aluno portador do RM" + Rm + "está cadastrado no curso de" + Curso);
        }

        public void matricularDisciplina()
        {
            Console.WriteLine("Em qual disciplina deseja cadastrar o aluno?");
            string disciplina = Console.ReadLine();
            Console.WriteLine("Cadastrado na disciplina" + disciplina + " com sucesso");
        }
  
    }
}