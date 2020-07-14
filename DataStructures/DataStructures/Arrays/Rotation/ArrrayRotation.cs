using System;
using System.Reflection;

namespace DataStructures.Arrays.Rotation
{
    public class ArrrayRotation
    {
//        Input arr[] = [1, 2, 3, 4, 5, 6, 7], d = 2, n = 7
//1) Store the first d elements in a temp array
//   temp[] = [1, 2]
//2) Shift rest of the arr[]
//   arr[] = [3, 4, 5, 6, 7, 6, 7]
//3) Store back the d elements
//   arr[] = [3, 4, 5, 6, 7, 1, 2]
        public ArrrayRotation()
        {
            Console.WriteLine("Array rotation input:[1, 2, 3, 4, 5, 6, 7]");
            Console.WriteLine("Array rotation output:[1, 2, 3, 4, 5, 6, 7] Array Rotation: 2");
            foreach(var n in Rotate(new[] { 1, 2, 3, 4, 5, 6, 7}, 2))
            {
                Console.Write(n);
            }

            Console.WriteLine("Array rotation input:[1, 2, 3, 4, 5, 6, 7]");
            Console.WriteLine("Array rotation output:[1, 2, 3, 4, 5, 6, 7] Array Rotation: 4");
            foreach (var n in Rotate(new[] { 1, 2, 3, 4, 5, 6, 7 }, 4))
            {
                Console.Write(n);
            }


        }

        static int[] Rotate(int[] input, int size)
        {
            int[] temp = new int[size];

            
            for (int i = 0; i < size; i++)
            {
                temp[i] = input[i];
            }

            for (int i = 0; i <input.Length-size; i++)
            {
                input[i] = input[i + size];
            }
            for (int i = 0; i < size; i++)
            {
                input[(input.Length-size) + i] = temp[i];
            }
            return input;
        }
    }
}
