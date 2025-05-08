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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();   // Limpia la lista
            int i = 1;

            while (i <= 20)
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();   // Limpia la lista
            int i = 1;

            while(i <= 20)
                if (i % 2 == 1)
                {
                    listBox1.Items.Add(i);                
                }
            i++;
        }
    }
}
