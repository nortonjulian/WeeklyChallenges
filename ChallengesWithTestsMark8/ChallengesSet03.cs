using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach(var i in vals)
            {
                if (i == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            var sum = 0;
            foreach (var item in numbers)
            {
                if (item % 2 != 0)
                {
                    sum += item;
                }
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool number = false;

            foreach (var item in password)
            {
                if (char.IsUpper(item))
                {
                    upper = true;
                }
                if (char.IsLower(item))
                {
                    lower = true;
                }
                if (char.IsNumber(item))
                {
                    number = true;
                }
            }
            if (upper == true && lower == true && number == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            char answer = val.FirstOrDefault();
            var result = Convert.ToChar(answer);
            return result;
        }

        public char GetLastLetterOfString(string val)
        {
           var answer = val.Substring(val.Length - 1);
            var result = Convert.ToChar(answer);
            return result;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
           return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int index = 0;
            var arr = new int[50];
            for (int i = 1; i < 100; i+=2)
            {
                arr[index] = i;
                index++;
            }
            return arr;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
        }
    }
}
