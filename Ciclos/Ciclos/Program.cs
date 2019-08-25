using System;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio = 0, final = 0, avance = 0;
            Console.WriteLine("Indroduzca el valor donde iniciara el ciclo");
            inicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indroduzca el valor donde terminara el ciclo");
            final = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indroduzca el valor del avance del ciclo");
            avance = Convert.ToInt32(Console.ReadLine());


            if (inicio > final)
            {
                Console.WriteLine(" - Ciclo segun sus condiciones - ");
                for(int i = inicio; i >= final; i-=avance)
                {
                    Console.WriteLine("i = " + i);
                }
            }
            else if (inicio < final)
            {
                Console.WriteLine(" - Ciclo segun sus condiciones - ");
                for (int i = inicio; i <= final; i+=avance)
                {
                    Console.WriteLine("i = " + i);
                }
            }
            else
            {
                Console.WriteLine(inicio);
            }
        }
    }
}
