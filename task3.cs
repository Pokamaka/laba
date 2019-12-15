using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace задание_1
{
    public partial class task3 : Form
    {
        public task3()
        {
            InitializeComponent();
        }

        double[] Mas = new double[18];

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 18; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                this.listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();
            for (int i = 0; i < 18; i++)
            {

                Mas[i] = 0.13 * Math.Pow(Mas[i], 3) - 2.5 * Mas[i] + 8;

                this.listBox2.Items.Add("Mas [" + Convert.ToString(i) + "] = " + Mas[i].ToString());
            }
        }

        private void task3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
