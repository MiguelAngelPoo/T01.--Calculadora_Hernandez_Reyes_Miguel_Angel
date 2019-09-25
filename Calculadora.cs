using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    //clase donde se encapsulan los valores
    class Valores
    {
        private double valorA;
        private double valorB;
        

        //face de emcapsulacion 
        public double VALORa
        {      //enviar y obtener valores
            get { return valorA; }
            set { valorA = value; }
        }


        public double VALORb
        {
            get { return valorB; }
            set { valorB = value; }
        }
    }
}
