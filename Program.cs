using System;

namespace Project2_OutlierDetection
{
    class Program
    {
        public static double FirstQuartile(int[] numbers)
        {
            int n = numbers.Length;
            if (n % 4 == 0)
            {
                return (numbers[n / 4 - 1] + numbers[n / 4]) / 2.0;
            }
            else
            {
                return numbers[n / 4];
            }
        }

        public static double ThirdQuartile(int[] numbers)
        {
            int n = numbers.Length;
            if (n % 4 == 0)
            {
                return (numbers[3 * n / 4 - 1] + numbers[3 * n / 4]) / 2.0;
            }
            else
            {
                return numbers[3 * n / 4];
            }
        }

        public static void IQR(int[] numbers)
        {
            double IQR = ThirdQuartile(numbers) - FirstQuartile(numbers);
            double lowerBound = FirstQuartile(numbers) - 1.5 * IQR;
            double upperBound = ThirdQuartile(numbers) + 1.5 * IQR;

            foreach (int number in numbers)
            {
                if (number < lowerBound || number > upperBound)
                {
                    Console.WriteLine($"{number} is an Outlier");
                }
                else
                {
                    Console.WriteLine($"{number} is NOT an Outlier");
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("How many numbers?");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"enter the Number {i + 1}:");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            Console.WriteLine($"First Quartile: {FirstQuartile(numbers)}");
            Console.WriteLine($"Third Quartile: {ThirdQuartile(numbers)}");

            IQR(numbers);
        }
    }
}
