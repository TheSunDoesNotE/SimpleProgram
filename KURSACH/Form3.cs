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

namespace KURSACH
{
    public partial class Form3 : Form
    {
        public Form3(string Record)
        {
            InitializeComponent();
            

        }
        public string Rcrds;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string path = @"Records.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                label1.Text=reader.ReadToEnd();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Main = new Form1();
            Main.Show();
            this.Hide();
        }
    }
}
