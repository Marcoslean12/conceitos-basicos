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
            decimal saldoInicial = 2000;
            decimal valorSaque = 500;
            decimal saldoEsperado = 1500;
            Conta conta = new Conta(1111, saldoInicial);

            //ação
            conta.Saque(valorSaque);

            //verificação
            Assert.AreEqual(saldoEsperado, conta.Saldo);
        }
        [TestMethod]
        public void TestTransferencia()
        {
            //cenário
            decimal saldoInicialContaOrigem = 1000;
            decimal saldoInicialContaDestino = 1000;
            decimal valorTransferencia = 1000;
            decimal saldoFinalContaOrigem = 0;
            decimal saldoFinalContaDestino = 2000;
            Conta contaOrigem, contaDestino;
            contaOrigem = new Conta(1111, saldoInicialContaOrigem);
            contaDestino = new Conta(2222, saldoInicialContaDestino);

            //ação
            contaOrigem.Transferencia(contaDestino, valorTransferencia);

            //verificação
            Assert.AreEqual(saldoFinalContaOrigem, contaOrigem.Saldo);
            Assert.AreEqual(saldoFinalContaDestino, contaDestino.Saldo);
            
        }
        [TestMethod]
        public void TestDepositoMenorZero()
        {
            //cenario
            decimal saldoInicial = 1000;
            decimal valorDeposito =-500;
            Conta conta = new Conta(1111, saldoInicial);

            //ação e verificação
            Assert.ThrowsException<ArgumentException>(() => conta.Deposito(valorDeposito));

        }
        [TestMethod]
        public void TestSaqueMenorZero()
        {
            //cenario
            decimal saldoInicial = 1000;
            decimal valorSaque = -500;
            Conta conta = new Conta(1111, saldoInicial);

            //ação e varificação 
            Assert.ThrowsException<ArgumentException>(() => conta.Saque(valorSaque));

        }
    }
}
