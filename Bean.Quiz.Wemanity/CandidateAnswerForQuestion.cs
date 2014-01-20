namespace Bean.Q.Wemanity
{
    public class CandidateAnswerForQuestion
    {
        public CandidateAnswerForQuestion(IQuestion question, IAnswer answer)
        {
            Question = question;
            Answer = answer;
        }

        public IQuestion Question { get; private set; }

        public IAnswer Answer { get; private set; }
    }
}