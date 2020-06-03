using System;
using DataStructures.Math;
using DataStructures.Strings;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Start running Data Structures");

            ///-----------Strings-----------//
            PandigitalConcatenation pandigitalConcatenation = new PandigitalConcatenation();

            
            ///-----------Math--------------//
            Console.Write("Running Math problems");
            EvenNumber evenNumber = new EvenNumber();
            PrimeNumber primeNumber = new PrimeNumber();
            OddNumber oddNumber = new OddNumber();
        }
    }
}
