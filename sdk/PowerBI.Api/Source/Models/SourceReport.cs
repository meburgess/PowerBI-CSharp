// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Source from existing report
    /// </summary>
    public partial class SourceReport
    {
        /// <summary>
        /// Initializes a new instance of the SourceReport class.
        /// </summary>
        public SourceReport()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SourceReport class.
        /// </summary>
        /// <param name="sourceReportId">The source report ID</param>
        /// <param name="sourceWorkspaceId">The source workspace ID</param>
        public SourceReport(System.Guid sourceReportId, System.Guid? sourceWorkspaceId = default(System.Guid?))
        {
            SourceReportId = sourceReportId;
            SourceWorkspaceId = sourceWorkspaceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source report ID
        /// </summary>
        [JsonProperty(PropertyName = "sourceReportId")]
        public System.Guid SourceReportId { get; set; }

        /// <summary>
        /// Gets or sets the source workspace ID
        /// </summary>
        [JsonProperty(PropertyName = "sourceWorkspaceId")]
        public System.Guid? SourceWorkspaceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
