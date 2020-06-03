using System;
using DataStructures.Math;
using DataStructures.Sort;
using DataStructures.Strings;
using DataStructures.Search;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Start running Data Structures");

            ///-----------Math--------------//
            Console.Write("\n Running Math problems");
            EvenNumber evenNumber = new EvenNumber();
            PrimeNumber primeNumber = new PrimeNumber();
            OddNumber oddNumber = new OddNumber();

            ///----------Search-------------//
            Console.Write("Running Search problems");
            LinearSearch linearSearch = new LinearSearch();

            ///----------Sort--------------//
            Console.Write("\n Running Sort problems");
            BubbleSort bubbleSort = new BubbleSort();
            InsertionSort insertSort = new InsertionSort();
            SelectionSort selectSort = new SelectionSort();

            ///-----------Strings-----------//
            Console.Write("\n Running Strings problems");
            PandigitalConcatenation pandigitalConcatenation = new PandigitalConcatenation();

            
            
        }
    }
}
