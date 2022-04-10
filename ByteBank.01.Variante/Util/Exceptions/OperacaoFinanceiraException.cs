using System;

namespace Curso4_ByteBank_01_Variante.Util.Exceptions
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
