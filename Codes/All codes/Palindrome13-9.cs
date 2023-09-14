using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        // See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
Given an integer x, return true if x is a palindrome, and false otherwise.

Example 1:
Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left.Therefore it is not a palindrome.

Constraints:

-231 <= x <= 231 - 1

Follow up: Could you solve it without converting the integer to a string?
*/

using System;

class Palindrome
    {
        /*static public void Main(string[] args)
        {
            Console.WriteLine("\n >>>> To Find a Number is Palindrome or not <<<< ");
            Console.Write("\n Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            var x = new Palindrome();
            x.IsPalindrome(n);

            string input = "we are achievers";
            Lengthword obj = new Lengthword();
            Console.WriteLine("The length of last word is " + obj.LengthOfLastWord(input));
        }*/

        public bool IsPalindrome(int x)
        {
            if (x < 0) { return false; }
            if (x < 10) { return true; }

            var temp = x;
            var b = 0;
            var digit = 0;
            while (temp != 0)
            {
                digit = temp % 10;
                b = b * 10 + digit;
                temp /= 10;
            }
            if (x == b) //checking whether the reversed number is equal to entered number    
            {
                Console.WriteLine("\n Number is Palindrome \n\n");
            }
            else
            {
                Console.WriteLine("\n Number is not a palindrome \n\n");
            }
            Console.ReadLine();
            return x == b;

        }
    }


