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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Слово1" && textBox2.Text == "Слово2")
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else if (textBox1.Text == "Слово3" && textBox2.Text == "Слово4")
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Не верный Лоигн или Пароль");
            }
        }
    }
}
