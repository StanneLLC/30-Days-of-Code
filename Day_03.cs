using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        var mealCost = double.Parse(Console.ReadLine());
        var tipPercent = int.Parse(Console.ReadLine());
        var taxPercent = int.Parse(Console.ReadLine());
        
        var tip = mealCost * tipPercent / 100;
        var tax = mealCost * taxPercent / 100;
        var totalCost = mealCost + tip + tax;
        
        Console.WriteLine($"The total meal cost is {totalCost} dollars.");
    }
}