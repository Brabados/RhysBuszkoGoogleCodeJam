
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

        foreach (char x in CharNumbers)
        {
            int iteration = 0;

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
                while(y == 4)
                {
                    y = r.Next(1, ModNumber - 1);
                }
                NumberA = y;
                NumberB = ModNumber - NumberA;
            }

            FirstNumber[iteration] = (char)NumberA;
            SecondNumber[iteration] = (char)NumberB;

            Array.Resize(ref FirstNumber, FirstNumber.Length + 1);
            Array.Resize(ref SecondNumber, FirstNumber.Length + 1);
            iteration = iteration + 1;
        }

        

        int[] AdditiveNumbers = new int[2];

        AdditiveNumbers[0] = Convert.ToInt32(FirstNumber.ToString());
        AdditiveNumbers[1] = Convert.ToInt32(FirstNumber.ToString());


        return AdditiveNumbers;
    }
}