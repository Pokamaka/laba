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
    public partial class task8 : Form
    {
        public task8()
        {
            InitializeComponent();
        }

        int[] Mas = new int[25];
        int[] Mas2 = new int[25];
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 25; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                this.listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();
            for (int i = 0; i < 25; i++)
            {
                if (Mas[i] < 0)
                {
                    count++;
                }
                else if (Mas[i] >= 1 && Mas[i] <= 2)
                {
                    Mas2[i] = Mas[i];
                    this.listBox2.Items.Add("Mas [" + Convert.ToString(i) + "] = " + Mas2[i].ToString());
                }
            }
            this.listBox2.Items.Add($"Кол-во отрицательных {count}");
        }

        private void task8_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
