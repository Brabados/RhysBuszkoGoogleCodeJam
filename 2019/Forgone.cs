
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
                        y = r.Next(0, ModNumber);
                    }
                    NumberA = y;
                    NumberB = ModNumber - NumberA;
                }

                string convertA = NumberA.ToString();
                string convertB = NumberB.ToString();

                if (iteration != 0)
                {
                    Array.Resize(ref FirstNumber, FirstNumber.Length + 1);
                    Array.Resize(ref SecondNumber, SecondNumber.Length + 1);
                }

                FirstNumber[iteration] = convertA[0];
                SecondNumber[iteration] = convertB[0];


                iteration = iteration + 1;
            }
            iteration = 0;



            int[] AdditiveNumbers = new int[2];

            AdditiveNumbers[0] = CharArrayToInt(FirstNumber);
            AdditiveNumbers[1] = CharArrayToInt(SecondNumber);

            return AdditiveNumbers;
        }

        public int CharArrayToInt(char[] ToConvert)
        {

            int Iteration = 0;
            int ToReturn = 0;

            string CharConversion = "";

            foreach (char x in ToConvert)
            {
                if (Iteration != ToConvert.Length)
                {
                    CharConversion += (int)char.GetNumericValue(x);
                }
                Iteration = Iteration + 1;
            }

            ToReturn = Convert.ToInt32(CharConversion);

            return ToReturn;

        }
    }


