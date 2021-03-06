﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day 1
//            var changeStrings = ReadInput("Day1/Day1-Input.txt");
//            Day1 day1 = new Day1(changeStrings);
//            day1.Output();
            
            // Day 2
//            var boxIDStrings = ReadInput("Day2/Day2-Input.txt");
//            Day2 day2 = new Day2(boxIDStrings);
//            day2.Output();
            
            // Day 3
//            var claimStrings = ReadInput("Day3/Day3-Input.txt");
//            Day3 day3 = new Day3(claimStrings);
//            day3.Output();
            
            // Day 4
            var guardStrings = ReadInput("Day4/Day4-Input.txt");
            Day4 day4 = new Day4(guardStrings);
        }

        static IEnumerable<string> ReadInput(string fileName)
        {
            return System.IO.File.ReadAllLines(fileName);
        }
    }
}
