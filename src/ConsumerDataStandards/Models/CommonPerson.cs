/*
 * Consumer Data Standards
 *
 * API sets created by the Australian Consumer Data Standards to meet the needs of the Consumer Data Right
 *
 * OpenAPI spec version: 1
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

namespace ConsumerDataStandards.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class CommonPerson : IEquatable<CommonPerson>
    { 
        /// <summary>
        /// The date and time that this record was last updated by the customer.  If no update has occurred then this date should reflect the initial creation date for the data
        /// </summary>
        /// <value>The date and time that this record was last updated by the customer.  If no update has occurred then this date should reflect the initial creation date for the data</value>
        [Required]
        [DataMember(Name="lastUpdateTime")]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// For people with single names this field need not be present.  The single name should be in the lastName field
        /// </summary>
        /// <value>For people with single names this field need not be present.  The single name should be in the lastName field</value>
        [DataMember(Name="firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// For people with single names the single name should be in this field
        /// </summary>
        /// <value>For people with single names the single name should be in this field</value>
        [Required]
        [DataMember(Name="lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Field is mandatory but array may be empty
        /// </summary>
        /// <value>Field is mandatory but array may be empty</value>
        [Required]
        [DataMember(Name="middleNames")]
        public List<string> MiddleNames { get; set; }

        /// <summary>
        /// Also known as title or salutation.  The prefix to the name (e.g. Mr, Mrs, Ms, Miss, Sir, etc)
        /// </summary>
        /// <value>Also known as title or salutation.  The prefix to the name (e.g. Mr, Mrs, Ms, Miss, Sir, etc)</value>
        [DataMember(Name="prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// Used for a trailing suffix to the name (e.g. Jr)
        /// </summary>
        /// <value>Used for a trailing suffix to the name (e.g. Jr)</value>
        [DataMember(Name="suffix")]
        public string Suffix { get; set; }

        /// <summary>
        /// Value is a valid [ANZCO v1.2](http://www.abs.gov.au/ANZSCO) Standard Occupation classification.
        /// </summary>
        /// <value>Value is a valid [ANZCO v1.2](http://www.abs.gov.au/ANZSCO) Standard Occupation classification.</value>
        [DataMember(Name="occupationCode")]
        public string OccupationCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonPerson {\n");
            sb.Append("  LastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  MiddleNames: ").Append(MiddleNames).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  OccupationCode: ").Append(OccupationCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((CommonPerson)obj);
        }

        /// <summary>
        /// Returns true if CommonPerson instances are equal
        /// </summary>
        /// <param name="other">Instance of CommonPerson to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonPerson other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LastUpdateTime == other.LastUpdateTime ||
                    LastUpdateTime != null &&
                    LastUpdateTime.Equals(other.LastUpdateTime)
                ) && 
                (
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    LastName == other.LastName ||
                    LastName != null &&
                    LastName.Equals(other.LastName)
                ) && 
                (
                    MiddleNames == other.MiddleNames ||
                    MiddleNames != null &&
                    MiddleNames.SequenceEqual(other.MiddleNames)
                ) && 
                (
                    Prefix == other.Prefix ||
                    Prefix != null &&
                    Prefix.Equals(other.Prefix)
                ) && 
                (
                    Suffix == other.Suffix ||
                    Suffix != null &&
                    Suffix.Equals(other.Suffix)
                ) && 
                (
                    OccupationCode == other.OccupationCode ||
                    OccupationCode != null &&
                    OccupationCode.Equals(other.OccupationCode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (LastUpdateTime != null)
                    hashCode = hashCode * 59 + LastUpdateTime.GetHashCode();
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    if (LastName != null)
                    hashCode = hashCode * 59 + LastName.GetHashCode();
                    if (MiddleNames != null)
                    hashCode = hashCode * 59 + MiddleNames.GetHashCode();
                    if (Prefix != null)
                    hashCode = hashCode * 59 + Prefix.GetHashCode();
                    if (Suffix != null)
                    hashCode = hashCode * 59 + Suffix.GetHashCode();
                    if (OccupationCode != null)
                    hashCode = hashCode * 59 + OccupationCode.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CommonPerson left, CommonPerson right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CommonPerson left, CommonPerson right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
