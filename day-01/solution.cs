using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Declare second integer, double, and String variables.
        int y =Convert.ToInt32(Console.ReadLine());
        double z = Convert.ToDouble(Console.ReadLine());
        string x =Console.ReadLine();
        
        // Read and save an integer, double, and String to your variables
        
        // Print the sum of both integer variables on a new line.
         Console.WriteLine(y + i);

        // Print the sum of the double variables on a new line.
        Console.WriteLine(String.Format("{0:.0}",z + d));
        // Concatenate and print the String variables on a new line
         Console.WriteLine(s +" "+ x);
        // The 's' variable above should be printed first

    }
}