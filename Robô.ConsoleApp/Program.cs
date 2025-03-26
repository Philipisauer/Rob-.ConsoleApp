namespace Robô.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int posicaoX1 = 1;
            int posicaoY1 = 2;

            Console.WriteLine("digite a cordenada X: ");
            int X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite a cordenada Y: ");
            int Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite a direçao: ");
            double direcao = Convert.ToDouble(Console.ReadLine());



            posicaoX1 += X;
            posicaoY1 += Y;

            Console.WriteLine($"X:{posicaoX1}");

            Console.WriteLine($"Y:{posicaoY1}");

            Console.WriteLine($"direcao:{direcao}");

            if ( posicaoX1 > 50 )
                Console.WriteLine("posiçao ultrapassa o limite!");

            if (posicaoY1 > 50)
                Console.WriteLine("posiçao ultrapassa o limite");

            Console.ReadLine();
        }
    }
}
