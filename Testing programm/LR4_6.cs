using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;

namespace Theory
{
    public partial class LR4_6 : Form
    {
        public LR4_6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer = textBox2.Text;
            if (answer == "")
            {
                Methods.OtvetNaVopros("6", "");
            }
            else if (answer == "Эмитент")
            {
                Methods.OtvetNaVopros("6", "Верно");
                Form LR4_7 = new LR4_7();
                Methods.PerehodNaFormu(this, LR4_7);
            }
            else
            {
                Methods.OtvetNaVopros("6", "Неверно");
                Form LR4_7 = new LR4_7();
                Methods.PerehodNaFormu(this, LR4_7);
            }
        }
    }
}
