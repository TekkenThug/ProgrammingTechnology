using System;
using System.Windows.Forms;
using Test;

namespace Theory
{
    public partial class LR4_14 : Form
    {
        public LR4_14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                Methods.OtvetNaVopros("14", "");
            }
            else if (
                checkedListBox1.CheckedIndices.Count == 2 &&
                checkedListBox1.CheckedIndices.Contains(0) &&
                checkedListBox1.CheckedIndices.Contains(4)
                )
            {

                Methods.OtvetNaVopros("14", "Верно");
                Form LR4_15 = new LR4_15();
                Methods.PerehodNaFormu(this, LR4_15);
            }
            else
            {

                Methods.OtvetNaVopros("14", "Неверно");
                Form LR4_15 = new LR4_15();
                Methods.PerehodNaFormu(this, LR4_15);
            }
        }
    }
}
