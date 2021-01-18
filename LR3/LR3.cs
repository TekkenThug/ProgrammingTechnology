using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLProject1;

namespace Theory
{
    public partial class LR3 : Form
    {
        public LR3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ay1 = DLLProject1.Class1.Vvod(textBox1);
            double ay2 = DLLProject1.Class1.Vvod(textBox2);
            double by1 = DLLProject1.Class1.Vvod(textBox3);
            double by2 = DLLProject1.Class1.Vvod(textBox4);
            double cy1 = DLLProject1.Class1.Vvod(textBox5);
            double cy2 = DLLProject1.Class1.Vvod(textBox6);
            double az1 = DLLProject1.Class1.Vvod(textBox7);
            double az2 = DLLProject1.Class1.Vvod(textBox8);
            double bz1 = DLLProject1.Class1.Vvod(textBox9);
            double bz2 = DLLProject1.Class1.Vvod(textBox10);
            double cz1 = DLLProject1.Class1.Vvod(textBox11);
            double cz2 = DLLProject1.Class1.Vvod(textBox12);
            double x = DLLProject1.Class1.Vvod(textBox13);
            double y = 0;
            double z = 0;
            DLLProject1.Class1.FunctionY(ay1, ay2, by1, by2, cy1, cy2, x, ref y);
            DLLProject1.Class1.FunctionZ(az1, bz1, cz1, az2, bz2, cz2, x, ref z);
            DLLProject1.Class1.Vivod(textBox14, y);
            DLLProject1.Class1.Vivod(textBox15, z);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double ay1 = DLLProject1.Class1.Vvod(textBox1);
            double ay2 = DLLProject1.Class1.Vvod(textBox2);
            double by1 = DLLProject1.Class1.Vvod(textBox3);
            double by2 = DLLProject1.Class1.Vvod(textBox4);
            double cy1 = DLLProject1.Class1.Vvod(textBox5);
            double cy2 = DLLProject1.Class1.Vvod(textBox6);
            double az1 = DLLProject1.Class1.Vvod(textBox7);
            double az2 = DLLProject1.Class1.Vvod(textBox8);
            double bz1 = DLLProject1.Class1.Vvod(textBox9);
            double bz2 = DLLProject1.Class1.Vvod(textBox10);
            double cz1 = DLLProject1.Class1.Vvod(textBox11);
            double cz2 = DLLProject1.Class1.Vvod(textBox12);
            double x = DLLProject1.Class1.Vvod(textBox13);
            DLLProject1.Class1.FunctionY2(ay1, ay2, by1, by2, cy1, cy2, x, out double y);
            DLLProject1.Class1.FunctionZ2(az1, bz1, cz1, az2, bz2, cz2, x, out double z);
            DLLProject1.Class1.Vivod(textBox16, y);
            DLLProject1.Class1.Vivod(textBox17, z);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
