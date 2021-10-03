using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases_con_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Crear instancia de la clase Circle
            Circle circle = new Circle();

            circle.radius = 2.50;
            circle.shapeColor = "azul";
            circle.shapeCoord = true;


            MessageBox.Show(circle.draw("círculo", "lápiz"), "Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(circle.draw(), "Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(circle.setColor(), "Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(circle.getInfo(), "Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(circle.rotate(), "Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(circle.computeArea(), "Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);



            //Crear instancia de la clase Line
            Line line = new Line();

            line.length = 15.5;
            line.shapeColor = "verde";
            line.shapeCoord = false;

            MessageBox.Show(line.draw("línea", "lapicero"), "Información de la línea", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(line.draw(), "Información de la línea", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(line.setColor(), "Información de la línea", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(line.getInfo(), "Información de la línea", MessageBoxButtons.OK, MessageBoxIcon.Information);




            //Crear instancia de la clase Triangle
            Triangle triangle = new Triangle();

            triangle.angle = 50;
            triangle.shapeColor = "gris";
            triangle.shapeCoord = true;

            MessageBox.Show(triangle.draw("triángulo", "pincel"), "Información del triángulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(triangle.draw(), "Información del triángulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(triangle.setColor(), "Información del triángulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(triangle.getInfo(), "Información del triángulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(triangle.computeArea(), "Información del triángulo", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}