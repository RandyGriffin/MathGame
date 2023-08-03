using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Class1
    {
        public Class1() //class where I write notes and stuff. Should be deleted lol
        {
            int index = 1;
            string name = "Pablo";
            char initial = 'P';
            int year = 2022;
            decimal height = 1.85m;
            bool doWeLoveToCode = true;

            // String interpolation $. use $@ to print multiple lines of code 
            string myParagraph = $@"These are the most common data types:       
        {index++} - string, example: {name}
        {index++} - char, example: {initial}
        {index++} - int, example: {year}
        {index++} - decimal, example: {height}
        {index++} - bool, example: {doWeLoveToCode}";

            Console.WriteLine(myParagraph);

            Console.ReadLine();
        }
    }
}
