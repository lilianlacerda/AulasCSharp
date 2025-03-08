using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLilian
{
    internal class ContaCorrente
    {
        public int Numero;
        public string Titular;
        public double Saldo;

        public double Depositar(double ValorDeposito)
        {
            if(ValorDeposito >= 0)
            {
                Console.WriteLine("Depósito realizado com sucesso!");
                Saldo += ValorDeposito;
                return Saldo;
            }
            Console.WriteLine("Não é possível depositar um valor negativo");
            return Saldo;
        }

        public double Sacar(double ValorSaque)
        {
            if (Saldo >= ValorSaque)
            {
                Console.WriteLine("Saque realizado com sucesso!");
                Saldo -= ValorSaque;
                return Saldo;
            }

            Console.WriteLine("Saldo insuficiente!");
            return Saldo;
        }

        public string ExibirSaldo()
        {
            return $"Saldo Atual: {Saldo}";
        }

        public string ExibirInformacoes()
        {
            return $"Número da conta: {Numero}\nTitular: {Titular}\nSaldo: {Saldo}";
        }
    }
}
