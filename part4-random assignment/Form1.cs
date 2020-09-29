using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part4_random_assignment
{
    public partial class frm1 : Form
    {
        Random generator = new Random();


        
        public frm1()
        {
            InitializeComponent();
        }

       

        

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void txtboxmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            int max = Convert.ToInt32(txtboxmax.Text);
            int min = Convert.ToInt32(txtboxmin.Text); 
       
            lblNumber.Text = generator.Next(min, max + 1) + "";
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
        //    double min = Conv
        //    double max = Conv
        //    double randomDouble = generator.NextDouble() * (max - min) + min;
        //    lblNumber.Text = randomDouble.ToString();
        //}
    }
}
