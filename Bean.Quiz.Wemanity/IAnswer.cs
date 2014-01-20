using System.Threading;

namespace Bean.Q.Wemanity
{
    public interface IAnswer
    {
        int QuestionId { get; }
    }

    public class AnswerBase : IAnswer
    {
        public int QuestionId { get; private set; }

        protected AnswerBase(int questionId)
        {
            QuestionId = questionId;
        }
    }

    public class QcmAnswer : AnswerBase
    {
        public QcmAnswer(int questionId, int[] selected): base(questionId)
        {
            Selected = selected;
        }

        public int[] Selected { get; private set; }
    }

    public class OpenQuestionAnswer : AnswerBase
    {
        public OpenQuestionAnswer(int questionId, string answer) : base(questionId)
        {
            Answer = answer;
        }

        public string Answer { get; private set; }
    }
}