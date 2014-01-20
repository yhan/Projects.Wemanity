namespace Bean.Q.Wemanity
{
    public class QcmAnswer : AnswerBase
    {
        public QcmAnswer(int questionId, int[] selected): base(questionId)
        {
            Selected = selected;
        }

        public int[] Selected { get; private set; }
    }
}