using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_Mennu_WhileDP_5toB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // String es un tipo de dato para almacenar texto
            String texto = txtTexto.Text;
            int i, = 1;
            listBox1Items.Clear();

            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add($"{ i}.{texto}")
                i++;
                }
            }
        }
    }
}
