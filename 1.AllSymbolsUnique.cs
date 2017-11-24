using System;
using System.Collections.Generic;
using System.Linq;

class Program1
{
    static bool AllSymbolsUnique(string s) // Кажется это кривой способ
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

    static bool AllSymbolsUnique2(string s) // Требует System.Collections.Generic
    {
        var symbols = new HashSet<char>(s);
        return (symbols.Count == s.Length) ? true : false;
    }

    static bool AllSymbolsUnique3(string s) // Требует System.Linq
    {
        return (s.Distinct().Count() == s.Length) ? true : false;
    }

    static void Main()
    {
        Console.WriteLine(AllSymbolsUnique3("hello there").ToString());
        Console.WriteLine(AllSymbolsUnique3("hi there").ToString());
        Console.WriteLine(AllSymbolsUnique3("world").ToString());
        Console.WriteLine(AllSymbolsUnique3("").ToString());
        Console.WriteLine(AllSymbolsUnique3(" the ").ToString());
    }
}
