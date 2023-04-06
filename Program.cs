using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareabilletes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            



            Console.WriteLine("Tarea: Billetes ");
            Console.Write("Ingrese cantidad entre 0 a 9,999.99 :         ");
            double cantidad = Convert.ToDouble(Console.ReadLine());
           

            if (cantidad <=9999.99)
            {
                if (cantidad >= 100)
                {
                    double div = cantidad % 100;
                    double almacenado = cantidad - div;
                    cantidad = cantidad - almacenado;
                    Console.WriteLine(almacenado/ 100+"  Billetes de Q100.00");

                }

                if (cantidad >= 50)
                {
                    double div = cantidad % 50;
                    double almacenado = cantidad - div;
                    cantidad = cantidad - almacenado;
                    Console.WriteLine(almacenado / 50 + "  Billetes de Q50.00");



                }
                if (cantidad >= 20)
                {
                    double div = cantidad % 20;
                    double almacenado = cantidad - div;
                    cantidad = cantidad - almacenado;
                    Console.WriteLine(almacenado / 20 + "  Billetes de Q20.00");

                }
                if (cantidad >= 10)
                {
                    double div = cantidad % 10;
                    double almacenado = cantidad - div;
                    cantidad = cantidad - almacenado;
                    Console.WriteLine(almacenado / 10 + "  Billetes de Q10.00");



                }
                if (cantidad >= 5)
                {
                    double div = cantidad % 5;
                    double almacenado = cantidad - div;
                    cantidad = cantidad - almacenado;
                    Console.WriteLine(almacenado / 5 + "  Billetes de Q5.00");


                }
                if (cantidad >= 1)
                {
                    double div = cantidad % 1;
                    double almacenado = cantidad - div;
                    cantidad = cantidad - almacenado;
                    Console.WriteLine(almacenado / 1 + "  Billetes de Q1.00");

                }

                if (cantidad >= 0.25)
                {
                    double div = cantidad % 0.25;
                    double almacenado = cantidad - div;
                    cantidad = cantidad - almacenado;
                    Console.WriteLine(almacenado / 0.25 + "  Monedas de 25 centavos");

                }

                if (cantidad >= 0.01)
                {
                    double div = cantidad % 0.01;
                    double almacenado = cantidad - div;
                    cantidad = cantidad - almacenado;
                    Console.WriteLine(almacenado / 0.01 + "  Monedas de 1 centavo");

                }


            }
            else
            {
                Console.WriteLine("El numero ingresado es invalido");
            }



            Console.ReadKey();
        }
    }
}
