// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//1.Let’s make a program that uses methods to accomplish a task. Let’s take an array and
//reverse the contents of it. For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
//become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.
//To accomplish this, you’ll create three methods: one to create the array, one to reverse the
//array, and one to print the array at the end.
using DAY2;

static int[] GenerateNumbers()
{
    Console.WriteLine("input Array:");
    string input = Console.ReadLine();
    string[] arr = input.Split(" ");
    int l = arr.Length;
    int[] intArr = new int[l];
    for (int i = 0; i < l; i++)
    {
        intArr[i] = int.Parse(arr[i]);
    }

    return intArr;
}

static int[] Reverse(int[] num)
{
    //Array.Reverse(num);
    int l = num.Length;
    int temp = 0;
    for (int i = 0;i < l/2; i++)
    {
        temp = num[i];
        num[i] = num[l-i-1];
        num[l-i-1] = temp;
    }

    return num;
}

static void PrintNumbers(int[] num)
{
    Console.Write("revered array: [");
    foreach (int i in num)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine("]");
}


static void Main1()
{
    int[] numbers = GenerateNumbers();
    Reverse(numbers);
    PrintNumbers(numbers);
}

//Main1();

//2. 
//Your mission, should you choose to accept it, is to create a method called Fibonacci, which
//takes in a number and returns that number of the Fibonacci sequence. So if someone calls
//Fibonacci(3), it would return the 3rd number in the Fibonacci sequence, which is 2. If
//someone calls Fibonacci(8), it would return 21.

static void Fibonacci(int num)
{
    int[] fib = {1, 1};
    for (int i = 0; i < 8 ; i++)
    {
        Array.Resize(ref fib, fib.Length + 1);
        fib[fib.Length - 1] = fib[fib.Length - 2] + fib[fib.Length - 3];
    }
    Console.Write("first 10 numbers of the Fibonacci sequence: [");
    foreach (int i in fib)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine("]");
    if (num <= 10)
    {
        Console.WriteLine($"the {num}rd number in the Fibonacci sequence, which is {fib[num-1]}.");
    }
    else
    {
        for (int i = 0; i < num-10; i++)
        {
            Array.Resize(ref fib, fib.Length + 1);
            fib[fib.Length - 1] = fib[fib.Length - 2] + fib[fib.Length - 3];
        }
        Console.WriteLine($"the {num}rd number in the Fibonacci sequence, which is {fib[num-1]}.");
    }


}
Console.WriteLine("input which number of the Fibonacci");
string input = Console.ReadLine();
int num = int.Parse(input);
//Fibonacci(num);

//1.Write a program that that demonstrates use of four basic principles of
//object-oriented programming /Abstraction/, /Encapsulation/, /Inheritance/ and
///Polymorphism/.
//2. Use /Abstraction/ to define different classes for each person type such as Student
//and Instructor. These classes should have behavior for that type of person.
//3. Use /Encapsulation/ to keep many details private in each class.
//4.Use / Inheritance / by leveraging the implementation already created in the Person
//class to save code in Student and Instructor classes.
//5. Use /Polymorphism/ to create virtual methods that derived classes could override to
//create specific behavior such as salary calculations.

//check Demo class.

//6.Make sure to create appropriate /interfaces/ such as ICourseService, IStudentService,
//IInstructorService, IDepartmentService, IPersonService, IPersonService (should have
//person specific methods). IStudentService, IInstructorService should inherit from
//IPersonService.

//check DataModel folder.

//7.Try creating the two classes below, and make a simple program to work with them, as
//described below

Manage manage = new Manage();
manage.Run();