using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter text = new StreamWriter
                  ("D:\\C-Homeworks\\Homeworks_8\\WinForms\\WinForms\\Info.txt", true))
            {
                text.WriteLine("User details: ");
                string[] write = new string[] 
                { (label1.Text + ": " + textBox1.Text),
                  (label2.Text + ": " + textBox2.Text), 
                  (label3.Text + ": " + textBox3.Text) };

                foreach (var item in write)
                {
                    text.WriteLine(item);
                }
                text.WriteLine();
            }
        }
    }
}
