using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1_archi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClickHere_Click(object sender, EventArgs e)
        {
            string l1 = textBox1.Text;
            string l2 = textBox2.Text;

            string bd = textBox4.Text;
            int bds = Convert.ToInt32(bd);
            int year = 2022 - bds;

            string text = "! В этом году тебе ";

            string welcome = l1 + ' ' + l2 + text + year.ToString() + " лет";
            textBox3.Text = welcome;
        }
    }
}
