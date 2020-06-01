using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   


    public class Shapes
    {

        public double ShapesArea()
        {
            return 0;
        }

        public double ShapesArea(double a, double b, double c, double d)
        {
            var CircleRad = Math.Pow((Math.Pow((d - b), 2) + Math.Pow((c - a), 2)), 0.5);
            return CircleRad * CircleRad * Math.PI;
        }


        public double ShapesArea(double a, double b, double c, double d, double e, double f)
        {
            return Math.Abs((a*(d-f) + c*(f-b) + e*(b-d)) / 2);  
        }


        public double ShapesArea(double a, double b, double c, double d, double e, double f, double g, double h)
        {
            return Math.Abs((a*(d-f) + c*(f-b) + e*(b-d)) / 2) + Math.Abs((e*(h-b) + g*(b-f) + a*(e-g)) / 2);
        }


    }

    
}

    