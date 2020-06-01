using System;
namespace DataStructures.Strings
{
    public class StringCopy
    {
        public StringCopy()
        {
        }

        static void myCopy(char[] s1, char[] s2)
        {
            int i = 0;
            for (i = 0; i < s1.Length; i++)
                s2[i] = s1[i];
        }

        static void myCopyRecursive(char[] s1,
                       char[] s2, int index)
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
