using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Inheritance
{
    class CCycle : CBase
    {
        public Rectangle _rtCircle1; //바퀴
        public Rectangle _rtCircle2;
        public Rectangle _rtSquare1; // 몸통

        public CCycle(string sName)
        {

            strName = sName;
            _Pen = new Pen(Color.Black, 3);

            _rtCircle1 = new Rectangle(30, 150, 120, 120);
            _rtCircle2 = new Rectangle(210, 150, 120, 120);
            _rtSquare1 = new Rectangle(60, 90, 240, 60);



        }
        public Pen fPenInfo()
        {

            return _Pen;
        }

        /// <summary>
        /// 외부에서 호출 가능 하도록
        /// </summary>
        /// <param name="iMove"></param>
        public void fMove(int iMove)
        {
            fCircle1Move(iMove);
            fCircle2Move(iMove);
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
        protected void fCircle2Move(int iMove)
        {
            Point oPoint = _rtCircle2.Location;

            oPoint.X = oPoint.X + iMove;

            _rtCircle2.Location = oPoint;

        }
        protected void fSquare1Move(int iMove)
        {
            Point oPoint = _rtSquare1.Location;

            oPoint.X = oPoint.X + iMove;

            _rtSquare1.Location = oPoint;

        }

    }
}
