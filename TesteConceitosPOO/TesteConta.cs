using ConceitosPOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConceitosPOO
{
    [TestClass]
    public class TesteConta
    {
        [TestMethod]
        public void TestDeposito()
        {
            //cenário 
            decimal saldoInicial = 1000;
            decimal valorDeposito = 500;
            decimal saldoEsperado = 1500;
            Conta conta = new Conta(1111, saldoInicial); 

            //ação
            conta.Deposito(valorDeposito);

            //verificação
            Assert.AreEqual(saldoEsperado, conta.Saldo);
        }
        [TestMethod]
        public void TestSaque()
        {
            //cenário
            decimal saldoInicialS = 2000;
            decimal valorSaque = 500;
            decimal saldoEsperadoS = 1500;
            Conta conta = new Conta(1111, saldoInicialS);

            //ação
            conta.Saque(valorSaque);

            //verificação
            Assert.AreEqual(saldoEsperadoS, conta.Saldo);
        }
        [TestMethod]
        public void TestTransferencia()
        {
            //cenário

            //ação

           //verificação

        }
    }
}
