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
    }
}