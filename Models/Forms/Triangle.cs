﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShape.Models.Forms
{
    public class Triangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Height * Width / 2;
        }
    }
}
