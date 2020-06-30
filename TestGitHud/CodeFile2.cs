using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLabClasess
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int[] fl = new int[3] { 1, 2, 3 };
            arr = fl;
            Console.WriteLine(arr[0]);
            Console.ReadKey();
        }
    }

    class Triangle
    {
        const int SizeArrCoords = 3;
        private double[] coordsX = new double[SizeArrCoords];
        private double[] coordsY = new double[SizeArrCoords];

        Triangle()
        {
            for (int i = 0; i < SizeArrCoords; i += 3)
            {
                coordsX[i] += i;
                if (i % 2 == 0)
                    coordsY[i] = i;
                else coordsY[i] = 0;
            }
        }

        public bool SetCoords()
        {
            string input1;
            string input2;

            for (int i = 0; i < SizeArrCoords; i++)
            {
                Console.WriteLine(" (x;y)  = ");
                input1 = Console.ReadLine();
                input2 = Console.ReadLine();
                try
                {
                    coordsX[i] = double.Parse(input1);
                    coordsY[i] = double.Parse(input2);
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("Не верный ввод чисел, попробуйте ещё разок!");
                    return false;
                }
            }
            return true;
        }
        public void ShowCoords()
        {
            for (int i = 0; i < SizeArrCoords; i++)
                Console.WriteLine(i + 1 + ") (" + coordsX[i] + ";" + coordsY[i] + ") ;\n");
        }

        public void GetLengthSide()
        {
            double lenght;

            for (int i = 0; i < SizeArrCoords; i++)
            {
                for (int j = 0; j < SizeArrCoords; j++)
                {
                    // реализация lenght; 
                    Console.WriteLine("Треугольник №" + (i + 1) + " и его длинна стороны " + (j + 1) + " равна: " + lenght + "\n");
                }
            }
        }
    }
}
