using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a=5;
            listBox1.Items.Add("exemplo pré-incremental");
            listBox1.Items.Add("valor de a="+a);
            listBox1.Items.Add("2+ ++a=" + (2 + ++a));
            listBox1.Items.Add("valor de a=" + a);
            listBox1.Items.Add(new string('-', 50));

            a = 5;
            listBox1.Items.Add("exemplo pós-incremental");
            listBox1.Items.Add("valor de a=" + a);
            listBox1.Items.Add("2+ a++ =" + (2 + a++));
            listBox1.Items.Add("valor de a=" + a);
            listBox1.Items.Add(new string('-', 50));

            a = 5;
            listBox1.Items.Add("exemplo pré-decremental");
            listBox1.Items.Add("valor de a=" + a);
            listBox1.Items.Add("2+ --a =" + (2 + --a));
            listBox1.Items.Add("valor de a=" + a);
            listBox1.Items.Add(new string('-', 50));

            a = 5;
            listBox1.Items.Add("exemplo pós-decremental");
            listBox1.Items.Add("valor de a=" + a);
            listBox1.Items.Add("2+ a-- =" + (2 + a--));
            listBox1.Items.Add("valor de a=" + a);
            listBox1.Items.Add(new string('-', 50));
        }

       
    }
}
