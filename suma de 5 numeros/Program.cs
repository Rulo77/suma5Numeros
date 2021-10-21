using System;


namespace suma_de_5_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int n;
            int acu = 0;
            while (num <= 5)
            {
                Console.WriteLine("introduce el " + num + " numero");
                n = int.Parse(Console.ReadLine());
                acu = acu + n;

                num++;
            }
            Console.WriteLine("la suma de los 5 numeros es: " + acu);
            Console.ReadKey();
        }
    }
    
}
