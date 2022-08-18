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
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_Null(string input, string expected)
        {
            try
            {
                var result = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Null");
            }
        }
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_EmptyMessage(string input, string expected)
        {
            try
            {
                var result = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }

        }
        [TestMethod]
        public void GivenMoodAnalysisClassName_ShouldReturnMoodAnalysisObject()
        {
            object expected = new Mood();
            object obj = AnalyzeFactory.CreateMoodAnalysis("MoodAnalyzer.Mood", "Mood");
            expected.Equals(obj);
        }
    }
}