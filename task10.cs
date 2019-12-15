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
    public partial class task10 : Form
    {
        public task10()
        {
            InitializeComponent();
        }

        int[] Mas = new int[20];
        int[] Mas2 = new int[20];
      
        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                this.listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                if (Mas[i] %7 == 1.0 || Mas[i] %7 == 2.0 || Mas[i] %7 == 5.0)
                {
                    Mas2[i] = Mas[i];
                }
                this.listBox2.Items.Add("Mas [" + Convert.ToString(i) + "] = " + Mas2[i].ToString());
            }           
        }

        private void task10_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
