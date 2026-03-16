using AulaPOO;
using System.ComponentModel.Design;

Console.WriteLine("Bem-vindo ao sistema escolar! Digite 0 se você é: professor; ou, digite 1 se você é: aluno.");
int opcao = Convert.ToInt32(Console.ReadLine());

if (opcao == 0)
{
    Professor prof = new Professor();

    Console.WriteLine("Insira o nome");
    prof.nome = Console.ReadLine();

    Console.WriteLine("Insira a idade");
    prof.idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insira o CPF");
    prof.cpf = Console.ReadLine();

    Console.WriteLine("Insira a formação acadêmica");
    prof.formacao = Console.ReadLine();

    Console.WriteLine("Insira o cargo na instituição");
    prof.cargo = Console.ReadLine();

    Console.WriteLine("Insira o salário");
    prof.salario = Convert.ToDouble(Console.ReadLine());

    int MenuCommand = 0;
    while(MenuCommand != 3)
    {
        Console.WriteLine("Digite 1 para listar os dados do professor; ou, digite 2 para cadastrar o professor em uma disciplina; ou, digite 3 para sair.");
        MenuCommand = Convert.ToInt32(Console.ReadLine());
        if (MenuCommand == 1)
        {
            prof.ListarProfessor(prof.formacao, prof.cargo, prof.salario);
        }
        else if (MenuCommand == 2)
        {
            prof.cadastrarDisciplina();
        }
    }
}



else if (opcao == 1)
{
    Aluno aluno = new Aluno();

    Console.WriteLine("Insira o nome");
    aluno.nome = Console.ReadLine();

    Console.WriteLine("Insira a idade");
    aluno.idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insira o CPF");
    aluno.cpf = Console.ReadLine();

    Console.WriteLine("Insira o RM");
    aluno.Rm = Console.ReadLine();

    Console.WriteLine("Insira o curso");
    aluno.Curso = Console.ReadLine();

    int MenuCommand = 0;
    while (MenuCommand != 3)
    {
        Console.WriteLine("Digite 1 para listar os dados do aluno; ou, digite 2 para cadastrar o aluno em uma disciplina; ou, digite 3 para sair.");
        MenuCommand = Convert.ToInt32(Console.ReadLine());
        if (MenuCommand == 1)
        {
            aluno.listarAluno(aluno.Rm, aluno.Curso);
        }
        else if (MenuCommand == 2)
        {
            aluno.matricularDisciplina();
        }
    }
}