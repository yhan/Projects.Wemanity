using System;
using System.Data.SqlClient;
using Bean.Q.Wemanity;
using System.Data.SqlClient;

namespace DataAccess.Q.Wemanity
{
    public class QuizExecutionDataProvider : IQuizExecutionDataProvider
    {
        readonly SqlConnection _myConnection = new SqlConnection("user id=username;" +
                                       "password=password;server=serverurl;" +
                                       "Trusted_Connection=yes;" +
                                       "database=database; " +
                                       "connection timeout=30");

        public IAnswersContainter Provide()
        {
            throw new NotImplementedException();

            try
            {
                _myConnection.Open();
            }
            catch (Exception)
            {
                throw;
            }

            var sqlCommand = new SqlCommand
            {
                Connection = _myConnection
            };

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
            }
        }
    }
}