// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Power BI Refresh Request
    /// </summary>
    public partial class RefreshRequest
    {
        /// <summary>
        /// Initializes a new instance of the RefreshRequest class.
        /// </summary>
        public RefreshRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RefreshRequest class.
        /// </summary>
        /// <param name="notifyOption">mail notification options. Possible
        /// values include: 'NoNotification', 'MailOnFailure',
        /// 'MailOnCompletion'</param>
        public RefreshRequest(NotifyOption notifyOption)
        {
            NotifyOption = notifyOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets mail notification options. Possible values include:
        /// 'NoNotification', 'MailOnFailure', 'MailOnCompletion'
        /// </summary>
        [JsonProperty(PropertyName = "notifyOption")]
        public NotifyOption NotifyOption { get; set; }

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
