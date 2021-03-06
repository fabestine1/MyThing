using System;

namespace Interfaces_And_Abstraction_Exerciese
{
    class Program
    {
        static void Main()
        {
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            IDrawable rect = new Rectangle(width, height);

            circle.Draw();

            rect.Draw();
        }

    }
}
            