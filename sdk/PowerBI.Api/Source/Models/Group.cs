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
    /// A Power BI group
    /// </summary>
    public partial class Group
    {
        /// <summary>
        /// Initializes a new instance of the Group class.
        /// </summary>
        public Group()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Group class.
        /// </summary>
        /// <param name="id">The workspace ID</param>
        /// <param name="name">The group name</param>
        /// <param name="isReadOnly">Whether the group is read-only</param>
        /// <param name="isOnDedicatedCapacity">Whether the group is assigned
        /// to a dedicated capacity</param>
        /// <param name="capacityId">The capacity ID</param>
        /// <param name="dataflowStorageId">The Power BI dataflow storage
        /// account ID</param>
        /// <param name="logAnalyticsWorkspace">The Log Analytics workspace
        /// assigned to the group.  This is returned only when retrieving a
        /// single group.</param>
        public Group(System.Guid id, string name = default(string), bool? isReadOnly = default(bool?), bool? isOnDedicatedCapacity = default(bool?), System.Guid? capacityId = default(System.Guid?), System.Guid? dataflowStorageId = default(System.Guid?), AzureResource logAnalyticsWorkspace = default(AzureResource))
        {
            Id = id;
            Name = name;
            IsReadOnly = isReadOnly;
            IsOnDedicatedCapacity = isOnDedicatedCapacity;
            CapacityId = capacityId;
            DataflowStorageId = dataflowStorageId;
            LogAnalyticsWorkspace = logAnalyticsWorkspace;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the workspace ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the group name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets whether the group is read-only
        /// </summary>
        [JsonProperty(PropertyName = "isReadOnly")]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Gets or sets whether the group is assigned to a dedicated capacity
        /// </summary>
        [JsonProperty(PropertyName = "isOnDedicatedCapacity")]
        public bool? IsOnDedicatedCapacity { get; set; }

        /// <summary>
        /// Gets or sets the capacity ID
        /// </summary>
        [JsonProperty(PropertyName = "capacityId")]
        public System.Guid? CapacityId { get; set; }

        /// <summary>
        /// Gets or sets the Power BI dataflow storage account ID
        /// </summary>
        [JsonProperty(PropertyName = "dataflowStorageId")]
        public System.Guid? DataflowStorageId { get; set; }

        /// <summary>
        /// Gets or sets the Log Analytics workspace assigned to the group.
        /// This is returned only when retrieving a single group.
        /// </summary>
        [JsonProperty(PropertyName = "logAnalyticsWorkspace")]
        public AzureResource LogAnalyticsWorkspace { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LogAnalyticsWorkspace != null)
            {
                LogAnalyticsWorkspace.Validate();
            }
        }
    }
}
