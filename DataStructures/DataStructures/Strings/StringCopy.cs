using System;
namespace DataStructures.Strings
{
    /// <summary>
    /// Input : s1 = "hello"
    //        s2 = "geeksforgeeks"
    //Output : s2 = "hello"

    //Input :  s1 = "geeksforgeeks"
    //         s2 = ""
    //Output : s2 = "geeksforgeeks"
    /// </summary>
    public class StringCopy
    {
        public StringCopy()
        {
            Console.WriteLine("\n Print StringCopy");
            char[] s1 = "GEEKSFORGEEKS".ToCharArray();
            char[] s2 = new char[s1.Length];
            int index = 0;
            Console.WriteLine("\n Print StringCopy before");
            Console.WriteLine(String.Join("", s1));
            myCopyRecursive(s1, s2, index);
            Console.WriteLine("\n Print StringCopy after");
            Console.WriteLine(String.Join("", s2));
        }

        static void myCopy(char[] s1, char[] s2)
        {
            int i = 0;
            for (i = 0; i < s1.Length; i++)
                s2[i] = s1[i];
        }

        static void myCopyRecursive(char[] s1, char[] s2, int index)
        {
            // copying each character from s1 to s2  
            s2[index] = s1[index];

            // if string reach to end then stop  
            if (index == s1.Length - 1)
            {
                return;
            }

            // increase character index by one  
            myCopyRecursive(s1, s2, index + 1);
        }

    }


}
