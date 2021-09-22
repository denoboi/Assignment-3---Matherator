using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgrammingAssignment3
{
    /// <summary>
    /// Provides a variety of numeric methods
    /// </summary>
    public class Matherator
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Matherator()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Prints the numbers from 1 to 10
        /// </summary>
        public void PrintOneToTen()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Prints the numbers from m to n
        /// </summary>
        /// <param name="m">m</param>
        /// <param name="n">n</param>
        public void PrintMToN(int m, int n)
        {
            for (int i = m; i <= n; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

        }

        /// <summary>
        /// Returns the tenth even number, with 2 as the first even number
        /// </summary>
        /// <returns>tenth even number</returns>
        public int GetTenthEvenNumber()
        {
            int Answer = 0;
            int Even = 0;

            for (int i = 2; Even < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Even++;
                }
                if (Even == 10)
                {
                    Answer = i;
                }
            }

            return Answer;

        }

        /// <summary>
        /// Returns the nth even number, with 2 as the first even number
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>nth even number</returns>
        public int GetNthEvenNumber(int n)
        {
            int even = 0;
            int answer = 0;
            for (int x = 2; answer <= n; x++)
            {
                if (x % 2 == 0)
                {
                    even++;
                }
                if (even == n)
                {
                    answer = x;
                }
            }

            // delete code below; only included so we could compile
            return answer;
        }

    }

        #endregion
    }
