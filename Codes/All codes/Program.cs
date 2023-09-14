
//palindrome

Console.WriteLine("\n >>>> To Find a Number is Palindrome or not <<<< ");
Console.Write("\n Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
var x = new Palindrome();
x.IsPalindrome(n);

//Length of last word

string input = "we are achievers";
Lengthword obj = new Lengthword();
Console.WriteLine("The length of last word is " + obj.LengthOfLastWord(input));

Lengthword obj1 = new Lengthword();
Console.WriteLine("Enter a string");
string a = Console.ReadLine();
obj1.LengthOfLastWord(a);
Console.WriteLine("The length of last word is" + obj1.LengthOfLastWord( a) );