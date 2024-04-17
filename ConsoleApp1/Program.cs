using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double largura, altura, total;

            Console.Write("Digite a largura: ");
            largura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            total = Convert.ToDouble(largura * altura);
            Console.Write("A area do retangulo é "+ total);
            Console.ReadKey();
        }
    }
}
