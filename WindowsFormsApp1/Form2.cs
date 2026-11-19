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
    public partial class Form2 : Form
    {
        public Form2(double danielle, double edward, double fatima)
        {
            InitializeComponent();

            label1.Text = "Danielle: " + danielle.ToString("C");
            label2.Text = "Edward: " + edward.ToString("C");
            label3.Text = "Fatima: " + fatima.ToString("C");

            double total = danielle + edward + fatima;
            label4.Text = "Grand total: " + total.ToString("C");
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
