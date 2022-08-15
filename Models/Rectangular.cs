using System;
using System.Collections.Generic;
using System.Text;

namespace _16AugHomeWork.Models
{
    class Rectangular : Figure
    {
        private decimal _width;

        public decimal Width
        {
            get { return _width; }
            set 
            {
                if (value>0)
                {
                    _width = value;
                }
            }
        }
        private decimal _length;

        public decimal Length
        {
            get { return _length; }
            set 
            {
                if (value>0)
                {
                    _length = value;
                }
            }
        }
        public Rectangular(decimal Width, decimal Length)
        {
            this.Width = Width;
            this.Length = Length;
        }


        public override decimal CalcArea()
        {
            return Width * Length;
        }
    }
}
