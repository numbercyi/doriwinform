using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Stirng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strText = lblText.Text;

            lblContain.Text = strText.Contains("Text").ToString();
            lblEquals.Text = strText.Equals("Text").ToString();
            lblLength.Text = strText.Length.ToString();
            lblReplace.Text = strText.Replace("Text", "I Can").ToString();

            string[] StrSplit = strText.Split(',');
            lblSplit1.Text = StrSplit[0];
            lblSplit2.Text = StrSplit[1];
            lblSplit3.Text = StrSplit[2];

            lblSubstring.Text = strText.Substring(3, 5).ToString();
            lblToLower.Text = strText.ToLower().ToString();
            lblToUpper.Text = strText.ToUpper().ToString();

            lblTrim.Text = strText.Trim().ToString();
            

        }
    }
}
