using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Agencia
    {
        private string _numero;
        private string _nome;
        private string _telefone;
        public string Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                if (value.Length != 0)
                    _numero = value;
                else
                    throw new Exception("O número não pode estar vazio!");
            }
        }
    } 

}
