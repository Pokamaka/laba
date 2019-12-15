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
    public partial class task11 : Form
    {
        public task11()
        {
            InitializeComponent();
        }

        int[] Mas = new int[10];
        int[] Mas2 = new int[10];
        int firstot = 0;
        int sum = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                this.listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();        
            firstot = Array.FindIndex(Mas, m => m < 0);
            for (int i = firstot; i < 10; i++)
            {
                sum = sum * Mas[i];              
            }
      
            this.listBox2.Items.Add($"Итого: {sum}");
            this.listBox2.Items.Add($"Итого: {firstot}");
        }

        private void task11_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
