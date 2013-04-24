using System;
using System.Collections.Generic;

namespace Projects.Services.Projects
{
    public static class Helper
    {
        #region Public Methods

        /// <summary>
        /// Finds projects with the given name.
        /// </summary>
        /// <param name="name">The name to query projects on.</param>
        /// <returns>The projects with the given name if found.</returns>
        public static IEnumerable<Models.Project> FindProjectsByName(string name)
        {
            var service = new FindProjectsByName();

            return service.Execute(name);
        }

        /// <summary>
        /// Finds a project with the given identifier.
        /// </summary>
        /// <param name="id">The database identifier of the project to find.</param>
        /// <returns>The project with the given database identifier if found; otherwise <c>null</c>.</returns>
        public static Models.Project GetProjectById(Guid id) 
        {
            var service = new GetProjectById();

            return service.Execute(id);
        }

        #endregion
    }
}
