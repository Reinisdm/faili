using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faili
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Title = "Save file as...";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filePath = saveFileDialog1.FileName;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(
                    textBox1.Text + "`" +
                    textBox2.Text + "`" +
                    textBox3.Text + "`" +
                    textBox4.Text + "`" +
                    textBox5.Text + "`" +
                    textBox6.Text 
                    );
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Title = "Select a Text File";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string fileContent = reader.ReadToEnd();
                        string[] lines = fileContent.Split('`');
                        textBox1.Text = lines[0];
                        textBox2.Text = lines[1];
                        textBox3.Text = lines[2];
                        textBox4.Text = lines[3];
                        textBox5.Text = lines[4];
                        textBox6.Text = lines[5];
                    }
                }

            }
        }
    }
}
