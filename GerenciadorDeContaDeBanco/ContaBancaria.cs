using static System.Net.Mime.MediaTypeNames;
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
            return Saldo + Deposito;

        }
        public double Sacar()
        {
            return Saldo - Saque;
        }
        
    }

}
