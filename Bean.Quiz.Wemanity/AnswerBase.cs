namespace Bean.Q.Wemanity
{
    public class AnswerBase : IAnswer
    {
        public int QuestionId { get; private set; }

        protected AnswerBase(int questionId)
        {
            QuestionId = questionId;
        }
    }
}