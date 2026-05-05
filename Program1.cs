using System;

namespace Project1_StatisticalCalculations
{
    class Program
    {
        public static double Mean(int[] numbers)
        {
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }

        public static int Mode(int[] numbers)
        {
            int mode = numbers[0];
            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        mode = numbers[i - 1];
                    }
                    currentCount = 1;
                }
            }
            return mode;
        }

        public static double Median(int[] numbers)
        {
            int n = numbers.Length;
            if (n % 2 == 0)
            {
                double medianEven = (numbers[(n / 2) - 1] + numbers[n / 2]) / 2.0;
                return medianEven;
            }
            else
            {
                double medianOdd = numbers[n / 2];
                return medianOdd;
            }
        }

        public static double FirstQuartile(int[] numbers)
        {
            int n = numbers.Length;
            if (n % 4 == 0)
            {
                double q1Even = (numbers[(n / 4) - 1] + numbers[n / 4]) / 2.0;
                return q1Even;
            }
            else
            {
                double q1Odd = numbers[n / 4];
                return q1Odd;
            }
        }

        public static double ThirdQuartile(int[] numbers)
        {
            int n = numbers.Length;
            if (n % 4 == 0)
            {
                double q3Even = (numbers[(3 * n / 4) - 1] + numbers[3 * n / 4]) / 2.0;
                return q3Even;
            }
            else
            {
                double q3Odd = numbers[3 * n / 4];
                return q3Odd;
            }
        }

        public static double P20(int[] numbers)
        {
            int n = numbers.Length;
            double p20 = numbers[(int)(0.2 * n)];
            return p20;
        }

        public static double Variance(int[] numbers)
        {
            double mean = Mean(numbers);
            double sumOfSquares = 0;
            foreach (int number in numbers)
            {
                sumOfSquares += Math.Pow(number - mean, 2);
            }
            return sumOfSquares / numbers.Length;
        }

        public static int Range(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[numbers.Length - 1];
            int range = max - min;
            return range;
        }

        public static double StandardDeviation(int[] numbers)
        {
            double variance = Variance(numbers);
            return Math.Sqrt(variance);
        }

        public static double SummationOfDivisions(int[] numbers)
        {
            double mean = Mean(numbers);
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number - mean;
            }
            return sum;
        }

        public static double InterquartileRange(int[] numbers)
        {
            double q1 = FirstQuartile(numbers);
            double q3 = ThirdQuartile(numbers);
            return q3 - q1;
        }

        static void Main()
        {
            int[] Numbers = { 115, 182, 191, 31, 196, 1099, 5,
            172, 10, 179, 83, 21, 20, 21, 186, 177, 195, 193,
            188, 199, 62, 109, 105, 183, 110 };

            Array.Sort(Numbers);

            Console.WriteLine("Mean: " + Mean(Numbers));
            Console.WriteLine("Mode: " + Mode(Numbers));
            Console.WriteLine("Median, P50 , Second Quartile : " + Median(Numbers));
            Console.WriteLine("First Quartile : " + FirstQuartile(Numbers));
            Console.WriteLine("Third Quartile : " + ThirdQuartile(Numbers));
            Console.WriteLine("P20 : " + P20(Numbers));
            Console.WriteLine("Variance : " + Variance(Numbers));
            Console.WriteLine("Range : " + Range(Numbers));
            Console.WriteLine("Standard Deviation : " + StandardDeviation(Numbers));
            Console.WriteLine("Summation of Divisions : " + SummationOfDivisions(Numbers));
            Console.WriteLine("Interquartile Range : " + InterquartileRange(Numbers));
        }
    }
}
