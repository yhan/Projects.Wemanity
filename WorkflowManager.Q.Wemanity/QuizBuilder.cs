using Bean.Q.Wemanity;

namespace WorkflowManager.Q.Wemanity
{
    public class QuizBuilder
    {
        private readonly Quiz _quiz;

        public void AddQuestion(IQuestion question)
        {
            _quiz.Add(question);
        }

        public QuizBuilder(Quiz quiz)
        {
            _quiz = quiz;
        }

    }
}