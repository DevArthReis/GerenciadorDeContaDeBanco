using System;
using System.Globalization;

namespace GerenciadorDeContaDeBanco
{
    internal class ContaBancaria
    {
        public string NumeroConta;
        public string Titular;
        public double Saldo;
        public double Deposito;
        public double Saque;

        public double Depositar()
        {
            Saldo += Deposito;
            return Saldo;
        }

        public double Sacar()
        {
            Saldo -= Saque;
            return Saldo;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual da conta {NumeroConta} ({Titular}): R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

