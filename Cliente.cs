using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria1W1
{
    class Cliente: Persona
    {
        private int codigo;
        private double limiteCredito;

        //Constructores
        public Cliente():base()
        {
            codigo = 0;
            limiteCredito = 0.0;
        }

        //Constructor con parámetros
        public Cliente(int codigo, string nombre, int documento, int sexo, DateTime fecha_nac, double limiteCredito): base(documento,nombre,sexo,fecha_nac)
        {
            this.codigo=codigo;
            this.limiteCredito = limiteCredito;
        }

        public int pCodigo {
            get { return codigo; }
            set { codigo = value; }
        }
        public double pLimiteCredito {
            get { return limiteCredito; }
            set { limiteCredito = value; }
        }
        public new string toString()
        {
            return "Codigo Cliente: " + codigo + "\n" + base.toString() + "\nLimite de Credito: " + limiteCredito;
        }
        

    }
}
