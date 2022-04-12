using System;
using ByteBank.Funcionarios;

namespace ByteBank.Modelos.Util
{
    public class GerenciadorBonificacao
    {
        private static double _totalBonificacao;

        public static void Registrar(FuncionarioBase funcionario)
        {
             _totalBonificacao += funcionario.GetBonificacao();
        }

        public static double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
