using System;
using System.Collections.Generic;

namespace Bean.Q.Wemanity
{
    public class QcmChoice
    {
        public int Id { get; private set; }
        public string Text { get; private set; }
        public bool Correct { get; private set; }

        public QcmChoice(int id, string text, bool correct)
        {
            Id = id;
            Text = text;
            Correct = correct;
        }
    }

    public class QcmQuestion : QuestionBase
    {
        public override TypeQuestion Type
        {
            get
            {
                return TypeQuestion.Qcm;
            }
        }



        public ICollection<QcmChoice> Choices { get; private set; }

        public QcmQuestion(int id, string body, ICollection<QcmChoice> choices) : base(id, body)
        {
            Choices = choices;
        }

        
    }
}