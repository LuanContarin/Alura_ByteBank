using System;
using ByteBank_01.Funcionarios;

namespace ByteBank_01
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
