using System.Security.Cryptography;
using Week5_GenericsTask_Due5Nov;

//CustomList<int> cl = new();

//cl.Add(1);


//Console.WriteLine(cl);
////cl.Reverse();
////Console.WriteLine(cl);
////Console.WriteLine(cl.IndexOf(4));
////Console.WriteLine(cl.LastIndexOf(4));
//Console.WriteLine(cl.Remove(1));
//Console.WriteLine(cl);
//Console.WriteLine(cl.Remove(1));
//Console.WriteLine(cl);
//Console.WriteLine(cl.Remove(455));
//Console.WriteLine(cl);

//cl.Add(23);
//cl.Add(34);
//cl.Add(90);
//Console.WriteLine(cl.Remove(34));
//Console.WriteLine(cl);


CustomList<string> cl = new();

cl.Add("A");
cl.Add(null);
cl.Add("B");

Console.WriteLine(cl);

Console.WriteLine(cl.Remove("A"));
Console.WriteLine(cl);
Console.WriteLine(cl.Remove("B"));
Console.WriteLine(cl.Remove("C"));

// Remove eliyende capacity azalsin?
Console.WriteLine(cl);
Console.WriteLine(cl.Count);
cl.Clear();
Console.WriteLine(cl.Count);
cl.Add("A");
cl.Add("B");
cl.Add("C");
cl.Add("D");
cl.Add("E");

for(int i=0;i<cl.Count;i++)
{
    Console.WriteLine(cl[i]);
}


