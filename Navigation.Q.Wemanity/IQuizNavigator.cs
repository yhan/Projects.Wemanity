using Bean.Q.Wemanity;

namespace Navigation.Q.Wemanity
{
    public interface IQuizNavigator
    {
        IQuestion GetCurrent();
        IQuestion GetNext();
        IQuestion GetPrevious();
        void WindToEnd();
        void WindbackToFirst();
    }
}