namespace Bean.Q.Wemanity
{

    /// <summary>
    /// Answer for open question bean
    /// </summary>
    public class OpenQuestionAnswer : AnswerBase
    {
        public OpenQuestionAnswer(int questionId, string answer) : base(questionId)
        {
            Answer = answer;
        }

        public string Answer { get; private set; }
    }
}