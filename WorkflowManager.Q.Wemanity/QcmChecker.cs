using System;
using System.Linq;
using Bean.Q.Wemanity;

namespace WorkflowManager.Q.Wemanity
{
    public class QcmChecker : QuestionCheckerBase
    {
        public override bool Execute(CandidateAnswerForQuestion candidateAnswerForQuestion)
        {
            IQuestion question = candidateAnswerForQuestion.Question;
            IAnswer answer = candidateAnswerForQuestion.Answer;
            var qcmQuestion = question as QcmQuestion;
            var qcmAnswer = answer as QcmAnswer;
            if (qcmQuestion == null || qcmAnswer == null)
                throw new InvalidCastException(string.Format("question type error :{0}", candidateAnswerForQuestion.Question));


            int[] correctAnswers = qcmQuestion.Choices.Where(c => c.Correct).Select(c => c.Id).ToArray();

            return qcmAnswer.Selected.CompareTo(correctAnswers);
        }
    }
}