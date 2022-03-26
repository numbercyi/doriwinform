using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Override_Overload
{
    class CCycle : COneCycle
    {
       
        public Rectangle _rtCircle2;
        

        public CCycle(string sName) : base(sName)
        {

            strName = sName;
            _Pen = new Pen(Color.Black, 3);

            _rtCircle1 = new Rectangle(30, 150, 120, 120);
            _rtCircle2 = new Rectangle(210, 150, 120, 120);
            _rtSquare1 = new Rectangle(60, 90, 240, 60);



        }
        

        /// <summary>
        /// 외부에서 호출 가능 하도록
        /// </summary>
        /// <param name="iMove"></param>
        public override void fMove(int iMove)
        {
            base.fMove(iMove);
            fCircle2Move(iMove);
        }

        /// <summary>
        /// 내부에서만 움직인다.
        /// </summary>
        /// <param name="iMove"></param>
        
        protected void fCircle2Move(int iMove)
        {
            Point oPoint = _rtCircle2.Location;

            oPoint.X = oPoint.X + iMove;

            _rtCircle2.Location = oPoint;

        }
       

    }
}
