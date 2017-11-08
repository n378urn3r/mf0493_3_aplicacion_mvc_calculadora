using System;
using System.Collections.Generic;
using System.Text;

namespace aplicacion_mvc_calculadora
{
    class CalculadoraV
    { public mostrarResultado(float i)
        {
            Console.WriteLine("Resultado:");
            Console.WriteLine(i);
            Console.WriteLine("Pulsa en una tecla para continuar.");
            string s = "";
            s = Console.ReadLine();

        }
        public float recogerValor();
        {   string s= "";
            s = Console.Readline();
            float i =0;

            i = Convert.toInt32();
            }

    }
}
