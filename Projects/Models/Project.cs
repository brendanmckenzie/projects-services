using System;

namespace Projects.Models
{
    /// <summary>
    /// Identifies a project.
    /// </summary>
    public class Project
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        #endregion
    }
}
