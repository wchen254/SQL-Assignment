// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Text;

//1.Copying an Array
//Write code to create a copy of an array. First, start by creating an initial array. (You can use
//whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
//assign it a new array with 10 items in it.Use the things we’ve discussed to put some values
//in the array.
//Now create a second array variable. Give it a new array with the same length as the first.
//Instead of using a number for this length, use the Lengthproperty to get the size of the
//original array.
//Use a loop to read values from the original array and place them in the new array.Also
//print out the contents of both arrays, to be sure everything copied correctly.


int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int len = nums.Length;
int[] nums2 = new int[len];
for (int i = 0; i < len; i++)
{
    nums2[i] = nums[i];
}

Console.Write("Array1 : [");
foreach (int j in nums)
{
    Console.Write($"{j} ");
}
Console.WriteLine("]");

Console.Write("Array2 : [");
foreach (int j in nums2)
{
    Console.Write($"{j} ");
}
Console.WriteLine("]");

//2.Write a simple program that lets the user manage a list of elements. It can be a grocery list,
//"to do" list, etc. Refer to Looping Based on a Logical Expression if necessary to see how to
//implement an infinite loop. Each time through the loop, ask the user to perform an
//operation, and then show the current contents of their list.
string[] items = new string[0] { };
while (true)
{
    int leng = items.Length;
    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
    string item = Console.ReadLine();
    string[] words = item.Split(" ");
    if (words[0] == "+")
    {
        Array.Resize(ref items, leng + 1);
        Console.WriteLine($"Length of array: {leng + 1}");
        items[leng] = words[1];
        //Console.WriteLine("1");
    }
    else if (words[0] == "-")
    {
        var ite = new List<string>(items);
        ite.Remove(words[1]);
        items = ite.ToArray();
        //Console.WriteLine("2");
    }
    else
    {
        items = new string[0] { };
        //Console.WriteLine("3");
        break;
    }
    Console.Write("List : [");
    foreach (string j in items)
    {
        Console.Write($"{j} ");

    }
    Console.WriteLine("]");
}

//3.Write a method that calculates all prime numbers in given range and returns them as array of integers
static int[] FindPrimesInRange(int startNum, int endNum)
{
    int[] numbers = new int[0] { };
    for (int i = startNum; i < endNum; i++)
    {
        if (IsPrime(i))
        {
            Array.Resize(ref numbers, numbers.Length + 1);
            numbers[numbers.Length - 1] = i;
        }
    }
    return numbers;
}

static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
            return false;

    return true;
}

int[] primes = FindPrimesInRange(1, 100);

Console.Write("[");
foreach (int j in primes)
{
    Console.Write($"{j} ");

}
Console.WriteLine("]");

//4. Write a program to read an array of n integers (space separated on a single line) and an
//integer k, rotate the array right k times and sum the obtained arrays after each rotation as shown below.
Console.WriteLine("input Array:");
string input = Console.ReadLine();
string[] starr = input.Split(" ");
int l = starr.Length;
int[] arr = new int[l];
for (int i = 0; i < l; i++)
{
    arr[i] = int.Parse(starr[i]);
}

Console.WriteLine("input rotations:");
int rotate = int.Parse(Console.ReadLine());
if (rotate == 0)
{
    Console.Write("[");
    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine("]");
}
else
{
    int[] clone = new int[l];
    Array.Clear(clone, 0, l);
    for (int i = 0; i < rotate; i++)
    {
        for (int j = 0; j < l; j++)
        {
            //Console.WriteLine($"{i},{j},{(l-(i+1) + j) % l},{arr[(l-(i+1)+ j) % l]}");
            clone[j] += arr[(l - (i + 1) + j) % l];
        }
    }
    Console.Write("[");
    foreach (int i in clone)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine("]");

}

//5.Write a program that finds the longest sequence of equal elements in an array of integers.
//If several longest sequences exist, print the leftmost one.
Console.WriteLine("input Array:");
string inp = Console.ReadLine();
string[] splitinp = inp.Split(" ");
int maxseq = 1;
int count = 1;
string maxstr = splitinp[0];
for (int i = 0; i < (splitinp.Length - 1); i++)
{
    if (splitinp[i] == splitinp[i + 1])
    {
        count++;
    }
    else
    {
        count = 1;
    }
    if (count > maxseq)
    {
        maxseq = count;
        maxstr = splitinp[i];
    }
}
Console.WriteLine($"count: {maxseq}, string: {maxstr}");
Console.Write($"longest sequence of equal elements in an array: [");
for (int i = 0; i < maxseq; i++)
{
    Console.Write(maxstr + " ");
}
Console.WriteLine("]");

//7.Write a program that finds the most frequent number in a given sequence of numbers. In
//case of multiple numbers with the same maximal frequency, print the leftmost of them.
Console.WriteLine("input Array:");
string inp2 = Console.ReadLine();
string[] splitinp2 = inp2.Split(" ");

