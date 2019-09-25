using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    
    //clase donde se realizan las operacioes
    class Operacion
    {
        //instanciamos la clase 

        Valores V = new Valores();
        Double Res;

        public Double suma(Valores V)
        {
            //realizamos operaciones
            Principal rt = new Principal();
            Res = (V.VALORa + V.VALORb);
            return Res;
           
        }

        public Double restar(Valores V)
        {   //realizamos operaciones
            Principal rt = new Principal();
            Res = (V.VALORa - V.VALORb);
            return Res;
            //retornamos el valor res
        }

        public Double multiplicar(Valores V)
        {
            Principal rt = new Principal();
            Res = (V.VALORa * V.VALORb);
            return Res;

        }

        public Double dividir(Valores V)
        {
            Principal rt = new Principal();
            Res = (V.VALORa / V.VALORb);
            return Res;

        }
    }
}
