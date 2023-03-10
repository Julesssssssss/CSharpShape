using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShape.Models.Forms
{
    public class Square : Shape
    {
        public int Width { get; set; }

        public override double Area()
        {
            return Math.Pow(Width, 2);
        }
    }
}
