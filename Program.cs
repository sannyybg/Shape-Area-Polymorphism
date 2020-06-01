using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = new Shapes();
            Console.WriteLine(g.ShapesArea(6, 3, 2, 4));
            Console.WriteLine(g.ShapesArea(3, 8, 1, 5, 6, -1));
            Console.WriteLine(g.ShapesArea(-2, -3, -6, 4, 5, 3, 6, -1));

            Console.ReadKey();



            /* Shapes[] myshapes = new Shapes[3];
            myshapes[0] = [2, 3, 5, 6];
            myshapes[1] = [-5, 1, -2, 5, 6, -1];
            myshapes[2] = [-4, -2, -1, 3, 6, 6, 4, -1];



            for (int i = 0; i < myshapes.Length; i++)
               {
               
                var sh = myshapes[i];
                Console.WriteLine(sh.ShapesArea());
               }

            */

        }   

    }
}
