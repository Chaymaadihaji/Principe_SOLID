using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Apres
{
    public class Square : Shape
    {
        private readonly int side;

        public Square(int side)
        {
            this.side = side;
        }

        public override int Area()
        {
            return side * side;
        }
    }
}
