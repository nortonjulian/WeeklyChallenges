using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            var sum1 = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
                if (item % 2 != 0)
                {
                    sum1 += item;
                }
            }
            return sum - sum1;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>();
            list.Add(str1.Length);
            list.Add(str2.Length);
            list.Add(str3.Length);
            list.Add(str4.Length);

            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>();
            list.Add(number1);
            list.Add(number2);
            list.Add(number3);
            list.Add(number4);

            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            try
            {
                input = input.Trim();
                double answer = double.Parse(input);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int count = 0;

            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    count++;
                }
            }
            return count > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var count = 0;
            double sum = 0;
            
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    count++;
                    sum += item;
                }
            }
            if (sum == 0)
            {
                return 0;
            }
            double answer = sum / count;
            return answer;
        }

        public int Factorial(int number)
        {
            int result = 1;
            while (number > 1)
            {
                result = result * number--;
            }
            return result;
        }

    }
}
