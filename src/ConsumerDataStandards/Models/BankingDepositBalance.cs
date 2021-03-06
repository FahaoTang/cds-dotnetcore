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
    public partial class BankingDepositBalance : IEquatable<BankingDepositBalance>
    { 
        /// <summary>
        /// Gets or Sets CurrentBalance
        /// </summary>
        [Required]
        [DataMember(Name="currentBalance")]
        public CommonCurrencyAmount CurrentBalance { get; set; }

        /// <summary>
        /// Gets or Sets AvailableBalance
        /// </summary>
        [Required]
        [DataMember(Name="availableBalance")]
        public CommonCurrencyAmount AvailableBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankingDepositBalance {\n");
            sb.Append("  CurrentBalance: ").Append(CurrentBalance).Append("\n");
            sb.Append("  AvailableBalance: ").Append(AvailableBalance).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BankingDepositBalance)obj);
        }

        /// <summary>
        /// Returns true if BankingDepositBalance instances are equal
        /// </summary>
        /// <param name="other">Instance of BankingDepositBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankingDepositBalance other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CurrentBalance == other.CurrentBalance ||
                    CurrentBalance != null &&
                    CurrentBalance.Equals(other.CurrentBalance)
                ) && 
                (
                    AvailableBalance == other.AvailableBalance ||
                    AvailableBalance != null &&
                    AvailableBalance.Equals(other.AvailableBalance)
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
                    if (CurrentBalance != null)
                    hashCode = hashCode * 59 + CurrentBalance.GetHashCode();
                    if (AvailableBalance != null)
                    hashCode = hashCode * 59 + AvailableBalance.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BankingDepositBalance left, BankingDepositBalance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BankingDepositBalance left, BankingDepositBalance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
