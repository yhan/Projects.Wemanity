using Bean.Q.Wemanity;

namespace WorkflowManager.Q.Wemanity
{
    public abstract class QuestionCheckerBase
    {
        public abstract bool Execute(CandidateAnswerForQuestion candidateAnswerForQuestion);
    }
}
