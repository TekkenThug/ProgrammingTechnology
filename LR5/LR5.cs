using System;
using System.Windows.Forms;
using DLLProjectMassiv;
using Microsoft.VisualBasic;

namespace Theory
{
    public partial class LR5 : Form
    {
        public LR5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }

        private int[] Chisla;
        private int dlinaMassiva;

        private void button2_Click(object sender, EventArgs e)
        {
            dlinaMassiva = Convert.ToInt32(Interaction.InputBox("Введите количество элементов массива", "Ввод", "", -1));
            Chisla = new int[dlinaMassiva];

            Massiv.zapolnitMassiv(Chisla, dlinaMassiva);
            int count = Massiv.Raschet(Chisla);

            Massiv.zapolnitDataGridView(Chisla, dataGridView2);
            MessageBox.Show("Количество пар: " + count, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
