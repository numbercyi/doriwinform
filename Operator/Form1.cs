using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iResult = 0;
            int iTemp = int.Parse(tboxResult.Text);
            int iNumber = int.Parse(tboxNumber.Text);

            iResult = iTemp << iNumber;

            tboxResult.Text = iResult.ToString();


        }

        private void tboxResult_TextChanged(object sender, EventArgs e)
        {
            tboxResultBit.Text = Convert.ToString(int.Parse(tboxResult.Text), 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iResult = 0;
            int iTemp = int.Parse(tboxResult.Text);
            int iNumber = int.Parse(tboxNumber.Text);

            iResult = iTemp >> iNumber;

            tboxResult.Text = iResult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int itemp = int.Parse(tboxResult.Text);
            int iNumber = int.Parse(tboxNumber.Text);

            itemp += iNumber;

            tboxResult.Text = itemp.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int itemp = int.Parse(tboxResult.Text);
            int iNumber = int.Parse(tboxNumber.Text);

            itemp -= iNumber;

            tboxResult.Text = itemp.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int itemp = int.Parse(tboxResult.Text);
            

            tboxResult.Text = (++itemp).ToString();
            tboxResultAfter.Text = itemp.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int itemp = int.Parse(tboxResult.Text);


            tboxResult.Text = (itemp++).ToString();
            tboxResultAfter.Text = itemp.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int iTemp1 = int.Parse(tboxResult.Text);
            int iTemp2 = int.Parse(tboxResultAfter.Text);
            int iNumber = int.Parse(tboxNumber.Text);

            bool bResult = (iTemp1 > iNumber) && (iTemp2 > iNumber);

            tboxAndOr.Text = bResult.ToString();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int iTemp1 = int.Parse(tboxResult.Text);
            int iTemp2 = int.Parse(tboxResultAfter.Text);
            int iNumber = int.Parse(tboxNumber.Text);

            bool bResult = (iTemp1 > iNumber) || (iTemp2 > iNumber);

            tboxAndOr.Text = bResult.ToString();
        }
    }
}
