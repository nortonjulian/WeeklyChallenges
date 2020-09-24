using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Count() % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            //if (number % 2 == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            //if (num % 2 != 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return num % 2 != 0 ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count<double>() == 0)
            {
                return 0;
            }
            else
            {
                var min = numbers.Min();
                var max = numbers.Max();
                return min + max;
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //if (str1.Length < str2.Length)
            //{
            //    return str1.Length;
            //}
            //else
            //{
            //    return str2.Length;
            //}
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            //if(numbers == null)
            //{
            //    return 0;
            //}
            //var result = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 2 == 0 )
            //    {
            //        result += numbers[i];
            //    }
            //}
            //return result;
            return numbers == null ? 0 : numbers.Where(x => x % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return false;
            }
            else if (numbers.Sum() % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }   
    }
}
