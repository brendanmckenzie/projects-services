using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Projects.Services
{
    public abstract class BaseService
    {
        #region Protected Methods

        /// <summary>
        /// Gets a connection to the database.
        /// </summary>
        /// <returns>An open connection to the database.</returns>
        protected static IDbConnection GetConnection()
        {
            var result = new SqlConnection(ConnectionString);

            result.Open();

            return result;
        }

        #endregion

        #region Private Members

        static string ConnectionString = ConfigurationManager.ConnectionStrings["app:db"].ConnectionString;

        #endregion
    }
}
