using Bean.Q.Wemanity;
using Navigation.Q.Wemanity;
using NUnit.Framework;
using WorkflowManager.Q.Wemanity;

namespace Test.WorkflowManager.Q.Wemanity
{
    [TestFixture]
    public class QuizNavigatorTest
    {
        private QuizNavigator _quizNavigator;

        private const int Size = 2;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            var quiz = new Quiz();
            _quizNavigator = new QuizNavigator(quiz);

            var quizBuilder = new QuizBuilder(quiz);

            for (int i = 0; i < Size; i++)
            {
                quizBuilder.AddQuestion(new FakeQuestion(1, "Who are you?"));    
            }
        }

        [SetUp]
        public void SetUp()
        {

        }


        [TearDown]
        public void TearDown()
        {
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {

        }


        [Test]
        public void TestWalkForward()
        {
            _quizNavigator.WindbackToFirst();

            IQuestion question;
            var countNotNull = 0;
            do
            {
                question = _quizNavigator.GetNext();
                if (question != null) countNotNull++;
            } while (question != null);
            
            Assert.AreEqual(Size, countNotNull);
        }

        [Test]
        public void TestWalkBackward()
        {
            _quizNavigator.WindToEnd();

            IQuestion question;
            int countNotNull = 0;
            do
            {
                question = _quizNavigator.GetPrevious();
                if (question != null) countNotNull++;
            } while (question != null);

            Assert.AreEqual(Size-1, countNotNull);

        }

    }
}