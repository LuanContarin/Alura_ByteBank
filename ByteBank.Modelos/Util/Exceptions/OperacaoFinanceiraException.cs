using System;

namespace ByteBank.Modelos.Util
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
