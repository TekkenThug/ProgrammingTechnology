using System;
using System.Windows.Forms;
using Test;

namespace Theory
{
    public partial class LR4_11 : Form
    {
        public LR4_11()
        {
            InitializeComponent();
        }

        private static bool emptyTrack = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (emptyTrack)
            {
                Methods.OtvetNaVopros("11", "");
            }
            else if (hScrollBar1.Value == 2003)
            {
                Methods.OtvetNaVopros("11", "Верно");
                Form LR4_12 = new LR4_12();
                Methods.PerehodNaFormu(this, LR4_12);
            }
            else
            {
                Methods.OtvetNaVopros("11", "Неверно");
                Form LR4_12 = new LR4_12();
                Methods.PerehodNaFormu(this, LR4_12);
            }
        }

        private void LR4_11_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = "Ваш ответ: " + Convert.ToString(hScrollBar1.Value);
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            emptyTrack = false;
        }
    }
}
