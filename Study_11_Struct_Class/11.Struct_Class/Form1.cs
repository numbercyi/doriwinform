using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11.Struct_Class
{

    public partial class Form1 : Form
    {
        // Player에 대한 구조체
        struct structPlayer
        {
            public int iCount;  // Player가 몇회 진행 중인지

            public int iSun;  // 해에 대한 값
            public int iMoon;  // 달에 대한 값
            public int iStar;  // 별에 대한 값

            public int iCardSum;  // 해, 달, 별을 더한 값

            // 값들을 더해서 반환
            public int CardSun(int iSum, int iMoon, int iStar)
            {
                return iSun + iMoon + iStar;
            }

            // 결과를 String 형태로 변환 (화면에 결과를 보여주기 위해 사용)
            public string ResultText()
            {
                return string.Format("{0}회) 해:{1}, 달:{2}, 별:{3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
            }
        }


        // Player에 대한 Class (실제 프로그램 동작과는 관계 없음)
        class classPlayer
        {
            public int iCount = 0;  // Player가 몇회 진행 중인지

            public int iSun = 2;  // 해에 대한 값
            public int iMoon = 3;  // 달에 대한 값
            public int iStar = 3;  // 별에 대한 값

            public int iCardSum = 4;  // 해, 달, 별을 더한 값

            // 값들을 더해서 반환
            public int CardSun(int iSum, int iMoon, int iStar)
            {
                return iSun + iMoon + iStar;
            }

            // 결과를 String 형태로 변환 (화면에 결과를 보여주기 위해 사용)
            public string ResultText()
            {
                return string.Format("{0}회) 해:{1}, 달:{2}, 별:{3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
            }
        }

        structPlayer _stPlayer1;  //1번 Player
        structPlayer _stPlayer2;  //2번 Player

        Random _rd = new Random();  // 난수 발생용

        classPlayer _clPlayer1 = new classPlayer();  //Test 용 
        classPlayer _clPlayer2 = new classPlayer();  //Test 용 


        /// <summary>
        /// 프로그램의 진입점 입니다.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 화면에서 "해" 그림을 Click 했을 때 Event를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxSun_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            //어떤 Player가 선택 되어 있는지 확인
            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iSun = iNumber;

                //_clPlayer1.iSun = iNumber;
            }
            else
            {
                _stPlayer2.iSun = iNumber;

                //_clPlayer2.iSun = iNumber;
            }

            Result();
        }


        /// <summary>
        /// 화면에서 "달" 그림을 Click 했을 때 Event를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            //어떤 Player가 선택 되어 있는지 확인
            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iMoon =iNumber;
            }
            else
            {
                _stPlayer2.iMoon = iNumber;
            }

            Result();
        }


        /// <summary>
        /// 화면에서 "별" 그림을 Click 했을 때 Event를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxStar_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            //어떤 Player가 선택 되어 있는지 확인
            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iStar =iNumber;
            }
            else
            {
                _stPlayer2.iStar = iNumber;
            }

            Result();
        }


        /// <summary>
        /// 화면에서 "빈" 그림을 Click 했을 때 Event를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxNone_Click(object sender, EventArgs e)
        {
            // 아무짓도 안하고 한턴을 넘긴다

            Result();
        }

        
        /// <summary>
        /// 현재 선택 된 Radio Button을 확인해서 선택되지 않은 Radio Button을 선택하기 위해 사용
        /// </summary>
        private void iCheckedChange()
        {
            //어떤 Player가 선택 되어 있는지 확인
            if (rdoPlayer1.Checked)
            {
                rdoPlayer2.Checked = true;
            }
            else
            {
                rdoPlayer1.Checked = true;
            }
        }


        /// <summary>
        /// 선택 된 Radio Button에 대해서 해, 달, 별의 값을 더하고 결과를 내용으로 만들어서 ListBox에 표시
        /// </summary>
        private void Result()
        {
            string strResult = string.Empty;

            //어떤 Player가 선택 되어 있는지 확인
            if (rdoPlayer1.Checked)  
            {
                _stPlayer1.iCount++;  // Player에 대한 진행 횟수를 증가

                _stPlayer1.iCardSum = _stPlayer1.CardSun(_stPlayer1.iSun, _stPlayer1.iMoon, _stPlayer1.iStar);  // 해, 달, 별의 값을 더해서 Player에 ICradSum에 넣어줌

                strResult = _stPlayer1.ResultText();  // 결과 값을 string 형태로 변환

                lboxResult1.Items.Add(strResult);  // 결과 값을 listbox에 등록
            }
            else
            {
                _stPlayer2.iCount++;

                _stPlayer2.iCardSum = _stPlayer2.CardSun(_stPlayer2.iSun, _stPlayer2.iMoon, _stPlayer2.iStar);

                strResult = _stPlayer2.ResultText();

                lboxResult2.Items.Add(strResult);
            }

            iCheckedChange();  // 다음 Player 선택

            // 결과를 체크 (Player1과 2의 진행 횟수가 5회가 넘어갈 경우 각 Player의 iCard Sum 값을 비교해서 결과를 화면에 Popup 합니다.
            if (_stPlayer1.iCount >= 5 && _stPlayer2.iCount >= 5)
            {
                if (_stPlayer1.iCardSum > _stPlayer2.iCardSum)
                {
                    MessageBox.Show("Player1이 이겼습니다.");
                }
                else if (_stPlayer1.iCardSum < _stPlayer2.iCardSum)
                {
                    MessageBox.Show("Player2가 이겼습니다.");
                }
                else
                {
                    MessageBox.Show("비겼습니다.");
                }
            }
        }
    }
}
