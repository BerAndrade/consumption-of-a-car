using System;

namespace consumoautomovel
{
    class Program
    {
        static void Main(string[] args)
        {
            double D, V, C;
            Console.WriteLine("***CONSUMO DE UM CARRO EM KM/L***");
            Console.Write("\nEntre com a distância percorrida em KM: ");
            D = double.Parse(Console.ReadLine());
            Console.Write("\nEntre com o volume de combustível consumido: ");
            V = double.Parse(Console.ReadLine());
            C = D / V;
            Console.WriteLine("\nO consumo do automóvel é de: {0} km/l", C);
            Console.ReadKey();
        }
    }
}
