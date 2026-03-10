using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Cliente
    {
        private string _nome;
        private string _cpf;
        public string Nome
        {
            get => _nome;
            set
            {
                _nome = value;
            }
        }
        public string Cpf
        {
            get => _cpf;
            /*get
            {
                return _cpf;
            }*/
            set
            {
                _cpf = value;
            }
        }
        public Cliente(string nome, string cpf)
        {
            _nome = nome;
            _cpf = cpf;
        }

    }
}
