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
    public partial class ResponseBankingDirectDebitAuthorisationListData : IEquatable<ResponseBankingDirectDebitAuthorisationListData>
    { 
        /// <summary>
        /// The list of authorisations returned
        /// </summary>
        /// <value>The list of authorisations returned</value>
        [Required]
        [DataMember(Name="directDebitAuthorisations")]
        public List<BankingDirectDebit> DirectDebitAuthorisations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseBankingDirectDebitAuthorisationListData {\n");
            sb.Append("  DirectDebitAuthorisations: ").Append(DirectDebitAuthorisations).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ResponseBankingDirectDebitAuthorisationListData)obj);
        }

        /// <summary>
        /// Returns true if ResponseBankingDirectDebitAuthorisationListData instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseBankingDirectDebitAuthorisationListData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseBankingDirectDebitAuthorisationListData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DirectDebitAuthorisations == other.DirectDebitAuthorisations ||
                    DirectDebitAuthorisations != null &&
                    DirectDebitAuthorisations.SequenceEqual(other.DirectDebitAuthorisations)
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
                    if (DirectDebitAuthorisations != null)
                    hashCode = hashCode * 59 + DirectDebitAuthorisations.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ResponseBankingDirectDebitAuthorisationListData left, ResponseBankingDirectDebitAuthorisationListData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ResponseBankingDirectDebitAuthorisationListData left, ResponseBankingDirectDebitAuthorisationListData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
