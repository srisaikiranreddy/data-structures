using System;
using DataStructures.Sort;
using Xunit;

namespace DataStructurcesTests.SortTests
{
    public class BubbleSortTests
    {
        private BubbleSort bubbleSort; 
        public BubbleSortTests()
        {
            Console.WriteLine("\n Print Bubble UnSort");
            foreach (var n in (new[] { 5, 7, 1, 2, 8 }))
            {
                Console.Write(n + " ");
            }
            
            
        }

        [Fact]
        public void Bubble()
        {
            string input = "qwertyuiopasdfghjklzxcvbnm0987654321~`!@#$%^&*()_-=+{}[]|;'<>?,./";
            bubbleSort = new BubbleSort(new[] { 5, 7, 1, 2, 8 }, input);
        }
    }
}
