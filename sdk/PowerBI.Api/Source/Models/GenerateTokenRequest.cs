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
    /// Power BI Generate Token Request
    /// </summary>
    public partial class GenerateTokenRequest
    {
        /// <summary>
        /// Initializes a new instance of the GenerateTokenRequest class.
        /// </summary>
        public GenerateTokenRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GenerateTokenRequest class.
        /// </summary>
        /// <param name="accessLevel">The required access level for embed token
        /// generation. Possible values include: 'View', 'Edit',
        /// 'Create'</param>
        /// <param name="datasetId">The dataset ID used for report creation.
        /// Only applies when you generate an embed token for report
        /// creation.</param>
        /// <param name="allowSaveAs">Whether an embedded report can be saved
        /// as a new report. The default value is `false`. Only applies when
        /// you generate an embed token for report embedding.</param>
        /// <param name="identities">A list of identities to use for row-level
        /// security rules</param>
        /// <param name="lifetimeInMinutes">The maximum lifetime of the token
        /// in minutes, starting from the time it was generated. Can be used to
        /// shorten the expiration time of a token, but not to extend it. The
        /// value must be a positive integer. Zero (0) is equivalent to null
        /// and will be ignored, resulting in the default expiration
        /// time.</param>
        public GenerateTokenRequest(TokenAccessLevel? accessLevel = default(TokenAccessLevel?), string datasetId = default(string), bool? allowSaveAs = default(bool?), IList<EffectiveIdentity> identities = default(IList<EffectiveIdentity>), int? lifetimeInMinutes = default(int?))
        {
            AccessLevel = accessLevel;
            DatasetId = datasetId;
            AllowSaveAs = allowSaveAs;
            Identities = identities;
            LifetimeInMinutes = lifetimeInMinutes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the required access level for embed token generation.
        /// Possible values include: 'View', 'Edit', 'Create'
        /// </summary>
        [JsonProperty(PropertyName = "accessLevel")]
        public TokenAccessLevel? AccessLevel { get; set; }

        /// <summary>
        /// Gets or sets the dataset ID used for report creation. Only applies
        /// when you generate an embed token for report creation.
        /// </summary>
        [JsonProperty(PropertyName = "datasetId")]
        public string DatasetId { get; set; }

        /// <summary>
        /// Gets or sets whether an embedded report can be saved as a new
        /// report. The default value is `false`. Only applies when you
        /// generate an embed token for report embedding.
        /// </summary>
        [JsonProperty(PropertyName = "allowSaveAs")]
        public bool? AllowSaveAs { get; set; }

        /// <summary>
        /// Gets or sets a list of identities to use for row-level security
        /// rules
        /// </summary>
        [JsonProperty(PropertyName = "identities")]
        public IList<EffectiveIdentity> Identities { get; set; }

        /// <summary>
        /// Gets or sets the maximum lifetime of the token in minutes, starting
        /// from the time it was generated. Can be used to shorten the
        /// expiration time of a token, but not to extend it. The value must be
        /// a positive integer. Zero (0) is equivalent to null and will be
        /// ignored, resulting in the default expiration time.
        /// </summary>
        [JsonProperty(PropertyName = "lifetimeInMinutes")]
        public int? LifetimeInMinutes { get; set; }

    }
}
