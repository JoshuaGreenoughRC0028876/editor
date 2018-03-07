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


namespace editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text Files|*.txt;";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)


            {
                try

                {
                    using (StreamReader sr = new StreamReader(@"H:\test.txt"))
                    {
                        richTextBox1.Clear();
                        while (!sr.EndOfStream)
                        {
                            String line = sr.ReadLine();
                            richTextBox1.AppendText(line + "\n");
                        }
                    }

                }


                catch
                {
                    MessageBox.Show()openFileDialog1.FileName + " failed to open.");
                }
            }
        }
    }
}
