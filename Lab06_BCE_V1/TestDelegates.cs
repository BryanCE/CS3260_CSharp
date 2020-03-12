using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Project Prolog
// Name: Bryan Edman
// CS3260 Section 001
// Project: Lab06
// Date: 2/28/2020
// I declare that the following code was written by me or provided
// by the instructor for this project. I understand that copying source
// code from any other source constitutes plagiarism, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

namespace Lab06_BCE_V1
{
    /// <summary>
    /// This class takes inputs and runs them through a delegate that is randomly chosen to take input
    /// </summary>
    class TestDelegate
    {
        //list of funcions to be used by delegates
        private List<Func<int, double, char, string, string>> _DList;
        private string display { get; set; }

        /// <summary>
        /// Calls a func randomly from _DList
        /// </summary>
        /// <returns>
        /// The Func that was randomly chosen
        /// </returns>
        private Func<int, double, char, string, string> RandomFunc()
        {
            Random random = new Random();
            return _DList[random.Next(0, _DList.Count)];
        }

        /// <summary>
        /// runs params through RandomFunc() 
        /// </summary>
        /// <param name="num">int from user</param>
        /// <param name="price">double from user</param>
        /// <param name="c">char from user</param>
        /// <param name="word">string from user</param>
        /// <returns>a string from the method called by RandomFunc()</returns>
        public string Getstring(int num, double price, char c, string word)
        {
            return RandomFunc()(num, price, c, word);
        }

        /// <summary>
        /// inserts the single character at the index of the number in the word
        /// </summary>
        /// <param name="num"></param>
        /// <param name="price"></param>
        /// <param name="letter"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        private static string InsertAt(int num, double price, char letter, string word)
        {
            string result;
            try
            {
                //get access to the open form
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                //call to change the label
                form1.ChangeLabel("Character inserted at index of Number.");

                return result = word.Insert(num, letter.ToString());
            }
            catch(ArgumentNullException)
            {
                return result = "Something went wrong."; 
            }
            catch(ArgumentOutOfRangeException)
            {
                return result = "Number is out of range for the size of your word.";
            }
        }

        /// <summary>
        /// Simply multiplys the price by the number given
        /// </summary>
        /// <param name="mult"></param>
        /// <param name="price"></param>
        /// <param name="rndChar"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        private static string MultByInt(int mult, double price, char rndChar, string word)
        {
            //get access to the open form
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            //call to change the label
            form1.ChangeLabel("Price multiplied by Number.");
            string result = (price * mult).ToString();
            return result;
        }

        /// <summary>
        /// finds the vowels in the word or the char given
        /// </summary>
        /// <param name="num"></param>
        /// <param name="price"></param>
        /// <param name="c"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        private static string FindVowels(int num, double price, char c, string word)
        {
            //get access to the open form
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            //call to change the label
            form1.ChangeLabel("Finding Vowels in Character or Word.");
            string result = "";
            try
            {
                Predicate<string> aFinder = (string s) => { return s.Contains("a"); };
                Predicate<string> eFinder = (string s) => { return s.Contains("e"); };
                Predicate<string> iFinder = (string s) => { return s.Contains("i"); };
                Predicate<string> oFinder = (string s) => { return s.Contains("o"); };
                Predicate<string> uFinder = (string s) => { return s.Contains("u"); };

                Predicate<string>[] sPredArr = { aFinder, eFinder, iFinder, oFinder, uFinder };
                int count = 0;
                foreach (Predicate<string> pred in sPredArr)
                {
                    if (pred(word)) count++;
                }
                result += string.Format("Your word has {0} vowel(s).\n", count);
                foreach (Predicate<string> pred in sPredArr)
                {
                    if (pred(c.ToString()))
                        result += "Your letter is a vowel.\n";
                }
                return result;
            }
            catch(ArgumentNullException)
            {
                return result = "Something went wrong try again.";
            }


        }



        /// <summary>
        /// Constructor
        /// </summary>
        public TestDelegate()

        {
            //get access to the open form
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            //call to change the label
            form1.ChangeLabel("Anonymous Function called.");

            _DList = new List<Func<int, double, char, string, string>>();

            // Add private methods and lambdas 
            _DList.Add(MultByInt);
            _DList.Add(InsertAt);
            
            _DList.Add(
                (int a, double b, char c, string d) => string.Format("All UpperCase:\t{0} {1:c} {2} {3}",
                a.ToString().ToUpper(), b.ToString().ToUpper() ,c.ToString().ToUpper() ,d.ToUpper()
            ));
            _DList.Add(FindVowels);

        }


    }

}
