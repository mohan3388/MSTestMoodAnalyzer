using MoodAnalyzer;

namespace TestMood
{
    [TestClass]
    public class MoodAnalyzeTest
    {
        private readonly Mood moodAnalyzer;

        public MoodAnalyzeTest()
        {
            moodAnalyzer = new Mood("I am in SAD Mood");
        }

        [TestMethod]
        public void To_Check_Mood_Happy_or_Sad()
        {
            {
                var result = moodAnalyzer.MoodAnalyze();
                Assert.AreEqual(result, "SAD");
            }
        }
    }
}