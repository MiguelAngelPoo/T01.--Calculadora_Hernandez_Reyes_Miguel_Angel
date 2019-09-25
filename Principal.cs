using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
      //creamos clase principal 
    class Principal
    {//instanciamos
        Valores V = new Valores();
        
        //hacemos metodo para pedir los valores
        public void PedirValor()
        {
           //mensaje y captur de datos
            Console.WriteLine("Dame valor A");
            V.VALORa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame valor B");
            V.VALORb = Convert.ToDouble(Console.ReadLine());

            Menu();
            
        }

        //instanciamos 
        Operacion rt = new Operacion();
        //menu de opciones 
        public void Menu()
        {
            Console.WriteLine("Menu de opciones");
            Console.WriteLine("1-Sumar");
            Console.WriteLine("2-Restar");
            Console.WriteLine("3-Multiplicar");
            Console.WriteLine("4-Dividir");
            Console.WriteLine("5-Salir");
            double Res;
            // captura de opcion
            Console.WriteLine("Dame opcion: ");
            Operacion OP2 = new Operacion();
            int Op = Convert.ToInt32(Console.ReadLine());

            switch (Op)
            {   //casos donde se cmanda a llamar al metodo y se envia el resultado que esta en otra clase
                case 1:
                    Res = OP2.suma(V);
                    Console.WriteLine("el resultado es: " + Res);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 2:
                    Res = OP2.restar(V);
                    Console.WriteLine("el resultado es: " + Res);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 3:
                    Res = OP2.multiplicar(V);
                    Console.WriteLine("el resultado es: " + Res);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 4:
                    Res = OP2.dividir(V);
                    Console.WriteLine("el resultado es: " + Res);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 5:
                    //codigo para salir
                    Environment.Exit(0);
                    break;

            }
        }



    }
}
