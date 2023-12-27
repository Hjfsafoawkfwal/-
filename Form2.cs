using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Мебельная_фабрика
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Добавьте элемент");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt (listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Выберите элемент");
            }
        }
    }
}
