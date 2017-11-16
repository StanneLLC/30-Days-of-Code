using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        var N = int.Parse(Console.ReadLine());
        
        for(var i = 0; i < N; i++)
        {
            var myString = Console.ReadLine();
            
            for(var j = 0; j < myString.Length; j++)
            {
                if (j % 2 == 0) Console.Write(myString[j]);
            }
            
            Console.Write(" ");
            
            for (var j = 0; j < myString.Length; j++)
            {
                if(j % 2 != 0) Console.Write(myString[j]);
            }
            
            Console.Write(Environment.NewLine);
        }
    }
}