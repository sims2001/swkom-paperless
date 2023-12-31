using Microsoft.AspNetCore.Http;

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PaperLess.WebApi.Entities.Converters;

namespace PaperLess.WebApi.Entities
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class CreateUISettingsRequestSettingsNotifications 
    {
        /// <summary>
        /// Gets or Sets ConsumerNewDocuments
        /// </summary>
        [Required]
        [DataMember(Name="consumer_new_documents", EmitDefaultValue=true)]
        public bool ConsumerNewDocuments { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerSuccess
        /// </summary>
        [Required]
        [DataMember(Name="consumer_success", EmitDefaultValue=true)]
        public bool ConsumerSuccess { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerFailed
        /// </summary>
        [Required]
        [DataMember(Name="consumer_failed", EmitDefaultValue=true)]
        public bool ConsumerFailed { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerSuppressOnDashboard
        /// </summary>
        [Required]
        [DataMember(Name="consumer_suppress_on_dashboard", EmitDefaultValue=true)]
        public bool ConsumerSuppressOnDashboard { get; set; }

    }
}
