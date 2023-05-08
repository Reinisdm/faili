using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ieiet(object sender, EventArgs e)
        {
            string user = comboBox1.Text;
            string pass = textBox1.Text;
            if((user == pass) && (user != ""))
            {
                Form newForm = new Form2();
                newForm.Show();
            }

        }
    }
}
