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
    public partial class task9 : Form
    {
        public task9()
        {
            InitializeComponent();
        }

        int[] Mas = new int[35];
        int[] Mas2 = new int[35];
        int r = 0;
        int s = 0;
        int p = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 35; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                this.listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();
            for (int i = 0; i < 35; i++)
            {
                if (Mas[i] %2 == 0 && Mas[i] < 3)
                {
                    Mas2[i] = Mas[i];
                }
                else if (Mas[i] %2 != 0 && Mas[i] > 1)
                {
                    Mas2[i] = Mas[i];
                }
                
            }
            
            this.listBox2.Items.Add($"{Mas2.Sum()}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void task9_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
