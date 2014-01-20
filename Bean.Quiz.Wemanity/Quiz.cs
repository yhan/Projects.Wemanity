using System;
using System.Collections.Generic;
using System.Linq;

namespace Bean.Q.Wemanity
{
    public class Quiz
    {
        public Lazy<IList<IQuestion>> LazyQuestions = new Lazy<IList<IQuestion>>(() => new List<IQuestion>());
        private LinkedList<IQuestion> _linkedList;

        public Quiz() { }

        private IList<IQuestion> Content
        {
            get { return LazyQuestions.Value; }
        }

        public void Add(IQuestion question)
        {
            Content.Add(question);
        }

        //public Queue<IQuestion> AsQueue
        //{
        //    get
        //    {
        //        if (_queue == null)
        //            _queue = new Queue<IQuestion>(Content);
        //        return _queue;
        //    }
        //}


        private LinkedList<IQuestion> AsLinkedList()
        {
            return _linkedList ?? (_linkedList = new LinkedList<IQuestion>(Content));
        }

        private LinkedListNode<IQuestion> _current;

        internal bool TryGetNext(out IQuestion next)
        {
            next = null;

            if (Content.Count == 0)
                return false;

            if (_current == null)
            {
                _current = AsLinkedList().First;
                next = _current.Value;
                return true;
            }
            LinkedListNode<IQuestion> nextNode = _current.Next;
            if (nextNode == null) return false;

            _current = nextNode;
            next = _current.Value;
            return true;
        }

        internal bool TryGetPrevious(out IQuestion previous)
        {
            previous = null;

            if (Content.Count == 0) return false;
            if (_current == null)
            {
                return false;
            }
            LinkedListNode<IQuestion> previousNode = _current.Previous;


            if (previousNode == null) return false;

            _current = previousNode;
            previous = _current.Value;
            return true;
        }


        internal void WindToEnd()
        {
            LinkedList<IQuestion> asLinkedList = AsLinkedList();
            _current = asLinkedList.Last;
        }

        internal void WindbackToFirst()
        {
            _current = null;
        }

        internal bool TryGetCurrent(out IQuestion question)
        {
            question = null;
            if (Content.Count == 0 || _current == null) return false;
            question = _current.Value;
            return true;
        }
    }
}
