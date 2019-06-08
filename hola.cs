using System;

namespace PruebaPaEstudiar
{
    class Program1
    {
        static float a, b;
        static void Main1(string[] args)
        {
            Console.WriteLine("Escribe una cantidad en Q");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el cambio del Q a $");
            b = float.Parse(Console.ReadLine());

            Popo(a, b);
        }
        static private void Popo(float m, float n)
        {
            float r;
            r = m * n;
            Console.WriteLine("La suma de " + m + " + el numero " + n + " es: " + r);
        }
    }
}