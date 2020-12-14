// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A required workspaces request
    /// </summary>
    public partial class RequiredWorkspaces
    {
        /// <summary>
        /// Initializes a new instance of the RequiredWorkspaces class.
        /// </summary>
        public RequiredWorkspaces()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RequiredWorkspaces class.
        /// </summary>
        /// <param name="workspaces">Required workspace IDs to be scaned. It
        /// should contain 1-100 workspaces.</param>
        public RequiredWorkspaces(IList<System.Guid?> workspaces = default(IList<System.Guid?>))
        {
            Workspaces = workspaces;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets required workspace IDs to be scaned. It should contain
        /// 1-100 workspaces.
        /// </summary>
        [JsonProperty(PropertyName = "workspaces")]
        public IList<System.Guid?> Workspaces { get; set; }

    }
}
