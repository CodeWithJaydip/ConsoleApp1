using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
        list.Add(new KeyValuePair<string, string>("Name1", "Phone Num1"));
        list.Add(new KeyValuePair<string, string>("Name1", "Phone Num2"));

        foreach (KeyValuePair<string, string> item in list)
        {
            Console.Write(item.Key + "=>" + item.Value);
        }

        Console.ReadKey();
    }
}