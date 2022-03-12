using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            try
            {
                short sNumber = short.Parse(textBoxNumber.Text);
                lblShort.Text = sNumber.ToString();
                lblException.Text = "-";
            }
            catch( Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            try
            {
                int sNumber = int.Parse(textBoxNumber.Text);
                lblInt.Text = sNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            try
            {
                double sNumber = double.Parse(textBoxNumber.Text);
                lblDouble.Text = sNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnauto_Click(object sender, EventArgs e)
        {
            short sNumber = 0;
            int iNumber = 0;
            double dNumber = 0;

            lblException.Text = "-";
            if(short.TryParse(textBoxNumber.Text,out sNumber))
            {
                lblShort.Text = sNumber.ToString();

            }
            else if(int.TryParse(textBoxNumber.Text, out iNumber))
            {
                lblInt.Text = iNumber.ToString();
            }    
            else if(double.TryParse(textBoxNumber.Text, out dNumber))
            {
                lblDouble.Text = dNumber.ToString();
            }
            else
            {
                lblException.Text = "변환 할수 없음";
            }
        }
    }
}
