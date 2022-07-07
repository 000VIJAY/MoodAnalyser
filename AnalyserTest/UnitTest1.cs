using MoodAnalyser;
namespace AnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            Analyser analyser = new Analyser("I am Sad");
            string expected = "Sad";
            string res = analyser.MoodAnalyse();
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void TestMethodOne()
        {
            Analyser analyser = new Analyser("I am in Happy Mood");
            string expected = "Happy";
            string res = analyser.MoodAnalyse();
            Assert.AreEqual(expected,res);
        }
        [TestMethod]
        public void EmptyMoodShouldThrowExceptionIndicatingEmptyMood()
        {
            try
            {
                string message = "";
                Analyser analyser = new Analyser(message);
                string mood = analyser.MoodAnalyse();
            }
            catch(MoodException ex)
            {
                Assert.AreEqual("Provided message is empty", ex.Message);
            }
        }
        [TestMethod]
        public void NullMoodShouldThrowExceptionIndicatingNullMood()
        {
            try
            {
                string message = null;
                Analyser analyser = new Analyser(message);
                string mood = analyser.MoodAnalyse();
            }
            catch (MoodException ex)
            {
                Assert.AreEqual("Mood should not Null", ex.Message);
            }
        }
    }
}