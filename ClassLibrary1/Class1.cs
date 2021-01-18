using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Class1
    {
        public static double Vvod(TextBox t)
        {
            return Convert.ToDouble(t.Text);
        }
        public static void Vivod(TextBox t, double c)
        {
            t.Text = Convert.ToString(c);
        }

        public static double Ploshad3Ugolnika(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double rezultat;
            return rezultat = Math.Abs(((x2 - x1) * (y3 - y1)) - ((x3 - x1) * (y2 - y1))) * (0.5);
        }

        public static void Ploshad5Ugolnika(double Ax, double Ay, double Bx, double By, double Cx, double Cy, double Dx, double Dy, double Ex, double Ey, ref double ploshad)
        {
            double treugolnik1 = Ploshad3Ugolnika(Ax, Ay, Bx, By, Cx, Cy);
            double treugolnik2 = Ploshad3Ugolnika(Ax, Ay, Cx, Cy, Dx, Dy);
            double treugolnik3 = Ploshad3Ugolnika(Ax, Ay, Dx, Dy, Ex, Ey);
            ploshad = treugolnik1 + treugolnik2 + treugolnik3;
        }

        public static void Ploshad5UgolnikaOut(double Ax, double Ay, double Bx, double By, double Cx, double Cy, double Dx, double Dy, double Ex, double Ey, out double ploshad)
        {
            double treugolnik1 = Ploshad3Ugolnika(Ax, Ay, Bx, By, Cx, Cy);
            double treugolnik2 = Ploshad3Ugolnika(Ax, Ay, Cx, Cy, Dx, Dy);
            double treugolnik3 = Ploshad3Ugolnika(Ax, Ay, Dx, Dy, Ex, Ey);
            ploshad = treugolnik1 + treugolnik2 + treugolnik3;
        }
    }
}
