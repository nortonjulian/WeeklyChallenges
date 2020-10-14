using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var result = ((startNumber/n) + 1) * n;
            if (result == 0 && startNumber > 0)
            {
                result += 1;
                result *= n;
            }
            return result;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue == 0)
                    biz.Name = "CLOSED";
                if (biz.TotalRevenue < biz.TotalExpenses)
                    biz.Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null && numbers.Length == 0)
            {
                return 0;
            }

            int count = 0;
            for (int i = 1; i < numbers.Length; i+=2)
            {
                if (numbers.Length % 2 != 0)
                {
                    count = count + numbers[i];
                }
            }
            return count;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = "";

            if (words == null || words.Length == 0)
            {
                return sentence;
            }
            foreach (var word in words)
            {
                if (string.IsNullOrWhiteSpace(word))
                    continue;
                else
                    sentence += word.Trim() + " ";
            }
            if (sentence == "")
            {
                return sentence;
            }
            return sentence.TrimEnd() + "."; 
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> list = new List<double>();
            if (list == null)
                return list.ToArray();

            for (int i = 0; i < elements.Count; i+=4)
            {
                if (elements[i] == list[i])
                {
                    list.Add(elements[i]);
                }
            }
            return list.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i +1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
