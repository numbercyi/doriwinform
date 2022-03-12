using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArryTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArrayTest();
            ArrayClassTest();

        }

        private void ArrayTest()
        {
            int iDay1 = 0;
            int iDay2 = 0;
            int iDay3 = 0;

            //string strT1 = "가, 나, 다, 라";

            //string[] strTest = strT1.Split(',');
            int[] iArrayTest1 = { 1, 2, 3, 4, 5 };

            int[] iArrayTest2 = new int[5] { 1, 2, 3, 4, 5 };

            int[] iArrayTest3 = new int[5];
            iArrayTest3[2] = 3;
            iArrayTest3[4] = 5;

            int[,] Arrarry4 = new int[2, 4] { { 1, 2, 3, 4 }, { 123, 123, 123, 123 } };
        }

        private void ArrayClassTest()
        {
            int[] iTest = { 10, 20, 30, 40, 50 };

            int i = iTest.Length;

            Array.Clear(iTest, 2, 2);

            Array.Resize(ref iTest, 10);

            int str = Array.IndexOf(iTest, 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgDay.Rows.Clear();
            int[] iTest = { 10, 5, 30, 4, 15, 22, 18 };

            lblArrayCount.Text = string.Format("전체 자료 수 : {0}", iTest.Length.ToString());
            dgDay["colday1", 0].Value = iTest[0];
            dgDay["colday2", 0].Value = iTest[1];
            dgDay["colday3", 0].Value = iTest[2];
            dgDay["colday4", 0].Value = iTest[3];
            dgDay["colday5", 0].Value = iTest[4];
            dgDay["colday6", 0].Value = iTest[5];
            dgDay["colday7", 0].Value = iTest[6];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgDay.Rows.Clear();
            int[,] iTest = { { 10, 5, 30, 4, 15, 22, 18 }, { 11, 51, 31, 14, 11, 21, 11 } };

            lblArrayCount.Text = string.Format("전체 자료 수 : {0}", iTest.Length.ToString());
            dgDay.Rows.Add();

            dgDay["colday1", 0].Value = iTest[0, 0];
            dgDay["colday2", 0].Value = iTest[0, 1];
            dgDay["colday3", 0].Value = iTest[0, 2];
            dgDay["colday4", 0].Value = iTest[0, 3];
            dgDay["colday5", 0].Value = iTest[0, 4];
            dgDay["colday6", 0].Value = iTest[0, 5];
            dgDay["colday7", 0].Value = iTest[0, 6];

            dgDay["colday1", 1].Value = iTest[0, 0];
            dgDay["colday2", 1].Value = iTest[0, 1];
            dgDay["colday3", 1].Value = iTest[0, 2];
            dgDay["colday4", 1].Value = iTest[0, 3];
            dgDay["colday5", 1].Value = iTest[0, 4];
            dgDay["colday6", 1].Value = iTest[0, 5];
            dgDay["colday7", 1].Value = iTest[0, 6];

        }
    }
}
