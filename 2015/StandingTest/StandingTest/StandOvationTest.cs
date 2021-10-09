using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RhysBuszkoGoogleCodeJam;

[TestClass]
    public class StandOvationTest
    {
        [TestMethod]
        public void CheckACorrctAnswerIsObtained()
        {

            string[] TestData = new string[1] {"11111" };
            string Answer = "Case 1 : 0" + Environment.NewLine;

            var StandingOvation = new StandingOvation();

            string Result = StandingOvation.NumberOfFriends(TestData);

            Assert.AreEqual(Result, Answer, Answer);

        }


        [TestMethod]
        public void CheckMultiCalculationsForCorrectAnswers()
        {
            string[] TestData = new string[4] { "11111","09","110011","1" };
            int[] Answers = new int[4] {0,1,2,0 };

            bool Answer = true;
            int Iterator = 0;
            int Fails = 0;
      
            

            var StandingOvation = new StandingOvation();

            foreach (string x in TestData)
            {
            char[] Breakdown = x.ToCharArray();

            if (Answers[Iterator] != StandingOvation.Calculate(Breakdown))
                {
                Answer = false;
                Fails += 1;
                }
            Iterator += 1;
            }

        Assert.IsTrue(Answer,Fails.ToString());
        }

    }
