using System.Collections.Generic;
using System.Linq;
using Bean.Q.Wemanity;

namespace Test.WorkflowManager.Q.Wemanity
{
    public class QcmProvider
    {
        public static  QcmQuestion Get(int questionId, int[] goodAnswersForQuestion)
        {
            return new QcmQuestion(questionId, "Who are you?", new List<QcmChoice>
            {
                new QcmChoice(1, "Answer 1", goodAnswersForQuestion.Contains(1)),
                new QcmChoice(2, "Answer 2", goodAnswersForQuestion.Contains(2)),
                new QcmChoice(3, "Answer 3", goodAnswersForQuestion.Contains(3)),
                new QcmChoice(4, "Answer 4", goodAnswersForQuestion.Contains(4)),
            });
        }
    }
}