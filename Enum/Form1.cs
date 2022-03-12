using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enumDay
        {
            Monday, //0
            Tuesday, //1
            Wednesday, //2
            Thusday, //3
            Friday, //4
            Saturday, //5
            Sunday, //6
        }

        enum enumTime
        {
            Morining,
            Afternoon,
            Evening
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lBoxDay.Items.Add(enumDay.Monday.ToString());
            lBoxDay.Items.Add(enumDay.Tuesday);
            lBoxDay.Items.Add(enumDay.Wednesday);
            lBoxDay.Items.Add(enumDay.Thusday);
            lBoxDay.Items.Add(enumDay.Friday);
            lBoxDay.Items.Add(enumDay.Saturday);
            lBoxDay.Items.Add(enumDay.Sunday);

            lboxTime.Items.Add(enumTime.Morining);
            lboxTime.Items.Add(enumTime.Afternoon);
            lboxTime.Items.Add(enumTime.Evening);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            //준호와 Monday(요일) Afternoon에 보기로 했습니다.

            string strResult = tboxName.Text + "와 " + lBoxDay.SelectedItem.ToString() + "(요일) " + lboxTime.SelectedItem.ToString() + "에 보기로 했습니다.";


            tboxResult.Text = strResult;

            Console.WriteLine(tboxResult.Text);

        }

        private void btnResult2_Click(object sender, EventArgs e)
        {
            //string strResult = string.Format("]")
            //string strResult = $"{tboxName.Text}와 {lBoxDay.SelectedItem.ToString()}(요일) {lboxTime.SelectedItem.ToString()}에 보기로 했습니다.";
            string strResult = TextLoad(tboxName.Text, lBoxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString());
            tboxResult.Text = strResult;
        }
        /// <summary>
        /// 준호와 Monday(요일) Afternoon에 보기로 했습니다. 같은 문자열을 만들어줍니다.
        /// </summary>
        /// <param name="strName">이름</param>
        /// <param name="strday">날짜</param>
        /// <param name="strTime">시간</param>
        /// <returns></returns>
        private string TextLoad(string strName, string strday, string strTime)
        {
            string stText = $"{strName}와 {strday}(요일) {strTime}에 보기로 했습니다.";
            return stText;
        }
    }
}
