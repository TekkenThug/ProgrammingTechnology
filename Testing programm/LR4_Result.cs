using System;
using System.Windows.Forms;
using Test;

namespace Theory
{
    public partial class LR4_Result : Form
    {
        public LR4_Result()
        {
            InitializeComponent();
        }

        private void LR4_Result_Load(object sender, EventArgs e)
        {
           Methods.VivodResult(dataGridView1, label1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form LR4 = new LR4();
           Methods.PerehodNaFormu(this, LR4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Methods.ExportPDF();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Methods.createDB();
            Methods.createUserResultDB();
        }
    }
}
