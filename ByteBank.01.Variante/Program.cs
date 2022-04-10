using System;
using System.ComponentModel;
using Curso4_ByteBank_01_Variante.Util.Exceptions;

namespace Curso4_ByteBank_01_Variante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Selecione o caso a ser tratado (S: Sacar, T: Transferir)");
                string operacao = Console.ReadLine();

                switch (operacao)
                {
                    case "S":
                        ExcecaoSacar();
                        break;

                    case "T":
                        ExcecaoTransferir();
                        break;

                    default:
                        break;
                }

            }
            catch (ArgumentException ex)
            {
                EscreverErro(ex);
            }
            catch (OperacaoFinanceiraException ex)
            {
                EscreverErro(ex);
            }
            catch (Exception ex)
            {
                EscreverErro(ex);
            }

            Console.ReadLine();
        }

        static void ExcecaoSacar()
        {
            ContaCorrente conta1 = new ContaCorrente(123, 21351, new Cliente(12345678912, "luan"));

            Console.WriteLine("Ao tentar sacar um valor sem o saldo disponível ira lançar uma exceção" +
                " e mostrar as informações sensíveis por se tratar de uma operação privada (a conta não" +
                " se relaciona com nenhuma outra.");
            Console.WriteLine();

            conta1.Sacar(10000);
        }

        static void ExcecaoTransferir()
        {
            ContaCorrente conta1 = new ContaCorrente(123, 21351, new Cliente(12345678912, "luan"));
            ContaCorrente conta2 = new ContaCorrente(892, 58263, new Cliente(73151982365, "joao"));

            Console.WriteLine("Ao tentar transferir um valor para outra conta sem o saldo disponível" +
                " irá lançar uma exceção com uma mensagem genérica, por se tratar de um dado" +
                " sensível de ser compartilhado em uma operação envolvendo 2 contas.");
            Console.WriteLine();

            conta1.Transferir(10000, conta2);
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

        static void EscreverErro(Exception ex)
        {
            Console.WriteLine(ex.GetType().Name + ": " + ex.Message);
            Console.WriteLine(ex.StackTrace);
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
