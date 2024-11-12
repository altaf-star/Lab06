using System;
using System.Collections;
class NonGenericActivity
{
    static void Main()
    {
        ArrayList arrayList = new ArrayList();  
        //add
        arrayList.Add(1);
        arrayList.Add("Hello");   
        arrayList.Add(3);   
        arrayList.Add(4);   
        arrayList.Add("World");
        //display
        Console.WriteLine("ArrayList items: ");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        //remove
        arrayList.Remove("Hello");
        //display
        Console.WriteLine("List after removal: ");
        foreach(var item in arrayList)
        {
            Console.WriteLine(item);
        }
        //check
        Console.WriteLine($"\nContains: {arrayList.Contains("World")}");
    }
}