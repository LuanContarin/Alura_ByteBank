using System;
using System.ComponentModel;

namespace Curso4_ByteBank_01_Variante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numAgencia = UserInput<int>("Digite a agência: ");
            int numConta = UserInput<int>("Digite número da conta: ");

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

        static T UserInput<T>(string mensagem)
        {
            bool controle = true;
            T num = default;

            while (controle)
            {
                try
                {
                    Console.Write(mensagem);
                    var conversor = TypeDescriptor.GetConverter(typeof(T));

                    if (conversor == null)
                        throw new NotSupportedException("Tipo utilizado não contém suporte para conversão.");

                    num = (T)conversor.ConvertFromString(Console.ReadLine());
                    controle = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                    controle = true;
                }
            }

            return num;
        }
    }
}
