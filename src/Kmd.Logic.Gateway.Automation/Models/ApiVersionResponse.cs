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

    public partial class ApiVersionResponse
    {
        /// <summary>
        /// Initializes a new instance of the ApiVersionResponse class.
        /// </summary>
        public ApiVersionResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiVersionResponse class.
        /// </summary>
        /// <param name="visibility">Possible values include: 'Public',
        /// 'Private'</param>
        /// <param name="synchronization">Possible values include: 'Pending',
        /// 'Active', 'Faulted'</param>
        /// <param name="status">Possible values include: 'Preview', 'Active',
        /// 'Deprecated'</param>
        public ApiVersionResponse(System.Guid? apiId = default(System.Guid?), string apiVersion = default(string), string name = default(string), string backendServiceUrl = default(string), string publicUrl = default(string), string logoUrl = default(string), string documentationUrl = default(string), IList<System.Guid?> productIds = default(IList<System.Guid?>), string visibility = default(string), string synchronization = default(string), string status = default(string), bool? isCurrent = default(bool?))
        {
            ApiId = apiId;
            ApiVersion = apiVersion;
            Name = name;
            BackendServiceUrl = backendServiceUrl;
            PublicUrl = publicUrl;
            LogoUrl = logoUrl;
            DocumentationUrl = documentationUrl;
            ProductIds = productIds;
            Visibility = visibility;
            Synchronization = synchronization;
            Status = status;
            IsCurrent = isCurrent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "apiId")]
        public System.Guid? ApiId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "backendServiceUrl")]
        public string BackendServiceUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publicUrl")]
        public string PublicUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "logoUrl")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentationUrl")]
        public string DocumentationUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productIds")]
        public IList<System.Guid?> ProductIds { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Public', 'Private'
        /// </summary>
        [JsonProperty(PropertyName = "visibility")]
        public string Visibility { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Pending', 'Active',
        /// 'Faulted'
        /// </summary>
        [JsonProperty(PropertyName = "synchronization")]
        public string Synchronization { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Preview', 'Active',
        /// 'Deprecated'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isCurrent")]
        public bool? IsCurrent { get; set; }

    }
}
