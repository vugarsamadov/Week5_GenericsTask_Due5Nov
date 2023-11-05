using System.Security.Cryptography;
using Week5_GenericsTask_Due5Nov;

//CustomList<int> cl = new();

//cl.Add(1);
//cl.Add(2);
//cl.Add(3);
//cl.Add(4);
//cl.Add(5);
//cl.Add(6);
//cl.Add(4);
//Console.WriteLine(cl);
//cl.Reverse();
//Console.WriteLine(cl);
//Console.WriteLine(cl.IndexOf(4));
//Console.WriteLine(cl.LastIndexOf(4));

CustomList<string> cl = new();

cl.Add("A");
cl.Add("B");

Console.WriteLine(cl);

Console.WriteLine(cl.Remove("A"));
Console.WriteLine(cl.Remove("B"));
Console.WriteLine(cl.Remove("C"));

// Remove eliyende capacity azalsin?
Console.WriteLine(cl);




