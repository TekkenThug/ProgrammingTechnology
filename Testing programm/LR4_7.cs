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
    public partial class LR4_7 : Form
    {
        public LR4_7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                Methods.OtvetNaVopros("7", "");
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                Methods.OtvetNaVopros("7", "Верно");
                Form LR4_8 = new LR4_8();
                Methods.PerehodNaFormu(this, LR4_8);
            }
            else
            {
                Methods.OtvetNaVopros("7", "Неверно");
                Form LR4_8 = new LR4_8();
                Methods.PerehodNaFormu(this, LR4_8);
            }
        }
    }
}
