// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The metadata of a dataflow. Below is a list of properties that may be
    /// returned for a dataflow. Only a subset of the properties will be
    /// returned depending on the API called, the caller permissions and the
    /// availability of the data in the Power BI database.
    /// </summary>
    public partial class Dataflow : DataflowBaseProperties
    {
        /// <summary>
        /// Initializes a new instance of the Dataflow class.
        /// </summary>
        public Dataflow()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Dataflow class.
        /// </summary>
        /// <param name="objectId">The dataflow ID</param>
        /// <param name="name">The dataflow name</param>
        /// <param name="description">The dataflow description</param>
        /// <param name="modelUrl">A URL to the dataflow definition file
        /// (model.json)</param>
        /// <param name="configuredBy">The dataflow owner</param>
        /// <param name="modifiedBy">The user that modified this
        /// dataflow</param>
        /// <param name="modifiedDateTime">modification date time</param>
        /// <param name="users">The Dataflow User Access Details. This value
        /// will be empty. It will be removed from the payload response in an
        /// upcoming release. To retrieve user information on an artifact,
        /// please consider using the Get Dataflow User as Admin APIs, or the
        /// PostWorkspaceInfo API with the getArtifactUser parameter.</param>
        public Dataflow(System.Guid objectId, string name = default(string), string description = default(string), string modelUrl = default(string), string configuredBy = default(string), string modifiedBy = default(string), System.DateTime? modifiedDateTime = default(System.DateTime?), IList<DataflowUser> users = default(IList<DataflowUser>))
            : base(objectId, name, description, modelUrl, configuredBy, modifiedBy, modifiedDateTime, users)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
