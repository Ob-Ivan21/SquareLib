using System;

namespace SquareLib
{
    class Program
    {
        //test example
        static void Main(string[] args)
        {
            double[] argument = { 5, 7, 15 };
            //Console.WriteLine("Hello World!");
            Console.WriteLine(SquareLibrary.getSquare(argument));
        }
    }

    class SquareLibrary
    {
        //Хотелось сделать под разные типы, но Pow ест только дабл, в TODO
        public static double getSquare(double[] args)
        {
            switch (args.Length)
            {
                case 1:
                    return Math.PI * Math.Pow(args[0], 2);
                case 3:
                    //Формула Герона
                    return Math.Sqrt((args[0] + args[1] + args[2]) * (args[0] + args[1]) * (args[1] + args[2]) * (args[0] + args[2])) / 4.0;
                //Вообще определять тип фигуры по числу аргументов -- очень не полный подход
                default:
                    break;
            }

            return 0;
        }

        public static bool checkTriangle(double[] args)
        {
            if (args.Length != 3)
                return false;

            //Сумма квадратов сторон
            double squareSum = Math.Pow(args[0], 2) + Math.Pow(args[1], 2) + Math.Pow(args[2], 2);
            //Квадрат гепотинузы
            double squareMax = Math.Max(Math.Max(Math.Pow(args[0], 2), Math.Pow(args[1], 2)), Math.Pow(args[2], 2));
            if (squareSum == 2 * squareMax)
                return true;
            else
                return false;
        }
    }
}
