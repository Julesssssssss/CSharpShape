using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShape.Models
{
    public class AreaCalculator
    {
        public double TotalArea(Shape[] arrShape)
        {
            double area = 0;
            
            foreach (var objShape in arrShape)
            {
                area += objShape.Area();
            }
            return area;
        }
        
    }
}
