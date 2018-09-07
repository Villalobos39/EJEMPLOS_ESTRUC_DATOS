using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACT01.AXIOMA
{
    class DISTANCIA
    {
        Double a, b, c, d, r; // puntos de la recta 
        public Double A
        { get { return a; } set { a = value; } }
        public Double B
        { get { return b; } set { b = value; } }
        public Double C
        { get { return c; } set { c = value; } }
        public Double D
        { get { return d; } set { d = value; } }
        public Double R
        { get { return r; } set { r = value; } }

        public DISTANCIA() { }
        public DISTANCIA(Double a, Double c, Double b, Double d, Double r)
        { a = A; b = B; c = C; d = D; r = R; }

        public Double CALCULAR()
        {           
            return R = Math.Sqrt((Math.Pow(C-A,2)) + (Math.Pow(D-B,2)));
        }
        public void IMPRIMIR()
        {
            Console.Write(" \n DISTANCIAS ENTRE DOS PUNTOS \n ");
            Console.Write("P (A,B ) ; ( "+ a + " , "+ b + " ) \n");
            Console.Write("P (C,D ) ; ( "+ c + " , "+ d +" ) \n");
            Double r = CALCULAR();
            Console.Write("LA DISTANCIA ENTRE PUNTOS ES :  " + r);
            Console.ReadKey();
        }
        ~DISTANCIA() { }
    }
}
