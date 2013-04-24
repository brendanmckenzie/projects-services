using System;
using System.Linq;
using Dapper;

namespace Projects.Services.Projects
{
    public class GetProjectById : BaseService
    {
        #region Constants

        const string Sql = @"select Id, Name from Project where Id = @id";

        #endregion

        #region Public Methods

        /// <summary>
        /// Finds a project with the given identifier.
        /// </summary>
        /// <param name="id">The database identifier of the project to find.</param>
        /// <returns>The project with the given database identifier if found; otherwise <c>null</c>.</returns>
        public Models.Project Execute(Guid id)
        {
            using (var connection = GetConnection())
            {
                return connection.Query<Models.Project>(Sql, new { id = id }).FirstOrDefault();
            }
        }

        #endregion
    }
}
