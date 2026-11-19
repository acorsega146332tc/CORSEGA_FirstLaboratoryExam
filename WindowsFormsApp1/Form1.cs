using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double danielle = 0;
        double edward = 0;
        double fatima = 0;
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1;
            button2.Click += Button2;
            button3.Click += Button3;
        }
        public void getsales(string initialsales, double salesamount)
        {
            initialsales = initialsales.ToUpper();
            if(initialsales == "D") 
            {
                danielle += salesamount;
                label4.Text = "Danielle: " + salesamount.ToString("C") + "\n" +
                    "\nTotal sales: " + danielle + "\n\n";
            }  
            else if(initialsales == "E") 
            {
                edward += salesamount;
                label4.Text = "Edward: " + salesamount.ToString("C") + "\n\n" +
                                    "\nTotal sales: " + edward + "\n";
            }
            else if(initialsales == "F")
            {
                fatima += salesamount;
                label4.Text = "Fatima: " + salesamount.ToString("C") + "\n\n" +
                    "\nTotal sales: " + fatima + "\n";
            } 
            else
            {
                MessageBox.Show("Invalid Initials");
            }
        }
        private void Button1(object sender, EventArgs e)
        {
            string initial = textBox1.Text.Trim();
            double amount;
            if (initial == "" || textBox2.Text == "")
            {
                MessageBox.Show("fill all the fields");
                return;
            }
            if (!double.TryParse(textBox2.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("enter valid input");
                return;
            }
            if (initial.Length != 1 ||
                (initial.ToUpper() != "D" &&
                   initial.ToUpper() != "E" &&
                   initial.ToUpper() != "F"
                    ))
            {
                MessageBox.Show("Enter D, E, F only");
                return;
            }
            getsales(initial, amount);

            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();    
        }
        public void Button2(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
            textBox1.Focus();
        }
        public void Button3(object sender, EventArgs e) {

            Form2 summary = new Form2(danielle, edward, fatima);
            summary.ShowDialog();
        
        }
    }
}
