using System.Collections.Generic;
using System.Linq;
using System;

namespace PrimeraAsignacion
{
    class MinimosCuadrados
    {
        static double SumatoriaA(List<double> A)
        {
            return A.Sum();
        }
        static double SumatoriaAB(List<double> A,List<double> B)
        {
            double res = 0;
            for (int i = 0; i < A.Count; i++)
            {
                res += A[i] * B[i];
            }
            return res;
        }
        static double SumatoriaAcuadrado(List<double> A)
        {
            double res = 0;
            foreach (double item in A)
            {
                res += Math.Pow(item,2);
            }
            return res;
        }
       
        static void Main(string[] args)
        {
            
            int N;
            Console.WriteLine("Escriba la cantidad de años de venta anteriores: ");
            N = int.Parse(Console.ReadLine());
            List<double> X = new List<double>(N);
            List<double> Y = new List<double>(N);
            for (int i = 0; i < N; i++)
            {
                X.Add(i + 1);
                Console.WriteLine("Año " + (i + 1) + ": ");
                Console.WriteLine("Cantidad en Ventas: ");
                Y.Add(double.Parse(Console.ReadLine()));
            }
            double a, b;
            b = ((N * SumatoriaAB(X, Y)) - (SumatoriaA(X) * SumatoriaA(Y))) / (((N * SumatoriaAcuadrado(X)) - Math.Pow(SumatoriaA(X), 2)));
            a = (SumatoriaA(Y) - (b * SumatoriaA(X))) / N;
            a = Math.Round(a, 2);
            b = Math.Round(b, 2);
            Console.WriteLine("La formula de la recta es y = "+b+" + "+a+"x");

            //Calculando Crecimiento
            double c = (b * N) / SumatoriaA(Y);
            c = Math.Round(c, 2);
            Console.WriteLine("El crecimiento por promedio es del: " + c * 100 + "%");
            Console.ReadKey();
          
        }
    }
}
