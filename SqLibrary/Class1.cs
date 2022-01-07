using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqLibrary
{
    public class Square
    {
        public static void triangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Round(Math.Sqrt((p * (p - a) * (p - b) * (p - c))), 2);;
            MessageBox.Show("Площадь треугольника равна: " + S);

        }
        public static void circle(int r)
        {
            double pi = 3.14;
            double S = pi * Math.Pow(r, 2);
            MessageBox.Show("Площадь круга равна: " + S);
        }


    }
}
