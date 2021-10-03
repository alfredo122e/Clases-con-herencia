using System;
using System.Collections.Generic;
using System.Text;

namespace Clases_con_herencia
{
    class Circle : Shape
    {
        //Propiedades
        public Double radius { get; set; }

        public Circle() { }
        public Circle(string color, Boolean coord, double radiusCircle)
            : base(color, coord) //Herencia de constructor
        {
            radius = radiusCircle;
        }

        //Métodos
        public string computeArea()
        {
            Double pi, area;
            pi = 3.1415;
            area = pi * Math.Pow(radius, 2);
            return "El área del círculo es: " + area;
        }

        //Método sobreescrito
        public override string draw()
        {
            return "El círculo ha sido dibujado.";
        }
    }
}