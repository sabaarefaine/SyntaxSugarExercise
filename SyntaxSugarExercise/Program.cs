﻿using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //inferred typing
            //string interpolation
            //ternary operator

            //int answer = 4;
            //string response;
            //
            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + “greater than or equal to nine”;
            //}

            var answer = 4;

            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} greater than or equal to nine";

            Console.WriteLine(response);
        }
    }
}
