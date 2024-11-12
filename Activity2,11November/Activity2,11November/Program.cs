using System;
using System.Collections.Generic;
class DictionaryActivity
{
    static void Main()
    { 
        Dictionary<string, string> countries = new Dictionary<string, string>();
        //Add Countries
        countries["USA"] = "Washington, DC";
        countries["France"] = "Paris";
        countries["Japan"] = "Tokyo";
        //Display
        Console.WriteLine("Countries and Capitals: ");
        foreach(var pair in countries)
        {
            Console.WriteLine($" {pair.Key} : {pair.Value}");
        }
        //retrieve
        Console.WriteLine($"Capital of Japan: {countries["Japan"]}");
        //remove
        countries.Remove("France");
        //Display
        Console.WriteLine("Updated: ");
        foreach (var pair in countries)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}