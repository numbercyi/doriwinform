using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struct_Class
{
    struct structPlayer
    {
        public int iCount;

        public int iSun;
        public int iMoon;
        public int iStar;

        public int iCardSum;

        //public int Cardsum(int iSun, int iMoon, int iStar)
        //{
        //    return iSun + iMoon + iStar;
        //}


        //public string ResultText()
        //{
        //    return string.Format("{0}회 해: {1}, 달: {2}, 별: {3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
        //}

    }




    public partial class Form1 : Form
    {

        CPlayer _clPlayer1 = new CPlayer();
        CPlayer _clPlayer2 = new CPlayer();
        structPlayer _stPlayer1;
       /structPlayer _stPlayer2;
        Random _rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void pboxSun_Click(object sender, EventArgs e)
        {
          
            int iNumber = _rd.Next(1, 21);

            if(rdoPlayer1.Checked)
            {
                _stPlayer1.iSun = iNumber;
              
            }
            else
            {
                _stPlayer2.iSun = iNumber;
               
            }
            Result();
           //iCheckedChange();
        }

        private void pboxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iMoon = iNumber;
            }
            else
            {
                _stPlayer2.iMoon = iNumber;
            }
            Result();
           // iCheckedChange();
        }

        private void pboxStar_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iStar = iNumber;
            }
            else
            {
                _stPlayer2.iStar = iNumber;
            }
            Result();
            //iCheckedChange();
        }

        private void iCheckedChange()
        {
            if(rdoPlayer1.Checked)
            {
                rdoPlayer2.Checked = true;
            }
            else
            {
                rdoPlayer1.Checked = true;
            }
        }
        CPlayer cPlayer = new CPlayer();
        private void Result()
        {
            string strResult = string.Empty;

            if(rdoPlayer1.Checked)
            {
                _stPlayer1.iCount++;

                _stPlayer1.iCardSum = cPlayer.Cardsum(_stPlayer1.iSun, _stPlayer1.iMoon, _stPlayer1.iStar);

               // _stPlayer1.iCardSum = iCardSum;

                strResult = cPlayer.ResultText();

                lboxResult1.Items.Add(strResult);
            }
            else
            {
                _clPlayer2.iCount++;

                _clPlayer2.iCardSum = _clPlayer2.Cardsum(_clPlayer2.iSun, _clPlayer2.iMoon, _clPlayer2.iStar);

                // _stPlayer1.iCardSum = iCardSum;

                strResult = _clPlayer2.ResultText();

                lboxResult2.Items.Add(strResult);
            }

            if(_clPlayer1.iCount >= 5 && _clPlayer2.iCount >=5)
            {
               
            }
            iCheckedChange();

        }

    }
}
