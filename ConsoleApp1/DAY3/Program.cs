//// See https://aka.ms/new-console-template for more information
//1.Create a custom Stack class MyStack<T> that can be used with any data type which
//has following methods
//1. int Count()
//2.T Pop()
//3.Void Push()

using DAY3;

Stack<string> s = new Stack<string>();
s.Push("a");
s.Push("b");
s.Push("c");
s.Push("d");
Console.WriteLine(s.Count());
Console.WriteLine(s.Pop());
Console.WriteLine(s.Pop());
Console.WriteLine(s.Count());

Console.WriteLine("  ");

MyStack<string> ms = new MyStack<string>(10);
ms.Push("a");
ms.Push("b");
ms.Push("c");
ms.Push("d");
Console.WriteLine(ms.Count());
Console.WriteLine(ms.Pop());
Console.WriteLine(ms.Pop());
Console.WriteLine(ms.Count());

//2.Create a Generic List data structure MyList<T> that can store any data type.
//Implement the following methods.
//1. void Add (T element)
//2.T Remove(int index)
//3. bool Contains(T element)
//4. void Clear()
//5. void InsertAt(T element, int index)
//6. void DeleteAt(int index)
//7.T Find(int index)
MyList<int> mlist = new MyList<int>(10);
mlist.Add(1);
mlist.Add(2);
mlist.Add(3);
mlist.Add(4);
mlist.Add(5);
mlist.Add(6);
mlist.Revome(3);
mlist.PrintAll();
Console.WriteLine(mlist.Contains(5));
Console.WriteLine(mlist.Contains(4));
mlist.InsertAt(0, 5);
mlist.InsertAt(10, 1);
mlist.PrintAll();
mlist.DeleteAt(0);
mlist.PrintAll();
Console.WriteLine(mlist.find(4));
mlist.Clear();
mlist.PrintAll();

//3.Implement a GenericRepository<T> class that implements IRepository<T> interface that will have common /CRUD/ operations so that it can work with any data source
//such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint
//on T were it should be of reference type and can be of type Entity which has one
//property called Id. IRepository<T> should have following methods
//1. void Add(T item)
//2. void Remove(T item)
//3.Void Save()
//4.IEnumerable < T > GetAll()
//5.T GetById(int id)
//Explore following topics
//Generics in

//check IRepositry.cs