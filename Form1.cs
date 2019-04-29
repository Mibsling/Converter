using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txtConverter.Text);
            double Answer = Fah(amount);
            lblConvert.Text = Answer.ToString() + " Fahrenheit";
        }

        private double Fah(double amount)
        {
            
            double Answer = (amount * 9 / 5) + 32;
            return Answer;  
        }
    }
}
