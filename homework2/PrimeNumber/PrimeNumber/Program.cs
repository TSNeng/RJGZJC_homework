using System;

namespace PrimeNumber
{
    class PrimeNumber
    {
        int num;

        static void Main(string[] args)
        {
            PrimeNumber prime_number = new PrimeNumber();

            Console.WriteLine("请输入一个数字");

            string a_num = Console.ReadLine();

            prime_number.num = Convert.ToInt32(a_num);

            int[] final_numbers = prime_number.Divide(prime_number.num);

            Console.WriteLine($"{prime_number.num}的素数因子分别为：");

            foreach(int num in final_numbers)
            {
                if (num != 0)
                {
                    Console.WriteLine(num);
                }
            }
        }


        int[] Divide(int num)
        {
            if (num < 1) throw new ArgumentException("num必须大于1");

            int index = 0;

            int[] numbers = new int[num / 2];

            for (int i = 2; i*i < num; i++)
            {
                if (num % i == 0)
                {
                    numbers[index] = i;

                    index += 1;
                }
                while (num % i == 0)
                {
                    num /= i;
                }
            }
            numbers[index] = num;

            return numbers;
        }
    }
}
