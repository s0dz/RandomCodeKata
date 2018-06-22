using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Kata
    {
        public static int FindEvenIndex(int[] arr)
        {
            var leftSum = 0;
            var rightSum = arr.Sum();

            for (int i = 0; i < arr.Length; i++)
            {
                rightSum = rightSum - arr[i];

                if (leftSum == rightSum)
                {
                    return i;
                }

                leftSum = leftSum + arr[i];
            }

            return -1;
        }

        public static int DuplicateCount(string str)
        {
            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        }

        public static bool is_valid_IP1(string IpAddres)
        {
            if (String.IsNullOrWhiteSpace(IpAddres) || IpAddres.Contains(' '))
            {
                return false;
            }

            var octets = IpAddres.Split('.');

            if (octets.Length != 4)
            {
                return false;
            }

            foreach (var octet in octets)
            {
                try
                {
                    if (octet[0].Equals('0'))
                    {
                        return false;
                    }

                    var number = int.Parse(octet);

                    if (number > 255 || number < 0)
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool is_valid_IP(string IpAddres)
        {
            return Regex.IsMatch(IpAddres, @"^[1-2]?(?<!0)[0-9]{0,2}\.[1-2]?(?<!0)[0-9]{0,2}\.[1-2]?(?<!0)[0-9]{0,2}\.[1-2]?(?<!0)[0-9]{0,2}$");
        }

        public static string SongDecoder(string input)
        {
            var words = input.Split(new string[] {"WUB"}, StringSplitOptions.None);

            var original = string.Empty;
            foreach (var word in words)
            {
                original = original + " " + word;
            }

            // var original = words.Aggregate(string.Empty, (current, word) => current + " " + word);

            return Regex.Replace(original, @"\s+", " ").Trim();
        }

        public static string Tickets(int[] peopleInLine)
        {
            var cashRegister = new CashRegister();
            foreach (var person in peopleInLine)
            {
                switch (person)
                {
                    case 25:
                        cashRegister.TwentyFives++;
                        // No change
                        break;
                    case 50:
                        cashRegister.Fifties++;
                        if (cashRegister.TwentyFives >= 1)
                        {
                            cashRegister.TwentyFives--;
                        }
                        else
                        {
                            return "NO";
                        }

                        break;
                    case 100:
                        cashRegister.Hundreds++;
                        if (cashRegister.Fifties >= 1 && cashRegister.TwentyFives >= 1)
                        {
                            cashRegister.Fifties--;
                            cashRegister.TwentyFives--;
                        }
                        else if(cashRegister.TwentyFives >= 3)
                        {
                            cashRegister.TwentyFives--;
                            cashRegister.TwentyFives--;
                            cashRegister.TwentyFives--;
                        }
                        else
                        {
                            return "NO";
                        }
                        break;
                }
            }

            return "YES";
        }

        public class CashRegister
        {
            public int TwentyFives { get; set; }
            public int Fifties { get; set; }
            public int Hundreds { get; set; }
        }


        // Time complexity : O(n^2)
        //      Looping through each array is O(n)
        // Space complexity : O(1)
        public static int[] TwoSum(int[] nums, int target)
        {
            for (var k = 0; k < nums.Length; k++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                    if (nums[j] + nums[k] == target && j != k)
                    {
                        return new int[] { k, j };
                    }
                }
            }
            return null;
        }


    }
}