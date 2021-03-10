using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient pro = new ServiceReference1.ServiceClient();
            String name = textBox1.Text;
            label2.Text = pro.message(name);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
