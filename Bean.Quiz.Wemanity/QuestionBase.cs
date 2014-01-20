using System;

namespace Bean.Q.Wemanity
{
    public abstract class QuestionBase : IQuestion
    {
        public bool Equals(IQuestion other)
        {
            return Id == other.Id;
        }

        public abstract TypeQuestion Type { get; }
        public int Id { get; private set; }
        public string Body { get; private set; }

        protected QuestionBase(int id, string body)
        {
            Id = id;
            Body = body;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}