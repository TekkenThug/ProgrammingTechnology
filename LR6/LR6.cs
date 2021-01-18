using System;
using System.Windows.Forms;
using DLLProjectMassiv;
using Microsoft.VisualBasic;

namespace Theory
{
    public partial class LR6 : Form
    {
        public LR6()
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
        private int[] newChisla;
        private int dlinaMassiva;

        private void button2_Click(object sender, EventArgs e)
        {
            
            dlinaMassiva = Convert.ToInt32(Interaction.InputBox("Введите количество элементов массива", "Ввод", "", -1));
            Chisla = new int[dlinaMassiva];
            newChisla = new int[dlinaMassiva];

            Massiv.zapolnitMassiv(Chisla, dlinaMassiva);
            int count = Massiv.Raschet(Chisla);

            newChisla = Massiv.RaschetMassiva(Chisla, newChisla, count);

            Massiv.zapolnitDataGridView(Chisla, dataGridView1);
            Massiv.zapolnitDataGridView(newChisla, dataGridView2);
   
            MessageBox.Show("Количество пар: " + count, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Massiv.createDB();
            Massiv.createTableDB();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Massiv.Add_pdf(dlinaMassiva, Chisla, newChisla);
            Massiv.ZapisBloknot(dlinaMassiva, Chisla, "Исходный массив");
            Massiv.ZapisBloknot(dlinaMassiva, newChisla, "Результирующий массив");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Massiv.addNoteDB(Chisla, newChisla);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Massiv.ZapisWordIsx(dlinaMassiva, Chisla, "Исходный массив");
            Massiv.ZapisWordIsx(dlinaMassiva, newChisla, "Результирующий массив");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Massiv.ZapisExcel(Chisla, newChisla);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Massiv.FormatExcel(dlinaMassiva);
        }
    }
}
