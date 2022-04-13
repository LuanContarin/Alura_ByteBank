using System;

namespace ByteBank.Modelos.Util
{
    internal class CpfValidator
    {
        /// <summary>
        /// Verifica se o CPF passado possui 11 números.
        /// </summary>
        /// <param name="cpf"> CPF para ser verificado. </param>
        /// <returns></returns>
        public void ValidarTamanhoCpf(decimal cpf)
        {
            if (cpf.ToString().Length != 11)
                throw new ArgumentException("Tamanho do CPF inválido.", nameof(cpf));
        }
    }
}
