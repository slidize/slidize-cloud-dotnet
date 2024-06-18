/*
 <copyright company="Smallize Pty Ltd">
   Copyright (c) 2024 Slidize for Cloud
 </copyright>
 <summary>
  Permission is hereby granted, free of charge, to any person obtaining a copy
  of this software and associated documentation files (the "Software"), to deal
  in the Software without restriction, including without limitation the rights
  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
  copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:
 
  The above copyright notice and this permission notice shall be included in all
  copies or substantial portions of the Software.
 
  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
  SOFTWARE.
*/


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Slidize.Cloud.Sdk.Client.OpenAPIDateConverter;

namespace Slidize.Cloud.Sdk.Model
{
    /// <summary>
    /// VideoOptions
    /// </summary>
    [DataContract(Name = "VideoOptions")]
    public partial class VideoOptions : IEquatable<VideoOptions>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TransitionType
        /// </summary>
        [DataMember(Name = "transitionType", EmitDefaultValue = false)]
        public VideoTransitionType? TransitionType { get; set; }

        /// <summary>
        /// Gets or Sets ResolutionType
        /// </summary>
        [DataMember(Name = "resolutionType", EmitDefaultValue = false)]
        public VideoResolutionType? ResolutionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoOptions" /> class.
        /// </summary>
        /// <param name="duration">duration.</param>
        /// <param name="transition">transition.</param>
        /// <param name="transitionType">transitionType.</param>
        /// <param name="resolutionType">resolutionType.</param>
        public VideoOptions(int? duration = default(int?), int? transition = default(int?), VideoTransitionType? transitionType = default(VideoTransitionType?), VideoResolutionType? resolutionType = default(VideoResolutionType?))
        {
            this.Duration = duration;
            this.Transition = transition;
            this.TransitionType = transitionType;
            this.ResolutionType = resolutionType;
        }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public int? Duration { get; set; }

        /// <summary>
        /// Gets or Sets Transition
        /// </summary>
        [DataMember(Name = "transition", EmitDefaultValue = true)]
        public int? Transition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VideoOptions {\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Transition: ").Append(Transition).Append("\n");
            sb.Append("  TransitionType: ").Append(TransitionType).Append("\n");
            sb.Append("  ResolutionType: ").Append(ResolutionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoOptions);
        }

        /// <summary>
        /// Returns true if VideoOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of VideoOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.Transition == input.Transition ||
                    (this.Transition != null &&
                    this.Transition.Equals(input.Transition))
                ) && 
                (
                    this.TransitionType == input.TransitionType ||
                    this.TransitionType.Equals(input.TransitionType)
                ) && 
                (
                    this.ResolutionType == input.ResolutionType ||
                    this.ResolutionType.Equals(input.ResolutionType)
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
                int hashCode = 41;
                if (this.Duration != null)
                {
                    hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                }
                if (this.Transition != null)
                {
                    hashCode = (hashCode * 59) + this.Transition.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TransitionType.GetHashCode();
                hashCode = (hashCode * 59) + this.ResolutionType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
