using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool isTrue = true;

            if (words == null)
                return false;

            if (ignoreCase == true)
            {
                foreach (var item in words)
                {
                    if (item == null)
                        continue;
                    if (item.ToLower() == word.ToLower())
                    {
                        isTrue = true;
                        break;
                    }
                    else
                        isTrue = false;
                }
            }

            if (ignoreCase == false)
            {
                foreach (var item in words)
                {
                    if (item == null)
                        continue;
                    if (item == word)
                    {
                        isTrue = true;
                        break;
                    }
                    else
                        isTrue = false;
                }
            }
            return isTrue;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
                if (num % i == 0)
                    return false;

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex;

            for (int i = 0; i < str.Length; i++)
            {
                uindex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uindex = false;
                    }
                }

                if (uindex == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int a = 1; int aCount = 1;
            int b = 2; int bCount = 1;
            int c = 3; int cCount = 1;
            int d = 4; int dCount = 1;
            int e = 5; int eCount = 1;
            int j = 10; int jCount = 1;

            List<int> list = new List<int>();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == a && numbers[i] == numbers[i + 1])
                    aCount++; list.Add(aCount);
                if (numbers[i] == b && numbers[i] == numbers[i + 1])
                    bCount++; list.Add(bCount);
                if (numbers[i] == c && numbers[i] == numbers[i + 1])
                    cCount++; list.Add(cCount);
                if (numbers[i] == d && numbers[i] == numbers[i + 1])
                    dCount++; list.Add(dCount);
                if (numbers[i] == e && numbers[i] == numbers[i + 1])
                    eCount++; list.Add(eCount);
                if (numbers[i] == j && numbers[i] == numbers[i + 1])
                    jCount++; list.Add(jCount);
            }
            return list.Max();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> list = new List<double>();
            int x = n;

            if (elements == null)
                return list.ToArray();

            for (int i = 0; i < elements.Count(); i++)
            {
                if (elements[i] == x)
                {
                    list.Add(elements[i]);
                    x += n;
                }
            }
            return list.ToArray();
        }
    }
}
