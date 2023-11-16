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
    public partial class SelectionData200Response 
    {
        /// <summary>
        /// Gets or Sets SelectedCorrespondents
        /// </summary>
        [Required]
        [DataMember(Name="selected_correspondents", EmitDefaultValue=false)]
        public List<SelectionData200ResponseSelectedCorrespondentsInner> SelectedCorrespondents { get; set; }

        /// <summary>
        /// Gets or Sets SelectedTags
        /// </summary>
        [Required]
        [DataMember(Name="selected_tags", EmitDefaultValue=false)]
        public List<SelectionData200ResponseSelectedCorrespondentsInner> SelectedTags { get; set; }

        /// <summary>
        /// Gets or Sets SelectedDocumentTypes
        /// </summary>
        [Required]
        [DataMember(Name="selected_document_types", EmitDefaultValue=false)]
        public List<SelectionData200ResponseSelectedCorrespondentsInner> SelectedDocumentTypes { get; set; }

        /// <summary>
        /// Gets or Sets SelectedStoragePaths
        /// </summary>
        [Required]
        [DataMember(Name="selected_storage_paths", EmitDefaultValue=false)]
        public List<SelectionData200ResponseSelectedCorrespondentsInner> SelectedStoragePaths { get; set; }

    }
}