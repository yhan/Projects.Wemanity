using System.Collections;
using System.Linq;
using Bean.Q.Wemanity;
using DataAccess.Q.Wemanity;
using Rhino.Mocks;
using NUnit.Framework;
using WorkflowManager.Q.Wemanity;

namespace Test.WorkflowManager.Q.Wemanity
{
    [TestFixture]
    public class QuizCheckerTest
    {
        private QuizChecker _checker;
        private IQuizExecutionDataProvider _quizExecutionDataProvider;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _quizExecutionDataProvider =
                MockRepository.GenerateMock<IQuizExecutionDataProvider>();
            
            //new QuizExecutionDataProvider();
            QuizExecution quizExecution = new QuizExecution(_quizExecutionDataProvider);
            _checker = new QuizChecker(quizExecution);
        }

        [SetUp]
        public void SetUp()
        {

        }


        [Test, TestCaseSource(typeof(TestCaseProvider), "TestCases")]
        public bool TestCheckExecute(int[] correctAnswers, int[] answers)
        {
            //prepare mock
            _quizExecutionDataProvider
                .Stub(p => p.Provide())
                .Return(GetAnswerContainerForTest(answers, correctAnswers))
                .Repeat.Once();

            QuizExecution execution = _checker.GetExecution();
            IAnswersContainter answ = execution.GetAnswer();
            CandidateAnswerForQuestion candidateAnswerForQuestion = answ.AsEnumerable().First();

            QuestionCheckerBase checker = new QuestionCheckerFactory().Get(candidateAnswerForQuestion.Question.Type);

            //Execute  & Assert
             return (checker.Execute(candidateAnswerForQuestion));
        }

        private IAnswersContainter GetAnswerContainerForTest(int[] selected, int[] goodAnswersForQuestion)
        {
            var answers = new AnswersContainter();

            const int questionId = 1;
            IQuestion q = QcmProvider.Get(questionId, goodAnswersForQuestion);
            answers[q] = new QcmAnswer(questionId, selected);

            return answers;
        }
    }

    public class QuizExecutionDataProviderForTest : IQuizExecutionDataProvider
    {
        public IAnswersContainter Provide()
        {
            throw new System.NotImplementedException();
        }
    }

    public class TestCaseProvider
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new[] { 1, 2, 3 }, new[] { 2, 4 }).Returns(false);
                yield return new TestCaseData(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }).Returns(true);
                yield return new TestCaseData(new[] { 1 }, new[] { 1 }).Returns(true);
                yield return new TestCaseData(new[] { 1 }, new[] { 2 }).Returns(false);
            }
        }
    }
}