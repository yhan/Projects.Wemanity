using System.Collections.Generic;
using System.Linq;
using Bean.Q.Wemanity;

namespace WorkflowManager.Q.Wemanity
{
    public class AnswersContainter : IAnswersContainter
    {
        private readonly IDictionary<IQuestion, IAnswer> _content = new Dictionary<IQuestion, IAnswer>();

        public bool ContainsKey(int questionId)
        {
            return _content.Keys.Any(q => q.Id == questionId);
        }

        public IAnswer this[IQuestion key]
        {
            get { return _content[key]; }
            set { _content[key] = value; }
        }

        public IEnumerable<CandidateAnswerForQuestion> AsEnumerable()
        {
            return _content.Select(pair => new CandidateAnswerForQuestion(pair.Key, pair.Value));
        }
    }
}