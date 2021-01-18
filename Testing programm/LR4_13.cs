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
    public partial class LR4_13 : Form
    {
        public LR4_13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                Methods.OtvetNaVopros("13", "");
            }
            else if (
                checkedListBox1.CheckedIndices.Count == 3 && 
                checkedListBox1.CheckedIndices.Contains(0) && 
                checkedListBox1.CheckedIndices.Contains(3) &&
                checkedListBox1.CheckedIndices.Contains(4)
                )
            {

                Methods.OtvetNaVopros("13", "Верно");
                Form LR4_14 = new LR4_14();
                Methods.PerehodNaFormu(this, LR4_14);
            }
            else
            {

                Methods.OtvetNaVopros("13", "Неверно");
                Form LR4_14 = new LR4_14();
                Methods.PerehodNaFormu(this, LR4_14);
            }
        }
    }
}
