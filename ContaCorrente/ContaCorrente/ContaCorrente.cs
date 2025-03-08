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
            Saldo += ValorDeposito;
            return Saldo;
        }

        public double Sacar(double ValorSaque)
        {
            Saldo -= ValorSaque;
            return Saldo;
        }

        public string ExibirSaldo()
        {
            return $"Saldo Atual: {Saldo}";
        }
    }
}
