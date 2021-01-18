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
    public partial class LR4_9 : Form
    {
        public LR4_9()
        {
            InitializeComponent();
        }

        private static bool emptyTrack = true;

        private void button1_Click(object sender, EventArgs e)
        {

            if (emptyTrack)
            {
                Methods.OtvetNaVopros("9", "");
            }
            else if (trackBar1.Value == 3)
            {
                Methods.OtvetNaVopros("9", "Верно");
                Form LR4_10 = new LR4_10();
                Methods.PerehodNaFormu(this, LR4_10);
            }
            else
            {
                Methods.OtvetNaVopros("9", "Неверно");
                Form LR4_10 = new LR4_10();
                Methods.PerehodNaFormu(this, LR4_10);
            }
        }

        private void trackBar1_Enter(object sender, EventArgs e)
        {
            emptyTrack = false;
        }

        private void LR4_9_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Ваш ответ: " + Convert.ToString(trackBar1.Value);
        }
    }
}
