using System;

namespace ByteBank_01.Modelos
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {
        }

        public OperacaoFinanceiraException(string mensagem)
            : base(mensagem)
        {
        }

        public OperacaoFinanceiraException(string mensagem, Exception innerException)
            : base(mensagem, innerException)
        {
        }
    }
}
