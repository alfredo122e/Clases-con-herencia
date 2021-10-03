using System;
using System.Collections.Generic;
using System.Text;

namespace Clases_con_herencia
{
    class Shape
    {
        //Propiedades
        public string shapeColor { get; set; }
        public Boolean shapeCoord { get; set; }


        //Constructores
        public Shape(string color, Boolean coord)
        {
            shapeColor = color;
            shapeCoord = coord;
        }

        public Shape()
        { }

        //Métodos
        public string getInfo()
        {
            var coord = "";
            if (shapeCoord == true)
            {
                coord = "si tiene área";
            }
            else
            {
                coord = "no tiene área";
            }
            return "La forma posee el color " + shapeColor +
                " y " + coord;
        }
        public virtual string draw()
        {
            return "La forma ha sido dibujada.";
        }

        //Este método se debe sobreescribir
        public string draw(string name, string owner)
        {
            return "La figura " + name +
                " está siendo dibujada con " + owner;
        }


        public string rotate()
        {
            return "La forma debe rotar.";
        }

        public virtual string setColor()
        {
            return "A la forma debe de establecerse color.";
        }
    }
}