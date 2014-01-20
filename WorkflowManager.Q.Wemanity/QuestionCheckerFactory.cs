using System;
using Bean.Q.Wemanity;

namespace WorkflowManager.Q.Wemanity
{
    public class QuestionCheckerFactory
    {
        public QuestionCheckerBase Get(TypeQuestion questionType)
        {
            switch (questionType)
            {
                case TypeQuestion.Open:

                    return new OpenQuestionChecker();
                case TypeQuestion.Qcm:
                    return new QcmChecker();
                case TypeQuestion.Fake:
                    return new FakeQuestionChecker();
                default:
                    throw new ArgumentOutOfRangeException("questionType");
            }
        }
    }
}