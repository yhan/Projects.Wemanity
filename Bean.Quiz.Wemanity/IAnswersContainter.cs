using System.Collections.Generic;

namespace Bean.Q.Wemanity
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAnswersContainter
    {
        bool ContainsKey(int questionId);

        IAnswer this[IQuestion currentQuestion] { get; set; }

        IEnumerable<CandidateAnswerForQuestion> AsEnumerable();
    }
}