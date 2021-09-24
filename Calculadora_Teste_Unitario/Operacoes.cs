using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Teste_Unitario
{
    class Operacoes
    {

        public decimal Subtracao(List<decimal> values)
        {
            try
            {
                bool first_run = true;

                decimal retorno = 1;
                foreach (var val in values)
                {
                    if (first_run)
                    {
                        retorno = val;
                        first_run = false;
                    }
                    else
                        retorno -= val;
                }
                return retorno;
            }
            catch (OverflowException)
            {
                return 0;
            }

        }
        public decimal Soma(List<decimal> values)
        {
            try
            {
                bool first_run = true;

                decimal retorno = 1;
                foreach (var val in values)
                {
                    if (first_run)
                    {
                        retorno = val;
                        first_run = false;
                    }
                    else
                        retorno += val;
                }
                return retorno;
            }
            catch (OverflowException )
            {
                return 0;
            }
        }
        public decimal Divisao(List<decimal> values)
        {
            try
            {
                bool first_run = true;

                decimal retorno = 1;
                foreach (var val in values)
                {
                    if (first_run)
                    {
                        retorno = val;
                        first_run = false;
                    }
                    else
                        retorno /= val;
                }
                return retorno;
            }
            catch (OverflowException )
            {
                return 0;
            }
        }
        public decimal Multiplicacao(List<decimal> values)
        {
            try
            {
                bool first_run = true;

                decimal retorno = 1;
                foreach (var val in values)
                {
                    if (first_run)
                    {
                        retorno = val;
                        first_run = false;
                    }
                    else
                        retorno *= val;
                }
                return retorno;
            }
            catch (OverflowException )
            {
                return 0;
            }
        }
    }
}
