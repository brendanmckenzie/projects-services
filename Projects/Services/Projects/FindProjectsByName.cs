using System.Collections.Generic;
using Dapper;

namespace Projects.Services.Projects
{
    public class FindProjectsByName : BaseService
    {
        #region Constants

        const string Sql = @"select Id, Name from Project where Name like '%' + @name + '%'";

        #endregion

        #region Public Methods

        /// <summary>
        /// Finds projects with the given name.
        /// </summary>
        /// <param name="name">The name to query projects on.</param>
        /// <returns>The projects with the given name if found.</returns>
        public IEnumerable<Models.Project> Execute(string name)
        {
            using (var connection = GetConnection())
            {
                return connection.Query<Models.Project>(Sql, new { name = name });
            }
        }

        #endregion
    }
}
