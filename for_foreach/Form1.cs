using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;

            StringBuilder sb = new StringBuilder();

            int iResult = 0;

            for (int i = 0; i < 50; i++)
            {
                iResult = iResult + 1;

                sb.Append(string.Format("1에서 {0}까지 더하면 {1} \r\n", i, iResult));
            }
            textBox1.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;

            StringBuilder sb = new StringBuilder();
            string[] strArray = { "나연", "정연", "모모", "지효", "미나", "다현", "쯔위", "채영"};
            int i = 1;
            foreach (string value in strArray)
            {
                
                sb.Append(string.Format("{0} 선생님은 {1}반 입니다.\r\n", value, i));

                i++;
            }
            textBox1.Text = sb.ToString();
        }
    }
}
