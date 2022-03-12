using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ifTest();
        }
        
        private void switchTest()
        {
            int iRet = 3;

            string strResult = string.Empty;

            switch(iRet)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    strResult = "2";
                    break;
                case 3:
                    strResult = "3";
                    break;
                case 4:
                    break;

                default:
                    break;
                

            }
        }
        private void ifTest()
        {
            int ia = 30;
            int ib = 20;

            string strResult = string.Empty;

            if(ia>ib)
            {
                strResult = "ia가 크다";

            }
            else if(ia<ib)
            {
                strResult = "ib가 크다";

            }
            else
            {
                strResult = "같다";
            }

            strResult = (ia > ib) ? "ib가 크다" : "같다";


            
                

              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inumber1 = (int)numericUpDown1.Value;
            int inumber2 = (int)numericUpDown2.Value;

            if(inumber1 > inumber2)
            {
                label3.Text = string.Format("- Number1이 Number2보다 {0} 더 큽니다.", inumber1-inumber2);

            }
            else if(inumber1 < inumber2)
            {
                label3.Text = string.Format("- Number2이 Number1보다 {0} 더 큽니다.", inumber2 - inumber1);
            }
            else
            {
                label3.Text = string.Format("- 두 숫자는 같습니다. 숫자 : {0}", inumber1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSelect = comboBox1.Text;

            switch(strSelect)
            {
                case "월":
                    label5.Text = "- 섵택 날짜는 월요일 입니다.";
                    break;
                case "화":
                    label5.Text = "- 섵택 날짜는 화요일 입니다.";
                    break;
                case "수":
                    label5.Text = "- 섵택 날짜는 수요일 입니다.";
                    break;
                case "목":
                    label5.Text = "- 섵택 날짜는 목요일 입니다.";
                    break;
                case "금":
                    label5.Text = "- 섵택 날짜는 금요일 입니다.";
                    break;
                case "토":
                    label5.Text = "- 섵택 날짜는 토요일 입니다.";  
                    break;
                case "일":
                    label5.Text = "- 섵택 날짜는 일요일 입니다.";
                    break;
            }
        }
    }
}
