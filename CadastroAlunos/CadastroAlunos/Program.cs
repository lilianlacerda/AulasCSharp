namespace CadastroAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;
            List<Alunos> listaAlunosCadastrados = new List<Alunos>();

            while (opcao >= 1 && opcao <= 2)
            {
                Console.WriteLine("Bem-vindo ao sistema de cadastro de alunos!");
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Mostrar alunos cadastrados");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                { 
                    case 1:
                    { 
                    Console.WriteLine("Digite o nome do aluno: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite a matrícula do aluno: ");
                    string matricula = Console.ReadLine();
                    Console.WriteLine("Digite a data de nascimento do aluno: ");
                    string dataNascimento = Console.ReadLine();
                    Console.WriteLine("Digite o curso do aluno: ");
                    string curso = Console.ReadLine();
                    Console.WriteLine("Digite o email do aluno: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Digite o telefone do aluno: ");
                    string telefone = Console.ReadLine();

                    Alunos aluno = new Alunos(nome, matricula, dataNascimento, curso, email, telefone);
                    listaAlunosCadastrados.Add(aluno);

                    Console.WriteLine("\nAluno cadastrado com sucesso!\n");
                    break;
                    }

                    case 2:
                    {
                            foreach (Alunos aluno in listaAlunosCadastrados)
                            {
                                Console.WriteLine("Nome: " + aluno.nome);
                                Console.WriteLine("Matrícula: " + aluno.matricula);
                                Console.WriteLine("Data de Nascimento: " + aluno.dataNascimento);
                                Console.WriteLine("Curso: " + aluno.curso);
                                Console.WriteLine("Email: " + aluno.email);
                                Console.WriteLine("Telefone: " + aluno.telefone);
                                Console.WriteLine("\n");
                            }
                            break;
                        }
                }
             }

            }
        }
    }
