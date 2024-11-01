using ExercicioAbstracao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAbstracao.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Cor cor) : base(cor) 
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
