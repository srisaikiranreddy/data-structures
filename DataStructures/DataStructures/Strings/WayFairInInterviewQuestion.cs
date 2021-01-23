using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace DataStructures.Strings
{
//    student_course_pairs_1 = [
//  ["58", "Linear Algebra"],
//  ["94", "Art History"],
//  ["94", "Operating Systems"],
//  ["17", "Software Design"],
//  ["58", "Mechanics"],
//  ["58", "Economics"],
//  ["17", "Linear Algebra"],
//  ["17", "Political Science"],
//  ["94", "Economics"],
//  ["25", "Economics"],
//  ["58", "Software Design"],
//]

//Sample Output(pseudocode, in any order):

//find_pairs(student_course_pairs_1) =>
//{
//  "58,17": ["Software Design", "Linear Algebra"]
//  "58,94": ["Economics"]
//  "58,25": ["Economics"]
//  "94,25": ["Economics"]
//  "17,94": []
//  "17,25": []
//}
public class WayFairInInterviewQuestion
    {
        public WayFairInInterviewQuestion()
        {
            Console.Write("\n Print PalindroneString Input aba");
            string[,] input = new string[,] {{"58", "Linear Algebra"},
                                            {"94", "Art History"},
                                            {"94", "Operating System"},
                                            {"17", "Software Design"},
                                            {"58", "Mechanics"},
                                            {"58", "Economics"},
                                            {"17", "Linear Algebra"},
                                            {"17", "Political Scienc"},
                                            {"94", "Economics"},
                                            {"25", "Economics"},
                                            {"58", "Software Design"}};
            foreach (var de in CoursePairs(input))
                Console.WriteLine("\n Key: {0}, Value: {1}", de.Key, de.Value);            
        }

        static Dictionary<string, string> CoursePairs(string[,] input)
        {
            Hashtable coursePairs = new Hashtable();
            for(int i=0;i<input.Length/2;i++)
            {
                if(coursePairs.ContainsKey(input[i, 0]))
                {
                    string value = coursePairs[input[i, 0]]+","+input[i, 1];
                    coursePairs.Remove(input[i, 0]);
                    coursePairs.Add(input[i, 0], value);
                }
                else
                    coursePairs.Add(input[i, 0], input[i, 1]);
            }
            //Search(coursePairs);
            for (int i = 0; i < input.Length / 2; i++)
            {
                //var c = coursePairs.ContainsKey(input[i,1]);
                //if(c)
                //{
                //    var test = new 
                //}
            }
            return null;
        }

        //static Dictionary<string,string> Search(Hashtable coursePairs)
        //{
        //    for (int i= 0; i< coursePairs.Count; i++)
        //    {
        //        var studentID = coursePairs.;
        //        var studentCourses = coursePairs[studentID].ToString().Split(",");
                
        //        //for (int j = s + 1; s < coursePairs[s].IndexOf(,).Count; j++)
        //        //{

        //        //}
        //    }
        //    return null;
        //}
    }
}
