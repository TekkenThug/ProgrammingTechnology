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
    public partial class LR4_12 : Form
    {
        public LR4_12()
        {
            InitializeComponent();
        }

        private static bool emptyTrack = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (emptyTrack)
            {
                Methods.OtvetNaVopros("12", "");
            }
            else if (hScrollBar1.Value == 2)
            {
                Methods.OtvetNaVopros("12", "Верно");
                Form LR4_13 = new LR4_13();
                Methods.PerehodNaFormu(this, LR4_13);
            }
            else
            {
                Methods.OtvetNaVopros("12", "Неверно");
                Form LR4_13 = new LR4_13();
                Methods.PerehodNaFormu(this, LR4_13);
            }
        }

        private void LR4_12_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            emptyTrack = false;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = "Ваш ответ: " + Convert.ToString(hScrollBar1.Value);
        }
    }
}
