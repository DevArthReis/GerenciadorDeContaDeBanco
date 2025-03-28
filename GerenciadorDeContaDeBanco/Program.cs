using GerenciadorDeContaDeBanco;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria Conta = new ContaBancaria();
            Console.WriteLine("Digite o numero da Conta:");
            Conta.NumeroConta = Console.ReadLine();
            Console.WriteLine("Digite o titular:");
            Conta.Titular = Console.ReadLine();
            Console.WriteLine("Quanto deseja adicionar ao seu saldo:");
            //
            Conta.Saldo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Conta.ExibirSaldo();
            //
            Console.WriteLine("Quanto deseja Depositar a essa conta:");
            Conta.Deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //
            Console.WriteLine($"O numero da Conta é{Conta.NumeroConta} o titular é {Conta.Titular} Com o saldo de {Conta.Depositar().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine("Quanto deseja sacar a essa conta:");
            //
            Conta.Saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine($"O numero da Conta é{Conta.NumeroConta} o titular é {Conta.Titular} Com o saldo de {Conta.Sacar().ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}