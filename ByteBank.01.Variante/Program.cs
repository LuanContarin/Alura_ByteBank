using System;
using System.ComponentModel;
using Curso4_ByteBank_01_Variante.Util.Exceptions;

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
                ContaCorrente conta1 = new ContaCorrente(numAgencia, numConta, new Cliente(12385762, "Luan Contarin"));
                ContaCorrente conta2 = new ContaCorrente(1234, 21345, new Cliente(123125123, "Renan Cappelletti"));
                conta1.Depositar(300);

                Console.WriteLine();
                Console.WriteLine("contas 1/2 antes da transferência:");
                EscreverConta(conta1);
                EscreverConta(conta2);

                double valorTransferencia = -1231;
                conta1.Transferir(valorTransferencia, conta2);
                
                Console.WriteLine($"contas 1/2 após transferência no valor de R${valorTransferencia} da conta1 p/ conta2:");
                EscreverConta(conta1);
                EscreverConta(conta2);
            }
            catch (ArgumentException ex)
            {
                EscreverErro(ex);
            }
            catch (SaldoInsuficienteException ex)
            {
                EscreverErro(ex);
            }
            catch (Exception ex)
            {
                EscreverErro(ex);
            }

            Console.ReadLine();
        }

        static void EscreverConta(ContaCorrente conta)
        {
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine("Agência: " + conta.Agencia);
            Console.WriteLine("Conta: " + conta.Numero);
            Console.WriteLine("Saldo: R$" + conta.Saldo);
            Console.WriteLine("Titular: " + conta?.Titular?.Nome);
            Console.WriteLine("--------------------");
            Console.WriteLine();
        }

        static void EscreverErro (Exception ex)
        {
            Console.WriteLine(ex.GetType().Name + ": " + ex.Message);
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
