using System;

class Solution
{
    static void Main(String[] args)
    {
        Console.ReadLine();

        var s = Console.ReadLine();
        var arrNum = s.Split(' ');

        Array.Reverse(arrNum);

        foreach (var item in arrNum)
        {
            Console.Write($"{item} ");
        }
    }
}