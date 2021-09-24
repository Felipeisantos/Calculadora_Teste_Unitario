using System;
using System.Collections.Generic;

namespace Calculadora_Teste_Unitario
{
    class Operacoes
    {

        public float Subtracao(List<float> values)
        {
            try
            {
                bool first_run = true;

                float retorno = 1;
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
        public float Soma(List<float> values)
        {
            try
            {
                bool first_run = true;

                float retorno = 1;
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
            catch (OverflowException)
            {
                return 0;
            }
        }
        public float Divisao(List<float> values)
        {
            try
            {
                bool first_run = true;

                float retorno = 1;
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
            catch (OverflowException)
            {
                return 0;
            }
        }
        public float Multiplicacao(List<float> values)
        {
            try
            {
                bool first_run = true;

                float retorno = 1;
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
            catch (OverflowException)
            {
                return 0;
            }
        }
    }
}