var dic = new Dictionary<string, int>();
foreach (string s in splitinp2)
{
    if (dic.ContainsKey(s))
    {
        dic[s]++;
    }
    else
    {
        dic[s] = 1;
    }
}
string moststr = splitinp2[0];
int maxcount = 1;
foreach (string s in dic.Keys)
{
    if (dic[s] > maxcount)
    {
        maxcount = dic[s];
    }
}
Console.WriteLine($"max occur: {maxcount}");
string[] ans = new string[0];
foreach (string s in dic.Keys)
{
    if (dic[s] == maxcount)
    {
        Array.Resize(ref ans, ans.Length + 1);
        ans[ans.Length - 1] = s;
    }
}

if (ans.Length > 1)
{
    Console.Write("The numbers ");
    foreach (string s in ans)
    {
        Console.Write(s + ",");
    }
    Console.WriteLine($"have the same maximal frequence(each occurs {maxcount} times).The leftmost of them is {ans[0]}.");

}
else
{
    Console.WriteLine($"The number {ans[0]} is the most frequent(occurs {maxcount} times).");
}

//Practice Strings
//1. Write a program that reads a string from the console, reverses its letters and prints the
//result back at the console.
//Write in two ways
//Convert the string to char array, reverse it, then convert it to string again
//Print the letters of the string in back direction (from the last to the first) in a for-loop
Console.WriteLine("input Array:");
string inp3 = Console.ReadLine();
char[] splitinp3 = inp3.ToCharArray();
Array.Reverse(splitinp3);
string ans1 = new string(splitinp3);
Console.WriteLine($"solution 1: {ans1}");

Console.WriteLine("input Array:");
string inp4 = Console.ReadLine();
StringBuilder sb = new StringBuilder(inp4);
int len2 = sb.Length;
for (int i = 0; i < len2; i++)
{
    sb[i] = inp4[len2 - i - 1];
}

Console.WriteLine($"Solution 2: {sb}");

//2.Write a program that reverses the words in a given sentence without changing the
//punctuation and spaces
//Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
//All other characters are considered part of words, e.g. C++, a+b, and a77 are
//considered valid words.
//The sentences always start by word and end by separator.
//*******//
//*******//
//*******//
Console.WriteLine("input Array:");
string inp5 = Console.ReadLine();
char[] separator = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ', '\t', '\0' };
string[] splitinp4 = inp5.Split(separator);
Array.Reverse(splitinp4);

foreach (string s in splitinp4)
{
    Console.Write(s + ' ');
}

int length5 = splitinp4.Length;
string[] splitinp5 = inp5.Split(' ');
int length6 = splitinp5.Length;
Console.WriteLine($"{length5},{length6}");
foreach (string s in splitinp5)
{
    Console.Write(s + ' ');
}

//3. Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
//and prints them on the console on a single line, separated by comma and space.Print all
//unique palindromes (no duplicates), sorted
static bool ispalindromes(string mystr)
{
    char[] arr0 = mystr.ToCharArray();

    Array.Reverse(arr0);

    string temp = new string(arr0);

    return mystr.Equals(temp);
}

Console.WriteLine("input Array:");
string inp6 = Console.ReadLine();
char[] separator1 = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ', '\t', '\0' };
string[] splitinp6 = inp6.Split(separator1);
string[] ans5 = new string[0];
foreach (string s in splitinp6)
{
    if (ispalindromes(s) && !string.IsNullOrEmpty(s))
    {
        Array.Resize(ref ans5, ans5.Length + 1);
        ans5[ans5.Length - 1] = s;
    }

}
Array.Sort(ans5);
foreach (string s in ans5)
{
    Console.Write(s + ", ");
}
Console.WriteLine(" ");

//4.Write a program that parses an URL given in the following format:
//[protocol]://[server]/[resource]
//The parsing extracts its parts: protocol, server and resource.
//The [server] part is mandatory.
//The[protocol] and [resource] parts are optional.

Console.WriteLine("input Array:");
string inp7 = Console.ReadLine();
string[] splitinp7 = inp7.Split('/');
int n = 1;


string[] ans0 = new string[0];
foreach (string s in splitinp7)
{
    if (!string.IsNullOrEmpty(s) || s == " ")
    {
        Array.Resize(ref ans0, ans0.Length + 1);
        ans0[ans0.Length - 1] = s;
    }

}


int lll = ans0.Length;
if (lll == 1)
{
    Console.WriteLine("[protocol] = \"\"");
    Console.WriteLine($"\"[server] = {ans0[0]}\"");
    Console.WriteLine("[resource] = \"\"");
}
else if(lll == 2)
{
    if (ans0[0].Contains(":"))
    {
        string protocal = ans0[0].Remove(ans0[0].Length-1,1);
        Console.WriteLine($"[protocol] = \"{protocal}\"");
        Console.WriteLine($"[server] = \"{ans0[1]}\"");
        Console.WriteLine($"[resource] = \"\"");
    }
    else
    {
        Console.WriteLine("[protocol] = \"\"");
        Console.WriteLine($"[server] = \"{ans0[0]}\"");
        Console.WriteLine($"[resource] = \"{ans0[1]}\"");
    }

}
else
{
    string protocal = ans0[0].Remove(ans0[0].Length - 1, 1);
    Console.WriteLine($"[protocol] = \"{protocal}\"");
    Console.WriteLine($"[server] = \"{ans0[1]}\"");
    Console.WriteLine($"[resource] = \"{ans0[2]}\"");
}