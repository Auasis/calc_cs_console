using System;
using static System.Console;

namespace calc
{
    class Program
    {
        static int oprtr;
        static double oper_a;
        static double oper_b;
        public static double reshatel(float operatr, double operand_a, double operand_b)
        {

            switch (operatr)
            {
                case 1:
                    return operand_a + operand_b;
                case 2:
                    return operand_a - operand_b;
                case 3:
                    return operand_a * operand_b;
                case 4:
                    return operand_a / operand_b;
                default:
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            bool error = false;
            do
            {
                Write("введите операнд 1: ");
                try
                {
                    oper_a = Convert.ToDouble(ReadLine());
                    error = false;
                }
                catch
                {
                    WriteLine("введи число ");
                    error = true;
                }
            }
            while (error);
            do
            {
                do
                {
                    WriteLine("выберите в функцию\r\n 1-сложение\r\n 2-вычитание\r\n 3-умножение \r\n 4-деление\r\n 5-завершить ");
                    Write("введите оператор: ");
                    try
                    {
                        oprtr = Convert.ToInt16(ReadLine());
                        error = false;
                    }
                    catch
                    {
                        WriteLine("выберите число");
                        error = true;
                    }
                }
                while (error);

                if (oprtr == 5 || oprtr > 5 || oprtr < 1)
                {
                    WriteLine($"ответ ={oper_a}");
                    break;
                }
                Write("введите операнд 2: ");
                do
                {
                    try
                    {
                        oper_b = Convert.ToDouble(ReadLine());
                        error = false;
                    }
                    catch
                    {
                        WriteLine("введи число ");
                        error = true;
                    }
                }
                while (error);
                oper_a = reshatel(oprtr, oper_a, oper_b);
                WriteLine($"ответ = {oper_a}");
            }
            while (oprtr != 5);
        }

    }
}
