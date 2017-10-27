using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.ServiceReference1;
namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        ServiceCalculatorClient proxy = new ServiceCalculatorClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblResult.Text = proxy.AddNumbers(Convert.ToDouble(txtNumber1.Text.ToString()), Convert.ToDouble(txtNumber2.Text.ToString())).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                lblResult.Text = proxy.SubstractNumbers(Convert.ToDouble(txtNumber1.Text.ToString()), Convert.ToDouble(txtNumber2.Text.ToString())).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Wrong Input");
            }
           
        }
    }
}
