using MoodAnalyzer;

namespace TestMood
{
    [TestClass]
    public class MoodAnalyzeTest
    {
        private readonly Mood moodAnalyzer;
        public MoodAnalyzeTest()
        {
            moodAnalyzer = new Mood("");
        }
        [TestMethod]
        [DataRow("", "message is Empty")]
        [DataRow(null, "message is null")]
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_Happy(string input, string expected)
        {
            try
            {
                var result = moodAnalyzer.AnalyzeMood();
            }
            catch (System.Exception ex)
            {
                Assert.AreEqual(ex.Message, "message is Empty");
            }

        }
    }
}