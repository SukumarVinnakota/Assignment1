/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK

*/
using System;
using System.Text.RegularExpressions;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0}", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.

        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"

        Example 2:
        Input: s = "aeiou"
        Output: ""

        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                // write your code here
                String final_string = s;
                //Created Array of strings for storing vowels
                String[] alpha = { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U" };
                //checking the constraints i.e, 0 <= s.length <= 10000 and checking if the data only has alphabets using Regex
                if (s.Length >= 0 && s.Length <= 10000 && Regex.IsMatch(s, @"^[a-zA-Z]+$"))
                {
                    //iterating each vowel 
                    foreach (String test in alpha)
                    {
                        //replace the vowel with empty string and assigning it to final_string variable
                        final_string = final_string.Replace(test, String.Empty);

                    }
                }
                else
                {
                    //If the input contains other than alphabets, below message will appear
                    final_string = "Please enter only words";
                }
                //Returning the final_string variable
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false

       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                //Instantiating variables
                String bulls1 = "";
                String bulls2 = "";
                //Iterating the first String Array bulls_string1
                for (int i = 0; i < bulls_string1.Length; i++)
                {
                    //concat values in bulls_string1 and assigning it to bulls1 and removing the spaces in between words
                    bulls1 = bulls1 + bulls_string1[i].Replace(" ","");
                }
                for (int i = 0; i < bulls_string2.Length; i++)
                {
                    //concat values in bulls_string2 and assigning it to bulls2 and removing the spaces in between words
                    bulls2 = bulls2 + bulls_string2[i].Replace(" ", "");
                }
                //comparing the bulls1 and bulls2 value by making both lowercase
                if (bulls1.ToLower().Equals(bulls2.ToLower()))
                {
                    //returning true for successful
                    return true;
                }
                //returning false for failure
                else return false;

            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                //Instantiating a array of int which stores 100 values
                int[] store = new int[100];
                //instantiating a int variable
                int final_int = 0;
                //Checking the contraints of input int list 
                if (bull_bucks.Length >= 0 && bull_bucks.Length <= 100)
                {
                    //Iterating the input int list
                    for (int i = 0; i < bull_bucks.Length; i++)
                    {
                        //Checking the contraints of input int array 
                        if (bull_bucks[i] >= 0 && bull_bucks[i] <= 100)
                        {
                            //Instantiating count for incrementing if any duplicates are present
                            int count = 0;
                            //Iterating the input int array
                            for (int j = 0; j < bull_bucks.Length; j++)
                            {
                                //Comparing the consecutive values of the input array
                                if (bull_bucks[i] == bull_bucks[j])
                                    //Incrementing the count if there are duplicates
                                    count = count + 1;
                            }
                            //Checking if there are no duplicates
                            if (count == 1)
                            {
                                //Stroing the unique integers in store list
                                store[i] = bull_bucks[i];
                            }
                        }
                    }
                    //Iterating the store list
                    for (int i = 0; i < store.Length; i++)
                    {
                        //adding the unique numbers
                        final_int = final_int + store[i];
                    }
                    

                }
                //returning the sum of unique numbers
                return final_int;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*

        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.

       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>

        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                //Instantiating length of bulls_grid matrix to d1
                int d1 = bulls_grid.GetLength(0);
                //Instantiating final_int
                int final_int = 0;
                //Iterating the bulls_grid based on its length
                for (int i = 0; i < d1; i++)
                {
                    //Iterating the bulls_grid based on its length
                    for (int j = 0; j < d1; j++)
                    {
                        //Checking if the numbers fall in the diagonal
                        if (i == j || (i + j) == (d1 - 1))
                        {
                            //Summing the numbers that fall in diagonal
                            final_int = final_int + bulls_grid[i, j];

                        }
                    }
                }
                //Returning the sum of numbers
                return final_int;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.

        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"

        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                //Insantiating final_string
                string final_string = "";
                //Checking if the length of string and indices match
                if (bulls_string.Length == indices.Length)
                {
                    //Iterating the input String
                    for (int i = 0; i < bulls_string.Length; i++)
                    {
                        //Iterating the input int list
                        for (int j = 0; j < indices.Length; j++)
                        {
                            //Checking if the value of indices matches with position of string
                            if (indices[j] == i)
                            {
                                //Concatinating the String
                                final_string = final_string + bulls_string[j];
                            }
                        }
                    }
                }
                else
                {
                    //If length of string and indices doesn't match below message will get displayed
                    final_string = "number of characters in string doesn't match to the number of indices";
                }
                //Returns final_string
                return final_string;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.

        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".

        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".

        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string, char ch)
        {
            try
            {
                //Instantiating the variables
                String prefix_string = "";
                String temp = "";
                String temp3 = "";
                String temp2 = "";
                //Checking for constraints
                if (bulls_string.Length >= 1 && bulls_string.Length <= 250 && char.IsLower(ch) && bulls_string.Equals(bulls_string.ToLower()))
                {
                    //Iterating the input String
                    for (int i = 0; i < bulls_string.Length; i++)
                    {
                        //Checking if character in the string matches with ch
                        if (bulls_string[i].Equals(ch))
                        {
                            //Spliting the string from the identifies character
                            temp = bulls_string.Substring(0, (i + 1));
                            break;
                        }
                    }
                    //if the assigned variable is not empty
                    if (temp != "")
                    {
                        //Assigning temp2 with removing temp from bulls_string
                        temp2 = bulls_string.Replace(temp, "");
                        //Converting temp to charArray
                        char[] charArray = temp.ToCharArray();
                        //Reversing the charArray
                        Array.Reverse(charArray);
                        //Iteraring the charArray
                        foreach (char temp4 in charArray)
                            //Assigning the temp3 with individual characters
                            temp3 = temp3 + temp4;
                        //Concatinating 2 Strings for getting final string
                        prefix_string = temp3 + temp2;
                    }
                    else
                    {
                        // If assigned variable is empty, output will be empty string
                        prefix_string = bulls_string;
                    }
                }
                //returns final value
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}