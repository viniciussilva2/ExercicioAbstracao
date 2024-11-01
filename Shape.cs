using ExercicioAbstracao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExercicioAbstracao.Entities
{
    public abstract class Shape
    {

        public Cor Cor { get; set; }
             
        public Shape(Cor cor)
        {
            Cor = cor;
        }

        public abstract double Area();

    }
}
