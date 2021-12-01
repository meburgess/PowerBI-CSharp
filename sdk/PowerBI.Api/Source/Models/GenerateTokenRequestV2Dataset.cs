// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A dataset object in [GenerateTokenRequestV2](#generatetokenrequestv2)
    /// </summary>
    public partial class GenerateTokenRequestV2Dataset
    {
        /// <summary>
        /// Initializes a new instance of the GenerateTokenRequestV2Dataset
        /// class.
        /// </summary>
        public GenerateTokenRequestV2Dataset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GenerateTokenRequestV2Dataset
        /// class.
        /// </summary>
        /// <param name="id">The dataset ID</param>
        public GenerateTokenRequestV2Dataset(string id)
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the dataset ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
