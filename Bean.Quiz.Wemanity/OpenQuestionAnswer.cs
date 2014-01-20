namespace Bean.Q.Wemanity
{
    public class OpenQuestionAnswer : AnswerBase
    {
        public OpenQuestionAnswer(int questionId, string answer) : base(questionId)
        {
            Answer = answer;
        }

        public string Answer { get; private set; }
    }
}