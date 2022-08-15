using System;
using System.Collections.Generic;
using System.Text;

namespace _16AugHomeWork.Models
{
    class Square:Figure
    {
        private decimal _side;

        public decimal Side
        {
            get { return _side; }
            set 
            {
                if (value>0)
                {
                    _side = value;
                }
            }
        }
        public Square(decimal Side)
        {      
             this.Side = Side;       
        }

        public override decimal CalcArea()
        {
            return Side * Side;
        }
    }
}
