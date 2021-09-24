using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Teste_Unitario
{
    class Auxiliar
    {
        private string Value_Top;
        private string Operacao;

        public void Set_Valores(string valor_top, string operacao) {
            this.Value_Top = valor_top;
            this.Operacao = operacao;
        }
        public void Erase_values()
        {
            this.Value_Top = null;
            this.Operacao = null;
        }
        public string GetValue_Top { get => Value_Top; }
        public string GetOperacao { get => Operacao; }
        public string SetValue_Top { set => Value_Top = value; }
        public string SetOperacao { set => Operacao = value; }
    }
}
