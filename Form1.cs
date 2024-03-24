using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HATA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int y1, y2;
                double ort;
                y1 = Convert.ToInt16(textBox1.Text);
                y2 = Convert.ToInt16(textBox2.Text);
                ort = (y1 + y2) / 2;
                label3.Text = ort.ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }
    }
}
