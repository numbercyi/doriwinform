using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class CBase
    {
        public string strName;

        protected Pen _Pen;

        public CBase()
        {
            _Pen = new Pen(Color.Aqua);
        }


    }
}
