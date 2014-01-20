using Bean.Q.Wemanity;

namespace Test.WorkflowManager.Q.Wemanity
{
    class FakeQuestion : QuestionBase
    {
        public FakeQuestion(int id, string body) : base(id, body)
        {
        }

        public override TypeQuestion Type
        {
            get { return TypeQuestion.Fake; }
        }


    }
}