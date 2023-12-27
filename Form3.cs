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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (var item in listBox1.Items) 
            {
                if (item.ToString() == textBox1.Text)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                MessageBox.Show("Найдено");
            }
            else
            {
                MessageBox.Show("Не найдено");
            }
        }
    }
}
