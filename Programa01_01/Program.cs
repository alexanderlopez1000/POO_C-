using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos una instancia
            CCalculadora calcu1 = new CCalculadora();
            //accedemos a los atributos para mostrar info 
            calcu1.a = 5;
            calcu1.b = 3;
            calcu1.Muestra();
            calcu1.Suma();
            calcu1.Muestra();

        }
    }
}
