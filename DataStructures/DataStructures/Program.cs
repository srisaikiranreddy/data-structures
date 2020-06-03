using System;
using DataStructures.Math;
using DataStructures.Sort;
using DataStructures.Strings;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Start running Data Structures");

            ///-----------Math--------------//
            Console.Write("Running Math problems");
            EvenNumber evenNumber = new EvenNumber();
            PrimeNumber primeNumber = new PrimeNumber();
            OddNumber oddNumber = new OddNumber();

            ///----------Sort--------------//
            BubbleSort bubbleSort = new BubbleSort();
            InsertionSort insertSort = new InsertionSort();
            SelectionSort selectSort = new SelectionSort();

            ///-----------Strings-----------//
            PandigitalConcatenation pandigitalConcatenation = new PandigitalConcatenation();

            
            
        }
    }
}
