using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso4_ByteBank_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a agência: ");
            int numAgencia = int.Parse(Console.ReadLine());

            Console.Write("Digite número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            try
            {
                ContaCorrente contaCorrente = new ContaCorrente(numAgencia, numConta, new Cliente(12385762, "Luan Contarin"));

                EscreverConta(contaCorrente);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.GetType().Name + ": " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name + ": " + ex.Message);
            }

            Console.ReadLine();
        }

        static void EscreverConta(ContaCorrente conta)
        {
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine("Agência: " + conta.Agencia);
            Console.WriteLine("Conta: " + conta.Numero);
            Console.WriteLine("Saldo: " + conta.Saldo);
            Console.WriteLine("Titular: " + conta?.Titular?.Nome);
            Console.WriteLine("--------------------");
            Console.WriteLine();
        }
    }
}
