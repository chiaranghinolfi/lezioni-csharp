using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClassi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Monster m = new Monster("Strongbonna", 10, 50);
            Monster m2 = new Monster("Tizio", 56, 10);

            //textBox1.Text = m2.describe();
            m.describe(textBox1);
        }
    }
}
