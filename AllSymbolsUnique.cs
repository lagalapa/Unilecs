using System;
using System.Collections.Generic;

class Program1
{
    static bool AllSymbolsUnique(string s) // Проверяет все ли символы в строке уникальны
    {
        var symbols = new HashSet<char>();
        foreach (char c in s)
        {
            if (symbols.Contains(c))
                return false;
            else
                symbols.Add(c);
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine(AllSymbolsUnique("hello there").ToString());
        Console.WriteLine(AllSymbolsUnique("hi there").ToString());
        Console.WriteLine(AllSymbolsUnique("world").ToString());
        Console.WriteLine(AllSymbolsUnique("").ToString());
        Console.WriteLine(AllSymbolsUnique(" the ").ToString());
    }
}
