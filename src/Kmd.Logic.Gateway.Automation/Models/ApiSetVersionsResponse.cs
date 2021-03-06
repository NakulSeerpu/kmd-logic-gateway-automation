// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Gateway.Automation.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ApiSetVersionsResponse
    {
        /// <summary>
        /// Initializes a new instance of the ApiSetVersionsResponse class.
        /// </summary>
        public ApiSetVersionsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiSetVersionsResponse class.
        /// </summary>
        public ApiSetVersionsResponse(System.Guid? versionSetId = default(System.Guid?), string path = default(string), System.Guid? providerId = default(System.Guid?), IList<ApiVersionResponse> versions = default(IList<ApiVersionResponse>))
        {
            VersionSetId = versionSetId;
            Path = path;
            ProviderId = providerId;
            Versions = versions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionSetId")]
        public System.Guid? VersionSetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "providerId")]
        public System.Guid? ProviderId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        public IList<ApiVersionResponse> Versions { get; set; }

    }
}
