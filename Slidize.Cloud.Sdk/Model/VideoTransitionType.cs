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
    /// Defines VideoTransitionType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VideoTransitionType
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum Random for value: Random
        /// </summary>
        [EnumMember(Value = "Random")]
        Random = 2,

        /// <summary>
        /// Enum FromPresentation for value: FromPresentation
        /// </summary>
        [EnumMember(Value = "FromPresentation")]
        FromPresentation = 3,

        /// <summary>
        /// Enum Fade for value: Fade
        /// </summary>
        [EnumMember(Value = "Fade")]
        Fade = 4,

        /// <summary>
        /// Enum Distance for value: Distance
        /// </summary>
        [EnumMember(Value = "Distance")]
        Distance = 5,

        /// <summary>
        /// Enum SlideLeft for value: SlideLeft
        /// </summary>
        [EnumMember(Value = "SlideLeft")]
        SlideLeft = 6,

        /// <summary>
        /// Enum CircleCrop for value: CircleCrop
        /// </summary>
        [EnumMember(Value = "CircleCrop")]
        CircleCrop = 7,

        /// <summary>
        /// Enum Dissolve for value: Dissolve
        /// </summary>
        [EnumMember(Value = "Dissolve")]
        Dissolve = 8

    }

}
