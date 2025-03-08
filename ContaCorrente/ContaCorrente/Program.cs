namespace BancoLilian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu = 1;

            ContaCorrente titular1 = new ContaCorrente();

            while (menu > 0 && menu < 5)
            {
                Console.WriteLine("Qual operação deseja realizar? ");
                Console.WriteLine("1 - Realizar um depósito");
                Console.WriteLine("2 - Realizar um Saque");
                Console.WriteLine("3 - Exibir Saldo");
                Console.WriteLine("4 - Ativar a Conta");
                Console.WriteLine("0 - Sair");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        {
                            Console.WriteLine("Digite o valor que deseja depositar: ");
                            double valorDeposito = double.Parse(Console.ReadLine());
                            Console.Clear();
                            titular1.Depositar(valorDeposito);
                            

                            Console.WriteLine(titular1.ExibirSaldo());
                            Console.WriteLine("\n");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Digite o valor que deseja sacar: ");
                            double valorSaque = double.Parse(Console.ReadLine());
                            Console.Clear();
                            titular1.Sacar(valorSaque);
                            

                            Console.WriteLine(titular1.ExibirSaldo());
                            Console.WriteLine("\n");
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine(titular1.ExibirSaldo());
                            Console.WriteLine("\n");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("ATENÇÃO! Essa opção serve apenas para validar a conta. Caso não tenha uma conta criada, por favor, vá até a agência mais próxima \n");
                            Console.WriteLine("Digite o número da conta: ");
                            titular1.Numero = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o nome do titular: ");
                            titular1.Titular = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Conta criada com sucesso!\n");
                            Console.WriteLine(titular1.ExibirInformacoes());
                            Console.WriteLine("\n");
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Volte sempre!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opção inválida!");
                            break;

                        }
                }

            }
        }
    }
}
