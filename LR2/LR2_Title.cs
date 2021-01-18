using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theory
{
    public partial class LR2_Title : Form
    {
        public LR2_Title()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            double ploshad = 0;
            double ax = ClassLibrary1.Class1.Vvod(textBox1);
            double ay = ClassLibrary1.Class1.Vvod(textBox2);
            double bx = ClassLibrary1.Class1.Vvod(textBox3);
            double by = ClassLibrary1.Class1.Vvod(textBox4);
            double cx = ClassLibrary1.Class1.Vvod(textBox5);
            double cy = ClassLibrary1.Class1.Vvod(textBox6);
            double dx = ClassLibrary1.Class1.Vvod(textBox7);
            double dy = ClassLibrary1.Class1.Vvod(textBox8);
            double ex = ClassLibrary1.Class1.Vvod(textBox9);
            double ey = ClassLibrary1.Class1.Vvod(textBox10);
            ClassLibrary1.Class1.Ploshad5Ugolnika(ax, ay, bx, by, cx, cy, dx, dy, ex, ey, ref ploshad);
            ClassLibrary1.Class1.Vivod(textBox11, ploshad);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double ploshad;
            double ax = ClassLibrary1.Class1.Vvod(textBox1);
            double ay = ClassLibrary1.Class1.Vvod(textBox2);
            double bx = ClassLibrary1.Class1.Vvod(textBox3);
            double by = ClassLibrary1.Class1.Vvod(textBox4);
            double cx = ClassLibrary1.Class1.Vvod(textBox5);
            double cy = ClassLibrary1.Class1.Vvod(textBox6);
            double dx = ClassLibrary1.Class1.Vvod(textBox7);
            double dy = ClassLibrary1.Class1.Vvod(textBox8);
            double ex = ClassLibrary1.Class1.Vvod(textBox9);
            double ey = ClassLibrary1.Class1.Vvod(textBox10);
            ClassLibrary1.Class1.Ploshad5UgolnikaOut(ax, ay, bx, by, cx, cy, dx, dy, ex, ey, out ploshad);
            ClassLibrary1.Class1.Vivod(textBox12, ploshad);
        }
    }
}
