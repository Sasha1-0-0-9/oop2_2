using System;

namespace OOP_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TRTriangle trTFromKatets = TRTriangle.Input();
            Console.WriteLine(trTFromKatets);
            Console.WriteLine();
            TRTriangle trTFromKatets2 = TRTriangle.Input();
            Console.WriteLine(trTFromKatets2);

            if (trTFromKatets.GetHashCode() == trTFromKatets2.GetHashCode())
            {
                Console.WriteLine("\nТрикутники рiвнi.\n");
            }
            else
            {
                Console.WriteLine("\nТрикутники не рiвнi.\n");
            }


            Console.Write("Введiть число на яке хочете помножити Трикутники:");
            double num = double.Parse(Console.ReadLine());

            TRTriangle newTr1 = trTFromKatets * num;
            Console.WriteLine();
            Console.WriteLine(newTr1);

            TRTriangle newTr2 = num * trTFromKatets2;
            Console.WriteLine();
            Console.WriteLine(newTr2);

            Console.WriteLine("Створення пiрамiди:");
            TRTriangle triangleForPiramid = TRTriangle.Input();
            Console.WriteLine("Введiть висоту пiрамiди:");
            double h = double.Parse(Console.ReadLine());
            TRPiramid piramida = new TRPiramid(triangleForPiramid, h);
            Console.WriteLine(piramida);

            Console.ReadKey();
        }
    }
}
