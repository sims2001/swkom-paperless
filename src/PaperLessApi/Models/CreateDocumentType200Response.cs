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

namespace PaperLessApi.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class CreateDocumentType200Response 
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [Required]
        [DataMember(Name="slug", EmitDefaultValue=false)]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Match
        /// </summary>
        [Required]
        [DataMember(Name="match", EmitDefaultValue=false)]
        public string Match { get; set; }

        /// <summary>
        /// Gets or Sets MatchingAlgorithm
        /// </summary>
        [Required]
        [DataMember(Name="matching_algorithm", EmitDefaultValue=true)]
        public int MatchingAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets IsInsensitive
        /// </summary>
        [Required]
        [DataMember(Name="is_insensitive", EmitDefaultValue=true)]
        public bool IsInsensitive { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [Required]
        [DataMember(Name="owner", EmitDefaultValue=true)]
        public int Owner { get; set; }

        /// <summary>
        /// Gets or Sets UserCanChange
        /// </summary>
        [Required]
        [DataMember(Name="user_can_change", EmitDefaultValue=true)]
        public bool UserCanChange { get; set; }

    }
}
