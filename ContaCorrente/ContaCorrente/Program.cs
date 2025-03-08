namespace BancoLilian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu = 1;

            ContaCorrente titular1 = new ContaCorrente();
            Console.WriteLine(titular1.ExibirSaldo());
            Console.WriteLine("\n");

            while (menu > 0 && menu < 3)
            {
                Console.WriteLine("Qual operação deseja realizar? ");
                Console.WriteLine("1 - Realizar um depósito");
                Console.WriteLine("2 - Realizar um Saque");
                Console.WriteLine("3 - Exibir Saldo");
                Console.WriteLine("0 - Sair");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        {
                            Console.WriteLine("Digite o valor que deseja depositar: ");
                            double valorDeposito = double.Parse(Console.ReadLine());
                            titular1.Depositar(valorDeposito);

                            Console.WriteLine(titular1.ExibirSaldo());
                            Console.WriteLine("\n");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Digite o valor que deseja sacar: ");
                            double valorSaque = double.Parse(Console.ReadLine());
                            titular1.Sacar(valorSaque);

                            Console.WriteLine(titular1.ExibirSaldo());
                            Console.WriteLine("\n");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(titular1.ExibirSaldo());
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
