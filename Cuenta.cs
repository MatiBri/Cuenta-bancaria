using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria1W1
{
    class Cuenta
    {
        private int numero, tipo;
        private double saldo;
        private Cliente cliente;

        public Cuenta()
        {
            numero = 0;
            tipo = 0;
            saldo = 0.0;
            cliente = null;
        }
        public Cuenta(int numero, int tipo, double saldo, Cliente cliente)
        {
            this.numero = numero;
            this.tipo = tipo;
            this.saldo = saldo;
            this.cliente = cliente;
        }
        public int pNumero {
            get { return numero; }
            set { numero = value; }
        }
        public int pTipo {
            get { return tipo; }
            set { tipo = value; }
        }
        public double pSaldo {
            get { return saldo; }
            set { saldo = value; }
        }
        public Cliente pCliente {
            get { return cliente; }
            set { cliente = value; }
        }
        public string mostrarTipo()
        {
            switch (tipo)
            { 
                case 1: return "Caja de Ahorro";
                case 2: return "Cuenta Corriente";
                default: return "Desconocido";
            }

        }
        public string toString()
        {
            return "Numero de cuenta: " + numero + "\nTipo: " + mostrarTipo() + "\nSaldo: " + saldo + "\nCliente:\n" + cliente.toString();
        }
        public void depositar(double ingreso)
        {
            saldo += ingreso;
        }
        public string extraccion(double retiro)
        {
            if (retiro <= cliente.pLimiteCredito)
            {
                if (saldo > retiro)
                {
                    saldo = saldo - retiro;
                    return "Se pudo retirar";
                }
                else
                {
                    return "No se puede retirar: Saldo Insuficiente";
                }
            }
            else
                return "No se puede retirar: Supera el limite de Credito";

        }
    }
}
