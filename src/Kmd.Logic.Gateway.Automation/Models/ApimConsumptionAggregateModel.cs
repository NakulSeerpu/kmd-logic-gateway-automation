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

    public partial class ApimConsumptionAggregateModel
    {
        /// <summary>
        /// Initializes a new instance of the ApimConsumptionAggregateModel
        /// class.
        /// </summary>
        public ApimConsumptionAggregateModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApimConsumptionAggregateModel
        /// class.
        /// </summary>
        public ApimConsumptionAggregateModel(System.DateTime? dateFrom = default(System.DateTime?), System.DateTime? dateTo = default(System.DateTime?), string intervalType = default(string), long? callCount = default(long?), long? bandwidth = default(long?), double? apiTimeAvg = default(double?), double? serviceTimeAvg = default(double?), IList<ApimConsumptionAggregateItemModel> aggregateDetails = default(IList<ApimConsumptionAggregateItemModel>))
        {
            DateFrom = dateFrom;
            DateTo = dateTo;
            IntervalType = intervalType;
            CallCount = callCount;
            Bandwidth = bandwidth;
            ApiTimeAvg = apiTimeAvg;
            ServiceTimeAvg = serviceTimeAvg;
            AggregateDetails = aggregateDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateFrom")]
        public System.DateTime? DateFrom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateTo")]
        public System.DateTime? DateTo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "intervalType")]
        public string IntervalType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "callCount")]
        public long? CallCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bandwidth")]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "apiTimeAvg")]
        public double? ApiTimeAvg { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceTimeAvg")]
        public double? ServiceTimeAvg { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "aggregateDetails")]
        public IList<ApimConsumptionAggregateItemModel> AggregateDetails { get; set; }

    }
}
