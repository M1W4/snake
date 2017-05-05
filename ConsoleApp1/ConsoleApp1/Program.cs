using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace ConsoleApp1
{
    using static Console;

    class Program
    {
        static void Main(string[] args)
        {
            #region ex 1
            //Write("Введите ваше имя:");
            //string name = ReadLine();
            //WriteLine("Привет " + name + " !");
            //ReadLine();
            #endregion
            #region ex 2
            //Write("Введите первое число: ");
            //int value1 = Convert.ToInt32(ReadLine());
            //Write("Введите второе число: ");
            //int value2 = Convert.ToInt32(ReadLine());
            //int result = value1 + value2;
            //WriteLine(value1.ToString() + "+" + value2.ToString() + "=" + result.ToString());
            //ReadKey();
            #endregion
            #region ex 3
            //Write("Введите ваше имя:");
            //string name = ReadLine();
            //if (name == "Сергей Дружко")
            //{
            //    WriteLine("Дратути");
            //}
            //else
            //{
            //    WriteLine("Привет " + name + " !");
            //}
            //ReadLine();
            #endregion
            #region ex 4
            //double[] arr = new double[10];
            //double sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = double.Parse(ReadLine());
            //    sum += arr[i];
            //}
            //Write($"Сумма: {sum}");
            //ReadLine();
            #endregion
            #region ex 5
            Turtle.Speed = 8;
            int n = 6, ang1  = 30, ang2 = 120;
            for (int i = 0; i < 4; i++)
            {
                    Turtle.Angle += ang1;
                    Turtle.Move(100);
                    Turtle.Angle -= ang1;
                    Turtle.Angle -= ang1;
                    Turtle.Move(100);
                    Turtle.Angle -= ang2;
                    Turtle.Move(100);
                    Turtle.Angle -= ang1;
                    Turtle.Angle -= ang1;
                    Turtle.Move(100);
        }

        #endregion
    }
    }
}
