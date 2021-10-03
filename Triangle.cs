using System;
using System.Collections.Generic;
using System.Text;

namespace Clases_con_herencia
{
    class Triangle:Shape
    {
        //Propiedades
        public float angle { get; set; }

        public Triangle() { }
        public Triangle(string color, Boolean coord, float angle)
            : base(color, coord) //Herencia de constructor
        {

        }


        //Crear métodos
        public string computeArea()
        {
            Double area;
            area = (180 - angle) / 2;
            return "El ángulo del triángulo es: " + area;
        }

        //metodo sobreescrito
        public override string draw()
        {

            return "El triángulo ha sido dibujado";
        }

    }
}