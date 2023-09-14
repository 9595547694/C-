/*Given a string s consisting of words and spaces, return the length of the last word in the string.

A word is a maximal 
substring
 consisting of non-space characters only.

 

Example 1:

Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.*/

using System;

public class Lengthword
{
    public int LengthOfLastWord(string s)
    {
        bool a = false;
        int len = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (char.IsLetter(s[i]))
            {
                a = true;
                len++;
            }
            else
            {
                if (a == true)
                {
                    return len;
                }
            }

        }
        return len;
    }

}
/*public static void main(string []args)
    {
    string input = "we are achievers";
    Lengthword obj = new Lengthword();
    Console.WriteLine("The length of last word is "+ obj.LengthOfLastWord(input) );
        Console.WriteLine("Enter a string");
        string a = Console.ReadLine();
        obj.LengthOfLastWord(a);
        Console.WriteLine("The length of last word is"+ obj.LengthOfLastWord(a) );
    }
}*/