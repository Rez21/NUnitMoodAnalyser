using MoodAnalyzer;

namespace MoodAnalyzerTestCases
{
    public class Tests
    {
        MoodAnalysar moodAnalyzer;

        [SetUp]
        public void Setup()
        {
            moodAnalyzer = new MoodAnalysar();   
        }

        [Test]
        public void GiveMessage_WhenSad_ReturnSadDefaultConstructor()
        {
            //Arrange
            moodAnalyzer = new MoodAnalysar();
            string message = "I am in sad mood";
            //Act
            string result = moodAnalyzer.MoodAnalyzerWithConstructor(message);
            //Assert
            Assert.AreEqual("SAD", result);
        }
        [Test]
        public void GiveMessage_WhenHappy_ReturnHappyDefaultConstructor()
        {
            moodAnalyzer = new MoodAnalysar();
            string message = "I am in any mood";
            string result = moodAnalyzer.MoodAnalyzerWithConstructor(message);
            Assert.AreEqual("HAPPY",result);
        }

        public void GiveMessage_WhenSad_ReturnSadWithParameterisedConstructor()
        {
            moodAnalyzer = new MoodAnalysar("I am in sad mood");
            string message = moodAnalyzer.MoodAnalyzerWithParameterisedConstructor();
        }
    }
}