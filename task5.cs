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
    public partial class task5 : Form
    {
        public task5()
        {
            InitializeComponent();
        }

        int[] Mas = new int[30];
        int[] Mas2 = new int[30];

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 30; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                this.listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();
            for (int i = 0; i < 30; i++)
            {
                if (Mas[i] % 5 == 0)
                {
                    Mas2[i] = Mas[i];
                }
            }

            this.listBox2.Items.Add($"{Mas.Sum()}");
        }

        private void task5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
