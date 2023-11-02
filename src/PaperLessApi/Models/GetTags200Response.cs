/*
 * Paperless Rest Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PaperLessApi.Converters;

namespace PaperLessApi.DTOs
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class GetTags200Response 
    {
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [Required]
        [DataMember(Name="count", EmitDefaultValue=true)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [Required]
        [DataMember(Name="next", EmitDefaultValue=true)]
        public int Next { get; set; }

        /// <summary>
        /// Gets or Sets Previous
        /// </summary>
        [Required]
        [DataMember(Name="previous", EmitDefaultValue=true)]
        public int Previous { get; set; }

        /// <summary>
        /// Gets or Sets All
        /// </summary>
        [Required]
        [DataMember(Name="all", EmitDefaultValue=false)]
        public List<int> All { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [Required]
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<GetTags200ResponseResultsInner> Results { get; set; }

    }
}
