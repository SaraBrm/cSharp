
// SortedList 

using SortedListCollection;
using System.Collections.Generic;

//SortedList<string,int> list = new SortedList<string, int>() { { "Persian", 20 }, { "Math",16} };
//list.Add("Arabic", 18);

//list.Remove("Math");
//list.RemoveAt(0);


//list["Math"] = 18;

//if(list.ContainsKey("Math1"))
//{
//    Console.WriteLine(list["Math1"]);
//}

//foreach (KeyValuePair<string,int> item in list)
//{
//    Console.WriteLine($"key is : {item.Key} and value is : {item.Value}");
//}

//var data = new List<KeyValuePair<string, int>>() { new KeyValuePair<string, int>("Math",10)};

Test test = new Test();
//string name;
//test.GetValue(out name);
//Console.WriteLine(name);
var item = test.GetValue2();
Console.WriteLine($"course name is : {item.Key} and grade is : {item.Value}");

Console.ReadKey();
