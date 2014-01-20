using System;
using Bean.Q.Wemanity;
using DataAccess.Q.Wemanity;
using Navigation.Q.Wemanity;

namespace WorkflowManager.Q.Wemanity
{
    public class QuizExecution : IDisposable
    {
        private readonly IQuizNavigator _quizNavigator;

        //        public Dictionary<IQuestion, IAnswer> Results = new Dictionary<IQuestion, IAnswer>(); 

        public readonly IAnswersContainter Answers = new AnswersContainter();
        private IQuizExecutionDataProvider _dataProvider;


        public QuizExecution(IQuizNavigator quizNavigator)
        {
            _quizNavigator = quizNavigator;
        }

        public QuizExecution(IQuizExecutionDataProvider provider)
        {
            _dataProvider = provider;
        }

        public IQuestion Next()
        {
            return _quizNavigator.GetNext();
        }


        public IQuestion Previous()
        {
            return _quizNavigator.GetPrevious();
        }

        public void AnswerCurrent(IAnswer answer)
        {
            IQuestion currentQuestion = _quizNavigator.GetCurrent();
            Answers[currentQuestion] = answer;

            //var factory = new QuestionExecutorFactory();
            //var executor = factory.Get(currentQuestion);
            //executor.Answer(answer);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IAnswersContainter GetAnswer()
        {
            return _dataProvider.Provide();

        }
    }
}