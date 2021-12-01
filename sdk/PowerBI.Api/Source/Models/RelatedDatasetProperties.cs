// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RelatedDatasetProperties
    {
        /// <summary>
        /// Initializes a new instance of the RelatedDatasetProperties class.
        /// </summary>
        public RelatedDatasetProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RelatedDatasetProperties class.
        /// </summary>
        /// <param name="datasetWorkspaceId">The workspace ID of the related
        /// dataset, returned only if the related dataset belongs to a
        /// different workspace</param>
        public RelatedDatasetProperties(System.Guid? datasetWorkspaceId = default(System.Guid?))
        {
            DatasetWorkspaceId = datasetWorkspaceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the workspace ID of the related dataset, returned only
        /// if the related dataset belongs to a different workspace
        /// </summary>
        [JsonProperty(PropertyName = "datasetWorkspaceId")]
        public System.Guid? DatasetWorkspaceId { get; set; }

    }
}
