using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACT01.AXIOMA
{
    class Program
    {
        static void Main(string[] args)
        {

            DISTANCIA P = new DISTANCIA();
            string s;
           
            do
            {
                Console.Write("\n DISTANCIAS ENTRE DOS PUNTOS \n ");
                Console.Write("\n INGRESA LAS CORDENADAS DE LOS PUNTOS : \n");
                try
                {                    
                        Console.Write("A : "); P.A = Double.Parse(Console.ReadLine());
                        Console.Write("B : "); P.B = Double.Parse(Console.ReadLine());
                        Console.Write("C : "); P.C = Double.Parse(Console.ReadLine());
                        Console.Write("D : "); P.D = Double.Parse(Console.ReadLine());                 
                        Console.Clear();
                }
                catch (FormatException e) { Console.WriteLine(e.Message); }

                finally
                {                  
                    P.IMPRIMIR();
                   
                }

                Console.WriteLine("\n ____________________________________________\n");
                Console.WriteLine("DESEA INGRESAR NUEVOS VALORES ? : (s/n) ");
                s = Console.ReadLine(); // El programa pregunta si se desea volver a ejecutar
            }
            while (s == "s" || s == "S");
            Console.Clear();
        }
    }   
}
