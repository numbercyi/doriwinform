using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Override_Overload
{
    class COneCycle : CBase
    {
        public Rectangle _rtCircle1; //바퀴
        public Rectangle _rtSquare1; // 몸통

        public COneCycle(string sName)
        {
            
            strName = sName;
            _Pen = new Pen(Color.WhiteSmoke, 3);

            _rtCircle1 = new Rectangle(120, 150, 120, 120);
            _rtSquare1 = new Rectangle(150, 30, 60, 120);



        }
       
        /// <summary>
        /// 외부에서 호출 가능 하도록
        /// </summary>
        /// <param name="iMove"></param>
        public virtual void fMove(int iMove)
        {
            fCircle1Move(iMove);
            fSquare1Move(iMove);
        }

        /// <summary>
        /// 내부에서만 움직인다.
        /// </summary>
        /// <param name="iMove"></param>
        protected void fCircle1Move(int iMove)
        {
            Point oPoint = _rtCircle1.Location;

            oPoint.X = oPoint.X + iMove;

            _rtCircle1.Location = oPoint;

        }
        protected void fSquare1Move(int iMove)
        {
            Point oPoint = _rtSquare1.Location;

            oPoint.X = oPoint.X + iMove;

            _rtSquare1.Location = oPoint;

        }

        public Pen fPenInfo()
        {
            return _Pen;
        }
        public Pen fPenInfo(Color oColor)
        {
            _Pen = new Pen(oColor);
            return _Pen;
        }
        public Pen fPenInfo(Color oColor, int iWidth)
        {
            _Pen = new Pen(oColor, iWidth);
            return _Pen;
        }
    }
}
