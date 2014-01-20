using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Bean.Q.Wemanity;
using Navigation.Q.Wemanity;
using Rhino.Mocks;
using NUnit.Framework;
using WorkflowManager.Q.Wemanity;

namespace Test.WorkflowManager.Q.Wemanity
{
    [TestFixture]
    public class QuizExecutionTest
    {
        private IQuizNavigator _mockNavigator;
        private QuizExecution _quizExecution;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _mockNavigator = MockRepository.GenerateMock<IQuizNavigator>();
            _quizExecution = new QuizExecution(_mockNavigator);
        }

        [SetUp]
        public void SetUp()
        {

        }
        
        [Test]
        public void TestAnswerQuestion()
        {
            const int questionId = 0;
            //Stub
            _mockNavigator
                .Stub(navigator => navigator.GetCurrent())
                .Return(QcmProvider.Get(questionId, new[] { 2 }));

            //Exec
            _quizExecution.Next();
            
            _quizExecution.AnswerCurrent(new QcmAnswer(questionId, new[] { 2 }));

            //Assert
            var candidateAnswerForQuestions = _quizExecution.Answers.AsEnumerable();

            var answerForQuestions = candidateAnswerForQuestions as CandidateAnswerForQuestion[] ?? candidateAnswerForQuestions.ToArray();

            Assert.AreEqual(1, answerForQuestions.Count());
            Assert.AreEqual(0, answerForQuestions.First().Question.Id);

        }

    }
}