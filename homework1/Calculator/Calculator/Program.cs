using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个运算数：");
            string first_num;
            float first_num1;
            while (true)
            {
                first_num = Console.ReadLine();
                try
                {
                 first_num1 = Convert.ToSingle(first_num);
            }
            catch (Exception)
            {
                    Console.WriteLine("您输入的不是数字，请重新输入");
                continue;
            }
                break;
            }
            Console.WriteLine("请输入第二个运算数：");
            string second_num;
            float second_num1;
            while (true)
            {
                second_num = Console.ReadLine();
                try
                {
                 second_num1 = Convert.ToSingle(second_num);
                }
                catch (Exception)
                {
                    Console.WriteLine("您输入的不是数字，请重新输入");
                    continue;
                }
                break;
            }
            Console.WriteLine("请输入运算符（仅支持加减乘除模）");
            while (true) {
                string Calculation = Console.ReadLine();
                if (Calculation == "+"){
                float result = first_num1 + second_num1;
                Console.WriteLine(result);
                    break;
            }

            else if (Calculation == "-")
            {
                float result = first_num1 + second_num1;
                Console.WriteLine(result);
                    break;
            }

            else if (Calculation == "*")
            {
                float result = first_num1 * second_num1;
                Console.WriteLine(result);
                    break;
            }

            else if (Calculation == "/")
            {
                float result = first_num1 / second_num1;
                Console.WriteLine(result);
                    break;
            }

            else if (Calculation == "%")
            {
                float result = first_num1 % second_num1;
                Console.WriteLine(result);
                    break;
            }

            else
            {
                    Console.WriteLine("您输入的不是一个合法的运算符，请重新输入");
                    continue;
            }
            }

        }
    }
}
