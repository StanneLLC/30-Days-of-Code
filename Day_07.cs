/*
Day 7: Arrays

Objective 
Today, we're learning about the Array data structure. Check out the Tutorial tab for
learning materials and an instructional video!

Task 
Given an array, A, of N integers, print A's elements in reverse order as a single line of space-separated numbers.

Input Format

The first line contains an integer, N (the size of our array). 
The second line contains N space-separated integers describing array A's elements.

Constraints

1 <= N <= 1000, 1 <= A(sub i) <= 10,000, where A(sub i) is the ith integer in the array.
Output Format

Print the elements of array  in reverse order as a single line of space-separated numbers.

Sample Input

4
1 4 3 2
Sample Output

2 3 4 1
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        Array.Reverse(arr);
        
        foreach(var value in arr)
        {
            Console.Write($"{value} ");
        }
        
    }
}