using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            int n = 3, ang1 = 60, ang2 = 120;
                for (int i = 0; i < n; i++)
                {
                    Turtle.Angle += ang2;
                    Turtle.Move(100);
                    Turtle.Angle -= ang1;
                    Turtle.Move(100);
                    Turtle.Angle -= ang2;
                    Turtle.Move(100);
                    Turtle.Angle -= ang1;
                    Turtle.Move(100);
                }
        }
    }
}
