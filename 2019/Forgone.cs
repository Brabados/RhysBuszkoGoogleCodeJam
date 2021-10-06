using System;
using System.Collections.Generic;
using System.Text;

namespace RhysBuszkoGoogleCodeJam
{
    using System;

    public class Forgone
    {
        public int[] Input(int A)
        {

            string StrNumbers = A.ToString();

            char[] CharNumbers = StrNumbers.ToCharArray();

            char[] FirstNumber = new char[1];

            char[] SecondNumber = new char[1];

            Random r = new Random();
            int iteration = 0;
            foreach (char x in CharNumbers)
            {


                int ModNumber = (int)char.GetNumericValue(x);
                int NumberA;
                int NumberB;

                if (ModNumber == 0)
                {
                    NumberA = 0;
                    NumberB = 0;
                }
                else if (ModNumber == 1)
                {
                    NumberA = 1;
                    NumberB = 0;
                }
                else
                {
                    int y = 4;
                    while (y == 4)
                    {
                        y = r.Next(1, ModNumber - 1);
                    }
                    NumberA = y;
                    NumberB = ModNumber - NumberA;
                }

                string convertA = NumberA.ToString();
                string convertB = NumberB.ToString();

                FirstNumber[iteration] = convertA[0];
                SecondNumber[iteration] = convertB[0];

                Array.Resize(ref FirstNumber, FirstNumber.Length + 1);
                Array.Resize(ref SecondNumber, SecondNumber.Length + 1);
                iteration = iteration + 1;
            }
            iteration = 0;



            int[] AdditiveNumbers = new int[2];

            string test1 = "";
            string test2 = "";

            foreach (char x in FirstNumber)
            {
                if (iteration != FirstNumber.Length - 1)
                {
                    test1 += (int)char.GetNumericValue(x);
                }
                iteration = iteration + 1;
            }

            iteration = 0;

            foreach (char x in SecondNumber)
            {
                if (iteration != SecondNumber.Length - 1)
                {
                    test2 += (int)char.GetNumericValue(x);
                }
                iteration = iteration + 1;
            }

            AdditiveNumbers[0] = Convert.ToInt32(test1);
            AdditiveNumbers[1] = Convert.ToInt32(test2);

            return AdditiveNumbers;
        }
    }
}

