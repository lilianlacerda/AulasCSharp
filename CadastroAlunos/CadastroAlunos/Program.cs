namespace CadastroAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidarDados validar = new ValidarDados();
            List<Alunos> listaAlunos = new List<Alunos>();

            while(true)
            {
                   Console.WriteLine("Cadastro de Alunos");
                   Console.WriteLine("1 - Cadastrar Aluno");
                   Console.WriteLine("2 - Listar Alunos");
                   Console.WriteLine("0 - Sair");
                   int opcao = int.Parse(Console.ReadLine());

                   switch (opcao)
                   {
                       case 1:
                           {
                               Console.WriteLine("Digite o nome do aluno: ");
                               string nome = Console.ReadLine();
                               Console.WriteLine("Digite o curso do aluno: ");
                               string curso = Console.ReadLine();
                               Console.WriteLine("Digite o email do aluno: ");
                               string email = Console.ReadLine();
                               validar.ValidarEmail(email);
                               Console.WriteLine("Digite o telefone do aluno: ");
                               string telefone = Console.ReadLine();

                               Alunos alunos = new Alunos(nome, curso, email, telefone);

                               listaAlunos.Add(alunos);
                               Console.WriteLine("\nAluno cadastrado com sucesso!\n");
                               //bool hasAluno = listaAlunos.Contains(alunos.Curso);

                           break;
                           }
                       case 2:
                       {
                           foreach (Alunos aluno in listaAlunos)
                           {
                               Console.WriteLine("Nome: " + aluno.Nome);
                               Console.WriteLine("Curso: " + aluno.Curso);
                               Console.WriteLine("Email: " + aluno.Email);
                               Console.WriteLine("Telefone: " + aluno.Telefone);
                               Console.WriteLine("---------------");
                               Console.WriteLine("\n");
                           }
                           break;
                       }
                       case 0:
                       {
                           Console.WriteLine("Obrigado por usar o sistema!\n");
                           return;
                       }
                       default:
                       {
                           Console.WriteLine("Opção inválida\n");
                           break;
                       }
                   }
            }   

        }
 }  }
