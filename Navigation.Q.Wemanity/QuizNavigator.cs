using Bean.Q.Wemanity;

namespace Navigation.Q.Wemanity
{
    public class QuizNavigator : IQuizNavigator
    {
        private readonly Quiz _quiz;

        public QuizNavigator(Quiz quiz)
        {
            _quiz = quiz;
        }

        public int RespondedCount { get; private set; }


        public IQuestion GetCurrent()
        {
            IQuestion question;
            if (_quiz.TryGetCurrent(out question))
            {
                return question;
            }
            return null;
        }

        public IQuestion GetNext()
         {
             IQuestion question;
             return _quiz.TryGetNext(out question) ? question : null;
             //question.RespondAction();
             //RespondedCount++;
         }

        public IQuestion GetPrevious()
        {
            IQuestion question;
            return _quiz.TryGetPrevious(out question) ? question : null;

            //LinkedList<IQuestion> asLinkedList = _quiz.AsLinkedList();
            //LinkedList<IQuestion>.Enumerator enumerator = asLinkedList.GetEnumerator();
            //enumerator.Current
        }

        public void WindToEnd()
        {
            _quiz.WindToEnd();
        }

        public void WindbackToFirst()
        {
            _quiz.WindbackToFirst();
        }
    }
}
