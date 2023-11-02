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
    public partial class CreateUISettingsRequestSettingsSavedViews 
    {
        /// <summary>
        /// Gets or Sets WarnOnUnsavedChange
        /// </summary>
        [Required]
        [DataMember(Name="warn_on_unsaved_change", EmitDefaultValue=true)]
        public bool WarnOnUnsavedChange { get; set; }

    }
}
