/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// V2paymentsProcessingInformationAuthorizationOptionsInitiatorMerchantInitiatedTransaction
    /// </summary>
    [DataContract]
    public partial class V2paymentsProcessingInformationAuthorizationOptionsInitiatorMerchantInitiatedTransaction :  IEquatable<V2paymentsProcessingInformationAuthorizationOptionsInitiatorMerchantInitiatedTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2paymentsProcessingInformationAuthorizationOptionsInitiatorMerchantInitiatedTransaction" /> class.
        /// </summary>
        /// <param name="Reason">Reason for the merchant-initiated transaction. Possible values:   - **1**: Resubmission  - **2**: Delayed charge  - **3**: Reauthorization for split shipment  - **4**: No show  - **5**: Account top up  This field is not required for installment payments or recurring payments or when _reAuth.first_ is true. It is required for all other merchant-initiated transactions. This field is supported only for Visa transactions on CyberSource through VisaNet. .</param>
        /// <param name="PreviousTransactionId">Transaction identifier that was returned in the payment response field _processorInformation.transactionID_ in the reply message for either the original merchant initiated payment in the series or the previous merchant-initiated payment in the series. &lt;p/&gt; If the current payment request includes a token instead of an account number, the following time limits apply for the value of this field:  For a **resubmission**, the transaction ID must be less than 14 days old.  For a **delayed charge** or **reauthorization**, the transaction ID must be less than 30 days old.  The value for this field does not correspond to any data in the TC 33 capture file. This field is supported only for Visa transactions on CyberSource through VisaNet. .</param>
        public V2paymentsProcessingInformationAuthorizationOptionsInitiatorMerchantInitiatedTransaction(string Reason = default(string), string PreviousTransactionId = default(string))
        {
            this.Reason = Reason;
            this.PreviousTransactionId = PreviousTransactionId;
        }
        
        /// <summary>
        /// Reason for the merchant-initiated transaction. Possible values:   - **1**: Resubmission  - **2**: Delayed charge  - **3**: Reauthorization for split shipment  - **4**: No show  - **5**: Account top up  This field is not required for installment payments or recurring payments or when _reAuth.first_ is true. It is required for all other merchant-initiated transactions. This field is supported only for Visa transactions on CyberSource through VisaNet. 
        /// </summary>
        /// <value>Reason for the merchant-initiated transaction. Possible values:   - **1**: Resubmission  - **2**: Delayed charge  - **3**: Reauthorization for split shipment  - **4**: No show  - **5**: Account top up  This field is not required for installment payments or recurring payments or when _reAuth.first_ is true. It is required for all other merchant-initiated transactions. This field is supported only for Visa transactions on CyberSource through VisaNet. </value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Transaction identifier that was returned in the payment response field _processorInformation.transactionID_ in the reply message for either the original merchant initiated payment in the series or the previous merchant-initiated payment in the series. &lt;p/&gt; If the current payment request includes a token instead of an account number, the following time limits apply for the value of this field:  For a **resubmission**, the transaction ID must be less than 14 days old.  For a **delayed charge** or **reauthorization**, the transaction ID must be less than 30 days old.  The value for this field does not correspond to any data in the TC 33 capture file. This field is supported only for Visa transactions on CyberSource through VisaNet. 
        /// </summary>
        /// <value>Transaction identifier that was returned in the payment response field _processorInformation.transactionID_ in the reply message for either the original merchant initiated payment in the series or the previous merchant-initiated payment in the series. &lt;p/&gt; If the current payment request includes a token instead of an account number, the following time limits apply for the value of this field:  For a **resubmission**, the transaction ID must be less than 14 days old.  For a **delayed charge** or **reauthorization**, the transaction ID must be less than 30 days old.  The value for this field does not correspond to any data in the TC 33 capture file. This field is supported only for Visa transactions on CyberSource through VisaNet. </value>
        [DataMember(Name="previousTransactionId", EmitDefaultValue=false)]
        public string PreviousTransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2paymentsProcessingInformationAuthorizationOptionsInitiatorMerchantInitiatedTransaction {\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  PreviousTransactionId: ").Append(PreviousTransactionId).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V2paymentsProcessingInformationAuthorizationOptionsInitiatorMerchantInitiatedTransaction);
        }

        /// <summary>
        /// Returns true if V2paymentsProcessingInformationAuthorizationOptionsInitiatorMerchantInitiatedTransaction instances are equal
        /// </summary>
        /// <param name="other">Instance of V2paymentsProcessingInformationAuthorizationOptionsInitiatorMerchantInitiatedTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2paymentsProcessingInformationAuthorizationOptionsInitiatorMerchantInitiatedTransaction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.PreviousTransactionId == other.PreviousTransactionId ||
                    this.PreviousTransactionId != null &&
                    this.PreviousTransactionId.Equals(other.PreviousTransactionId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.PreviousTransactionId != null)
                    hash = hash * 59 + this.PreviousTransactionId.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Reason (string) maxLength
            if(this.Reason != null && this.Reason.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reason, length must be less than 1.", new [] { "Reason" });
            }

            // PreviousTransactionId (string) maxLength
            if(this.PreviousTransactionId != null && this.PreviousTransactionId.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PreviousTransactionId, length must be less than 15.", new [] { "PreviousTransactionId" });
            }

            yield break;
        }
    }

}