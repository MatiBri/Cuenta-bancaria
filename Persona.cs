using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria1W1
{
    abstract class Persona
    {
        private int documento, sexo;
        private string nombre;
        private DateTime fecha_nac;
        
        public Persona()
        {
            documento = 0;
            sexo = 0;
            nombre = "";
            fecha_nac = DateTime.Today;
        }
        public Persona(int documento, string nombre,int sexo, DateTime fecha_nac)
        {
            this.documento = documento;
            this.nombre = nombre;
            this.sexo = sexo;
            this.fecha_nac = fecha_nac;
        }
       
        public int pDocumento {
            get { return documento; }
            set { documento = value; }
        }
        public int pSexo {
            get { return sexo; }
            set { sexo = value; }
        }
        public string pNombre {
            get { return nombre; }
            set { nombre = value; }
        }
        public DateTime  pFechaNac {
            get { return fecha_nac; }
            set { fecha_nac = value; }
        }
        public string mostrarSexo()
        {
            if (sexo == 1)
                return "Masculino";
            else if (sexo == 2)
                return "Femenino";
            else return "Desconocido";
        }
        public string toString()
        {
            return "Nombre: " + nombre + "\nDNI: " + documento + "\nSexo: " + mostrarSexo() + "\nFecha Nacimiento: " + fecha_nac;
        }
    }
}
