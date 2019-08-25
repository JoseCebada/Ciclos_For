using System;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, final, avance;
            Console.WriteLine("Indroduzca el valor donde iniciara el ciclo");
            inicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIndroduzca el valor donde terminara el ciclo");
            final = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIndroduzca el valor del avance del ciclo");
            avance = Convert.ToInt32(Console.ReadLine());


            if (inicio > final)
            {
                Console.WriteLine("\n-------> Ciclo segun sus condiciones <------- \n");
                for(int i = inicio; i >= final; i-=avance)
                {
                    Console.WriteLine("> i = " + i );
                }
            }
            else if (inicio < final)
            {
                Console.WriteLine(" < Ciclo segun sus condiciones > ");
                for (int i = inicio; i <= final; i+=avance)
                {
                    Console.WriteLine("> i = " + i);
                }
            }
            else
            {
                Console.WriteLine(inicio);
            }
        }
    }
}
