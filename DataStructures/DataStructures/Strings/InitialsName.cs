using System;

namespace DataStructures.Strings
{
    /// <summary>
    /// Input  : prabhat kumar singh
    //Output : P K S
    //We take the first letter of all
    //words and print in capital letter.

    //Input  : Jude Law
    //Output : J L

    //Input  : abhishek kumar singh
    //Output : A K S
    /// </summary>
    public class InitialsName
    {
        public InitialsName()
        {
            Console.WriteLine("Print InitialsName");
            string[] input = { "prabhat kumar singh", "Jude Law", "abhishek kumar singh" };
            foreach(var s in input)
            {
                Console.WriteLine("Input:" + s);
                Console.WriteLine("Output:" + RemoveInitials(s));
            }
        }

        static string RemoveInitials(string name)
        {
            string[] nameSplit = name.Split(" ");
            char[] initials = new char[nameSplit.Length];
            for (int i=0;i<nameSplit.Length;i++)
            {
                initials[i] = nameSplit[i].ToCharArray()[0];
            }
            return String.Join(" ",initials).ToUpper();
        }
    }
}
