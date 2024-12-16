using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_01
{
    internal class CCalculadora
    {
        //Declaramos los atributos
        public double a;
        public double b;
        private double r;

        //Declaramos los metodos 
        public void Suma()
        {
            r = a + b;
        }
        public void Muestra()
        {
            Console.WriteLine("a={0},b={1},c={2}",a,b,r);
                }

    }
}
