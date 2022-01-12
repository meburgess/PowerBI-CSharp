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
    /// A Power BI deployment pipeline operation
    /// </summary>
    public partial class PipelineOperation
    {
        /// <summary>
        /// Initializes a new instance of the PipelineOperation class.
        /// </summary>
        public PipelineOperation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PipelineOperation class.
        /// </summary>
        /// <param name="id">The operation ID</param>
        /// <param name="status">The pipeline operation status. Possible values
        /// include: 'NotStarted', 'Executing', 'Succeeded', 'Failed'</param>
        /// <param name="lastUpdatedTime">The date and time that the operation
        /// was last updated</param>
        /// <param name="type">The operation type. Possible values include:
        /// 'Deploy'</param>
        /// <param name="executionStartTime">The date and time that the
        /// operation started</param>
        /// <param name="executionEndTime">The date and time that the operation
        /// ended</param>
        /// <param name="sourceStageOrder">The numeric identifier of a source
        /// pipeline deployment stage. Development (0), Test (1), Production
        /// (2).</param>
        /// <param name="targetStageOrder">The numeric identifier of a target
        /// pipeline deployment stage. Development (0), Test (1), Production
        /// (2).</param>
        /// <param name="executionPlan">The deployment execution plan. Only
        /// applicable to a single pipeline operation.</param>
        public PipelineOperation(System.Guid id, PipelineOperationStatus status, System.DateTime lastUpdatedTime, PipelineOperationType? type = default(PipelineOperationType?), System.DateTime? executionStartTime = default(System.DateTime?), System.DateTime? executionEndTime = default(System.DateTime?), int? sourceStageOrder = default(int?), int? targetStageOrder = default(int?), DeploymentExecutionPlan executionPlan = default(DeploymentExecutionPlan))
        {
            Id = id;
            Type = type;
            Status = status;
            LastUpdatedTime = lastUpdatedTime;
            ExecutionStartTime = executionStartTime;
            ExecutionEndTime = executionEndTime;
            SourceStageOrder = sourceStageOrder;
            TargetStageOrder = targetStageOrder;
            ExecutionPlan = executionPlan;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the operation ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the operation type. Possible values include: 'Deploy'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public PipelineOperationType? Type { get; set; }

        /// <summary>
        /// Gets or sets the pipeline operation status. Possible values
        /// include: 'NotStarted', 'Executing', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public PipelineOperationStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the date and time that the operation was last updated
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedTime")]
        public System.DateTime LastUpdatedTime { get; set; }

        /// <summary>
        /// Gets or sets the date and time that the operation started
        /// </summary>
        [JsonProperty(PropertyName = "executionStartTime")]
        public System.DateTime? ExecutionStartTime { get; set; }

        /// <summary>
        /// Gets or sets the date and time that the operation ended
        /// </summary>
        [JsonProperty(PropertyName = "executionEndTime")]
        public System.DateTime? ExecutionEndTime { get; set; }

        /// <summary>
        /// Gets or sets the numeric identifier of a source pipeline deployment
        /// stage. Development (0), Test (1), Production (2).
        /// </summary>
        [JsonProperty(PropertyName = "sourceStageOrder")]
        public int? SourceStageOrder { get; set; }

        /// <summary>
        /// Gets or sets the numeric identifier of a target pipeline deployment
        /// stage. Development (0), Test (1), Production (2).
        /// </summary>
        [JsonProperty(PropertyName = "targetStageOrder")]
        public int? TargetStageOrder { get; set; }

        /// <summary>
        /// Gets or sets the deployment execution plan. Only applicable to a
        /// single pipeline operation.
        /// </summary>
        [JsonProperty(PropertyName = "executionPlan")]
        public DeploymentExecutionPlan ExecutionPlan { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}