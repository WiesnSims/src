/*
 * Parcel Logistics Service
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.20.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KW.PostLogistics.Services.DTOs
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Truck : Hop
    { 
        /// <summary>
        /// GeoJSON of the are covered by the truck.
        /// </summary>
        /// <value>GeoJSON of the are covered by the truck.</value>
        [Required]
        [DataMember(Name="regionGeoJson")]
        public string RegionGeoJson { get; set; }

        /// <summary>
        /// The truck&#x27;s number plate.
        /// </summary>
        /// <value>The truck&#x27;s number plate.</value>
        [Required]
        [DataMember(Name="numberPlate")]
        public string NumberPlate { get; set; }
    }
}