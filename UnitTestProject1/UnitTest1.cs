using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculadora_Teste_Unitario;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Divisao_test()
        {
            Operacoes op = new Operacoes();
            List<float> values = new List<float>();
            Random randNum = new Random();
            float val1 = randNum.Next(100);
            float val2 = randNum.Next(100);
            values.Add(val1);
            values.Add(val2);

            float result = op.Divisao(values);
            float esperado = val1/val2;
            Assert.AreEqual(esperado, result, 0.001, "Falha no teste de divisão");
        }
        [TestMethod]
        public void Multiplicacao_test()
        {
            Operacoes op = new Operacoes();
            List<float> values = new List<float>();
            Random randNum = new Random();
            float val1 = randNum.Next(100);
            float val2 = randNum.Next(100);
            values.Add(val1);
            values.Add(val2);

            float result = op.Multiplicacao(values);
            float esperado = val1*val2;
            Assert.AreEqual(esperado, result, 0.001, "Falha no teste de divisão");
        }
        [TestMethod]
        public void Subtracao_test()
        {
            Operacoes op = new Operacoes();
            List<float> values = new List<float>();
            Random randNum = new Random();
            float val1 = randNum.Next(100);
            float val2 = randNum.Next(100);
            values.Add(val1);
            values.Add(val2);

            float result = op.Subtracao(values);
            float esperado = val1-val2;
            Assert.AreEqual(esperado, result, 0.001, "Falha no teste de divisão");
        }
        [TestMethod]
        public void Soma_test()
        {
            Operacoes op = new Operacoes();
            List<float> values = new List<float>();
            Random randNum = new Random();
            float val1 = randNum.Next(100);
            float val2 = randNum.Next(100);
            values.Add(val1);
            values.Add(val2);

            float result = op.Soma(values);
            float esperado = val1+val2;
            Assert.AreEqual(esperado, result, 0.001, "Falha no teste de divisão");
        }
    }
}