using System;
using System.Data;
using Dapper;

namespace Projects.Services.Projects
{
    public class CreateProject : BaseService
    {
        #region Constants

        const string Sql = @"select @id = newid(); insert into Project ( Id, Name ) values ( @id, @name );";

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="name">The name of the project.</param>
        /// <returns>The database identifier of the newly created project.</returns>
        public Guid Execute(string name)
        {
            using (var connection = GetConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("name", name);
                parameters.Add("id", dbType: DbType.Guid, direction: ParameterDirection.Output);

                connection.Execute(Sql, parameters);

                return parameters.Get<Guid>("id");
            }
        }

        #endregion
    }
}
