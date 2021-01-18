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
    public partial class LR4_10 : Form
    {
        public LR4_10()
        {
            InitializeComponent();
        }

        private static bool emptyTrack = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (emptyTrack)
            {
                Methods.OtvetNaVopros("10", "");
            }
            else if (trackBar1.Value == 1967)
            {
                Methods.OtvetNaVopros("10", "Верно");
                Form LR4_11 = new LR4_11();
                Methods.PerehodNaFormu(this, LR4_11);
            }
            else
            {
                Methods.OtvetNaVopros("10", "Неверно");
                Form LR4_11 = new LR4_11();
                Methods.PerehodNaFormu(this, LR4_11);
            }
        }

        private void LR4_10_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void trackBar1_Enter(object sender, EventArgs e)
        {
            emptyTrack = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Ваш ответ: " + Convert.ToString(trackBar1.Value);
        }
    }
}
