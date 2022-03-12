using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Class
{
    class CPlayer
    {
        public int iCount = 0;

        public int iSun = 0;
        public int iMoon = 0;
        public int iStar = 0;

        public int iCardSum;

        public int Cardsum(int iSun, int iMoon, int iStar)
        {
            return iSun + iMoon + iStar;
        }


        public string ResultText(int iCount, int iSun, int iMoon, int iStar, int iCardSum)
        {
            return string.Format("{0}회 해: {1}, 달: {2}, 별: {3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
        }

        public string PlayerPair(int iCount, int iP1CardSum, int iP2CardSum)
        {
            int iCheck = iP1CardSum - iP2CardSum;

            if(iCheck >0)
            {
                return string.Format("{0}회차 : Play 1이 {1}만큼 더 큽니다.", iCount, iCheck);

            }
            else if(iCheck <0)
            {
                return string.Format("{0}회차 : Play 2가 {1} 만큼 더 큽니다.", iCount, Math.Abs(iCheck));
            }
            else
            {
                return string.Format("{0}회차 : Play 1가 Play 2의 값이 같습니다.", iCount);
            }
        }

        public string PlayerResult(int iP1CardSum, int iP2CardSum)
        {

            string strReturn = string.Empty;
            if (iP1CardSum > iP2CardSum)
            {
                strReturn = "Player1이 이겼습니다.";

            }
            else if (iP1CardSum < iP2CardSum)
            {
                strReturn = "Player2이 이겼습니다.";
            }
            else
            {
                strReturn = "비겼습니다.";
            }
            return strReturn;
        }
    }
}
