using System;
using System.Collections.Generic;
using System.Text;

namespace solution
{
    public class Solution
    {
        public bool Isprime(int num)
        {
            if(num==2 || num == 1)
            {
                return true;
            }
            var z= Math.Sqrt(num) + 1;
            for (int i = 2; i <=z; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public bool Isfibisonsi(int num)
        {
            int a = 1;
            int b = 1;
            while (a <= num)
            {
                if (a == num)
                {
                    return true;
                }
                int c = a;
                a = b;
                b = b+ c;
            }
            return false;
        }
        public bool Palindrome(int num)
        {
            if (num < 0)
            {
                return false;
            }
            int rem = 0;
            int sum = 0;
            int temp = num;
            int x = num;
            while (x > 0)
            {
                rem = x % 10;
                x= x/ 10;
                sum = sum * 10 + rem;
            }
            if (temp == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string ToBinary(int num)
        {
            string str = "";
            if (num == 1)
            {
                return "1";
            }
            else if(num == 0)
            {
                return "0";
            }
            str += Convert.ToInt32((num % 2));
            return ToBinary(num / 2)+str;
        }
        public string Multiplystr(string str,int num)
        {
            var s = "";
            for (int i = 0; i < num; i++)
            {
                s += str;
            }
            return s;
        }
    }
}
