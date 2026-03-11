using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Conta
    {
        private long _numero;
        private decimal _saldo;

        public Conta(long numero, decimal saldo)
        {
            _numero = numero;
            _saldo = saldo;
        }

        public long Numero
        {
            get => _numero;
            set => _numero = value;
        }

        public decimal Saldo
        {
            get => _saldo;
            set => _saldo = value;
        }

        public void Deposito(decimal valor)
        {
            _saldo += valor;
            //_saldo = _saldo + valor;
        }

        public void Saque(decimal valor)
        {
            _saldo -= valor;
            //_saldo = _saldo - valor;
        }
    }
}
