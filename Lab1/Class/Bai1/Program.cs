using System;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            Shape[] G = new Shape[n];
            for (int i = 0; i < n; i++)
            {
                int type = rnd.Next(0, 5);
                double S = 0;
                switch(type)
                {
                    case 1:
                        G[i] = new Rectangle(i); G[i].Read();
                        break;
                    case 2:
                        G[i] = new Triangle(i); G[i].Read();
                        break;
                    case 3:
                        G[i] = new Circle(i); G[i].Read();
                        break;
                    case 4:
                        G[i] = new Square(i); G[i].Read();
                        break;
                }
            }
            for (int i = 0; i < n; ++i)
            {
                G[i].Draw();
                Console.WriteLine("Area: " + G[i].Area());
            }
        }
    }
}