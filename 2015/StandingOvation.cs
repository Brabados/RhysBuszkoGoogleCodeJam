using System;

    public class StandingOvation
    {
    public String NumberOfFriends(String[] Audiences)
    {
        String Answer = "";
        int CaseNumber = 1;

        foreach(string ShyGroup in Audiences)
            {
            char[] Breakdown = ShyGroup.ToCharArray();


            Answer += "Case " + CaseNumber.ToString() + " : " +  Calculate(Breakdown).ToString() + Environment.NewLine;
        }
        

        return Answer;
    }

    public int Calculate(Char[] ToMod)
    {
        int MinInvite = 0;
        int Iterator = 0;
        int Total = 0;

        foreach (char x in ToMod)
        {

            MinInvite = Math.Max(MinInvite, Iterator - Total);

            Total += (int)char.GetNumericValue(x); ;

            Iterator += 1;
        }
        return MinInvite;
    }

    }



