// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Enter your favorite color:");
//string color = Console.ReadLine();

//Console.WriteLine("Enter your astrology sign:");
//string sign = Console.ReadLine();

//Console.WriteLine("Enter your street address number:");
//string address = Console.ReadLine();

//string name = color + sign + address;
//Console.WriteLine($"Your hacker name is {name}");

//1. Create a console application project named /02UnderstandingTypes/ that outputs the
//number of bytes in memory that each of the following number types uses, and the
//minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
//ulong, float, double, and decimal.
Console.WriteLine($"number of bytes sbyte uses: {sizeof(sbyte)}, range of sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"number of bytes byte uses: {sizeof(byte)}, range of byte: {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"number of bytes short uses: {sizeof(short)}, range of short: {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"number of bytes ushort uses: {sizeof(ushort)}, range of ushort: {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"number of bytes int uses: {sizeof(int)}, range of int: {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"number of bytes uint uses: {sizeof(uint)}, range of uint: {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"number of bytes long uses: {sizeof(long)}, range of long: {long.MinValue} to {long.MaxValue}");
Console.WriteLine($"number of bytes ulong uses: {sizeof(ulong)}, range of ulong: {ulong.MinValue} to {ulong.MaxValue}");
Console.WriteLine($"number of bytes float uses: {sizeof(float)}, range of float: {float.MinValue} to {float.MaxValue}");
Console.WriteLine($"number of bytes double uses: {sizeof(double)}, range of double: {double.MinValue} to {double.MaxValue}");
Console.WriteLine($"number of bytes decimal uses: {sizeof(decimal)}, range of decimal: {decimal.MinValue} to {decimal.MaxValue}");

//2.Write program to enter an integer number of centuries and convert it to years, days, hours,
//minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
//type for every data conversion. Beware of overflows!
Console.WriteLine("Enter the number of centuries:");
string input = Console.ReadLine();
uint century = UInt32.Parse(input);
uint year = 100 * century;
ulong day = (ulong)(365.242199 * year);
ulong hour = 24 * day;
ulong minute = 60 * hour;
ulong second = 60 * minute;
ulong millisecond = 1000 * second;
decimal microsecond = 1000M * millisecond;
decimal nanosecond = 1000M * microsecond;

Console.WriteLine($"{century} centuries = {year} years= {day} days = {hour} hours = {minute} minutes = {second} seconds = {millisecond} milliseconds" +
    $"{microsecond} microseconds = {nanosecond} nanoseconds");

//Practice loops and operators
//1. FizzBuzzis a group word game for children to teach them about division. Players take turns
//to count incrementally, replacing any number divisible by three with the word /fizz/, any
//number divisible by five with the word /buzz/, and any number divisible by both with /
//fizzbuzz/.
//Create a console application in Chapter03 named Exercise03 that outputs a simulated
//FizzBuzz game counting up to 100. The
int max = 100;
for (int i = 0; i <= max; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else
    {
        Console.WriteLine(i);
    }
}


//What will happen if this code executes:
//int max = 500;
//for (byte i = 0; i < max; i++)
//{
//    WriteLine(i);
//}
//Create a console application and enter the preceding code. Run the console application
//and view the output. What happens?
//What code could you add (don’t change any of the preceding code) to warn us about the problem?
//It will run forever, since max value for byte type i is 255, it can not reach the condition of 500 to finish the roop.



//2.Print - a - Pyramid.Like the star pattern examples that we saw earlier, create a program that
//will print the following pattern: If you find yourself getting stuck, try recreating the two
//examples that we just talked about in this chapter first. They’re simpler, and you can
//compare your results with the code included above.
//This can actually be a pretty challenging problem, so here is a hint to get you going. I used
//three total loops. One big one contains two smaller loops. The bigger loop goes from line
//to line. The first of the two inner loops prints the correct number of spaces, while the
//second inner loop prints out the correct number of stars.

max = 5;
for (int j = 0; j<max; j++)
{
    for (int i = 0; i < max-1-j; i++)
    {
        Console.Write(" ");
    }
    for (int i = 0; i < 1+2*j; i++)
    {
        Console.Write("*");
    }
    for (int i = 0; i < max - 1 - j; i++)
    {
        Console.Write(" ");
    }
    Console.WriteLine("");
}

//3.Write a program that generates a random number between 1 and 3 and asks the user to
//guess what the number is. Tell the user if they guess low, high, or get the correct answer.
//Also, tell the user if their answer is outside of the range of numbers that are valid guesses
//(less than 1 or more than 3).
int correctNumber = new Random().Next(3) + 1;
Console.WriteLine("Enter the number:");
int guessedNumber = int.Parse(Console.ReadLine());
if (guessedNumber == correctNumber)
{
    Console.WriteLine("your guess is correct");
}
else if (guessedNumber < 0 || guessedNumber > 3)
{
    Console.WriteLine("your guess is outside of the range of numbers that are valid guesses");
}

else if (guessedNumber < correctNumber)
{
    Console.WriteLine("your guess low");
}

else
{
    Console.WriteLine("your guess high");
}

//4.Write a simple program that defines a variable representing a birth date and calculates
//how many days old the person with that birth date is currently.
//For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
DateTime birth = new DateTime(1990, 01, 01);
var date = birth.ToString("yyyy-MM-dd");
TimeSpan diff = DateTime.Now - birth;
int days = diff.Days;
Console.WriteLine($"people with birth date {date} is {days} days old.");
int daysToNextAnniversary = 10000 - (days % 10000);
DateTime anniversary = DateTime.Now.AddDays(daysToNextAnniversary);
var anni = anniversary.ToString("yyyy-MM-dd");
Console.WriteLine($"the next 10,000 day of anniversary {anni}");

//5. Write a program that greets the user using the appropriate greeting for the time of day.
//Use only if , not else or switch , statements to do so. Be sure to include the following
//greetings:
//"Good Morning"
//"Good Afternoon"
//"Good Evening"
//"Good Night"


DateTime now = DateTime.Now;
//now = now.AddHours(6);
if (now.Hour < 6 && now.Hour >= 20)
{
    Console.WriteLine("Good Night");
} 
else if (now.Hour >= 6 && now.Hour < 12)
{
    Console.WriteLine("Good Morning");
}
else if (now.Hour >= 12 && now.Hour < 16)
{
    Console.WriteLine("Good Afternoon");
}
else
{
    Console.WriteLine("Good Night");
}


//6.Write a program that prints the result of counting up to 24 using four different increments.
//First, count by 1s, then by 2s, by 3s, and finally by 4s.
//Use nested for loops with your outer loop counting from 1 to 4. You inner loop should
//count from 0 to 24, but increase the value of its /loop control variable/ by the value of the /
//loop control variable/ from the outer loop. This means the incrementing in the /
//afterthought/ expression will be based on a variable.
max = 25;
int Outermax = 5;
for (int i = 1; i < Outermax; i++)
{
    for (int j = 0; j < max; j = j + i)
    {
        Console.Write(j + ",");
    }
    Console.WriteLine("");
}