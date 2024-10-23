using System;

namespace Ex_02

{

class Program

    {

static void Main(string[] args)

        {

            string[] sentence = { "Hello! ", "and", " Welcome", " to", " this", " Demo!" };

            Console.WriteLine(merge_array(sentence));
        }
        private static string merge_array(string[] sentence)

        {

            string S= string.Concat(sentence);

            return S;

        }

    }

}