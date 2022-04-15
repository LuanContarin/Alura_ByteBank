using System;
using ByteBank.Modelos.Util;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Define uma conta-corrente do banco ByteBank.
    /// </summary>
    public class ContaCorrente
    {
        /// <summary>
        /// Cria uma instância da classe <see cref="ContaCorrente"/> com as informações especificadas.
        /// </summary>
        /// <param name="agencia"> Número da agência da conta. Deve ser um número maior que 0. </param>
        /// <param name="numero"> Número único da conta. Deve ser um número maior que 0. </param>
        /// <param name="titular"> Responsável pela conta. </param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public ContaCorrente(int agencia, int numero, Cliente titular)
        {
            if (agencia <= 0)
                throw new ArgumentException("A agência deve ser maior que 0.", nameof(agencia));
            if (numero <= 0)
                throw new ArgumentException("O número da conta deve ser maior que 0.", nameof(numero));

            Agencia = agencia;
            Numero = numero;
            Titular = titular ?? throw new ArgumentNullException(nameof(titular), "A conta deve possuir um titular.");
            TotalDeContas++;
        }
        
        public int Agencia { get; }
        public int Numero { get; }
        public double Saldo { get; private set; } = 100;
        public int ContadorTransferenciasNaoPermitidas { get; private set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public Cliente Titular { get; protected set; }
        public static int TotalDeContas { get; private set; }

        #region Métodos

        /// <summary>
        /// Saca da conta-corrente o valor passado.
        /// </summary>
        /// <param name="valor"> Valor para saque. Não pode ser negativo. </param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="SaldoInsuficienteException"></exception>
        public void Sacar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor para saque inválido.", nameof(valor));
            if (Saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            Saldo -= valor;
        }

        /// <summary>
        /// Transfere o valor passado para outra conta.
        /// </summary>
        /// <param name="valor"> Valor para transferência. </param>
        /// <param name="contaDestino"> Conta a qual estará transferindo o valor. </param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="OperacaoFinanceiraException"></exception>
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
                throw new ArgumentException("valor para transferência inválido.", nameof(valor));

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Não foi possível realizar a operação.", ex);
            }

            contaDestino.Depositar(valor);
        }

        /// <summary>
        /// Deposita um valor em uma conta.
        /// </summary>
        /// <param name="valor"> Valor de depósito. Não pode ser negativo. </param>
        /// <exception cref="ArgumentException"></exception>
        public void Depositar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor para saque inválido.", nameof(valor));

            Saldo += valor;
        }

        #endregion
    }
}
