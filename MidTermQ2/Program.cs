using System.Text.RegularExpressions;

namespace ExamQ2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string and I'll check if it's a palindrome.");

            string original = Console.ReadLine();
            string input = "";

            //adjusts the string before checking palindrome, removing punctuation
            input = original.Replace(" ", ""); //removes all whitespace
            input = input.ToLower(); //removes capitilization
            input = RemovePunctuation(input); //made the function for a prior lab uses a Regrex call. 
            
            
            bool palindome = IsPalindrome(input);

            if (palindome)
            {
                Console.WriteLine(original + " is a palindrome!");
            }
            else
            {
                Console.WriteLine(original + " is not a palindrome");
            }
        }

        static bool IsPalindrome (string input)
        {
            Stack<char> stack = new Stack<char> ();
            Queue<char> queue = new Queue<char> ();
            bool palindrome = false;

            foreach (char c in input) //sets the Queue and the stack
            {
                stack.Push (c);
                queue.Enqueue (c);
            }
            
            for (int i = 0; i < queue.Count; i++) //compares each character and returns false if a nonmatch occurs
            {
                char q = queue.Dequeue ();
                char st = stack.Pop ();

                if (q == st)
                {
                    palindrome = true;
                }
                else
                    return false; //one mismatch and it's over
            } // end for

            return palindrome;
        }
        static string RemovePunctuation(string input) //taken from my Recursion Lab's palindrome problem 
        {
            string noPunctuation = "";

            foreach (char ch in input)
            {
                if (!Regex.IsMatch(ch.ToString(), @"[.,\?//!@#$%^&*()+'=-_;:{}`~]")) //this should check each character from 
                {                                                                   //the input to the puncuation string and add each
                    noPunctuation += ch;                                            //non-punctuation character to the new string
                }
            }

            return noPunctuation;
        } //end removing punctuation method
    }
    }