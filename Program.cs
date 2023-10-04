using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el varo n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i= 1; i <= n; i++) 
            {
                float resultado = (16 - i) / (3.0f * i);
                Console.WriteLine($"Resultado {i}: {resultado:F2}");

            }
        }
    }
}
