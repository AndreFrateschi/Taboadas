using System;

namespace tabuadasimples
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            double numero;
            Console.WriteLine("digite o numero");

            numero = double.Parse(Console.ReadLine());

            for (int i = 0; i < 9999999; i++)
            {
                double total = numero * i;
                Console.WriteLine(numero + " X " + i + " = " + total);

            }


            Console.WriteLine("Hello World!");
        }
    }
}
