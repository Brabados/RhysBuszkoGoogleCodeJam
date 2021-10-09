using System;

    public class StandingOvation
    {
        public String NumberOfFriends(String Audience)
        {

        char[] Breakdown = Audience.ToCharArray();


        int MinInvite = 0;
            int Iterator = 0;
            int Total = 0;

        foreach(char x in Breakdown)
        {

            MinInvite = Math.Max(MinInvite, Iterator - Total);

            Total += (int)char.GetNumericValue(x); ;

            Iterator = Iterator + 1;
        }

        String Answer = MinInvite.ToString();

        return Answer;
        }

    }

