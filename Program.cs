using ExercicioAbstracao.Entities;
using System;
using System.Globalization;
using System.ComponentModel;
using ExercicioAbstracao.Entities.Enums;


namespace HelloWorldApp
{
    class Program
    {
        // Método Main: ponto de entrada do programa
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color: (Black/Blue/Red)? ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());

                if(ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, cor));

                } else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, cor));
                }

                Console.WriteLine();
                Console.WriteLine("SHAPE AREAS: ");
               
            }

            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
