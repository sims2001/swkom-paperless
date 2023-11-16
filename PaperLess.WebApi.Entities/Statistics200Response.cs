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
    public partial class Statistics200Response 
    {
        /// <summary>
        /// Gets or Sets DocumentsTotal
        /// </summary>
        [Required]
        [DataMember(Name="documents_total", EmitDefaultValue=true)]
        public int DocumentsTotal { get; set; }

        /// <summary>
        /// Gets or Sets DocumentsInbox
        /// </summary>
        [Required]
        [DataMember(Name="documents_inbox", EmitDefaultValue=true)]
        public int DocumentsInbox { get; set; }

        /// <summary>
        /// Gets or Sets InboxTag
        /// </summary>
        [Required]
        [DataMember(Name="inbox_tag", EmitDefaultValue=true)]
        public int InboxTag { get; set; }

        /// <summary>
        /// Gets or Sets DocumentFileTypeCounts
        /// </summary>
        [Required]
        [DataMember(Name="document_file_type_counts", EmitDefaultValue=false)]
        public List<Statistics200ResponseDocumentFileTypeCountsInner> DocumentFileTypeCounts { get; set; }

        /// <summary>
        /// Gets or Sets CharacterCount
        /// </summary>
        [Required]
        [DataMember(Name="character_count", EmitDefaultValue=true)]
        public int CharacterCount { get; set; }

    }
}