using Bean.Q.Wemanity;

namespace DataAccess.Q.Wemanity
{
    public interface IQuizExecutionDataProvider 
    {
        IAnswersContainter Provide();
    }
}