using System;

namespace WorkflowManager.Q.Wemanity
{
    public class QuizChecker
    {
        private readonly QuizExecution _quizExecution;

        public QuizChecker(QuizExecution quizExecution)
        {
            _quizExecution = quizExecution;
        }

        public QuizExecution GetExecution()
        {
            return _quizExecution;
        }
    }
}