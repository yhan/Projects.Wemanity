using System;

namespace Bean.Q.Wemanity
{
    public class OpenQuestion : QuestionBase 
    {
        public string ResponseForReference { get; private set; }

        public OpenQuestion(int id, string body, string responseForReference) : base(id, body)
        {
            ResponseForReference = responseForReference;
        }

        public override TypeQuestion Type
        {
            get
            {
                return TypeQuestion.Open;
            }
        }

        

        public void RespondAction()
        {
            throw new NotImplementedException();
        }
    }
}