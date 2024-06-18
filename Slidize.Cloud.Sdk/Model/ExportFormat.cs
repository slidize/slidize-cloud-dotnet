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
    /// Defines ExportFormat
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExportFormat
    {
        /// <summary>
        /// Enum Odp for value: Odp
        /// </summary>
        [EnumMember(Value = "Odp")]
        Odp = 1,

        /// <summary>
        /// Enum Otp for value: Otp
        /// </summary>
        [EnumMember(Value = "Otp")]
        Otp = 2,

        /// <summary>
        /// Enum Pptx for value: Pptx
        /// </summary>
        [EnumMember(Value = "Pptx")]
        Pptx = 3,

        /// <summary>
        /// Enum Pptm for value: Pptm
        /// </summary>
        [EnumMember(Value = "Pptm")]
        Pptm = 4,

        /// <summary>
        /// Enum Potx for value: Potx
        /// </summary>
        [EnumMember(Value = "Potx")]
        Potx = 5,

        /// <summary>
        /// Enum Ppt for value: Ppt
        /// </summary>
        [EnumMember(Value = "Ppt")]
        Ppt = 6,

        /// <summary>
        /// Enum Pps for value: Pps
        /// </summary>
        [EnumMember(Value = "Pps")]
        Pps = 7,

        /// <summary>
        /// Enum Ppsm for value: Ppsm
        /// </summary>
        [EnumMember(Value = "Ppsm")]
        Ppsm = 8,

        /// <summary>
        /// Enum Pot for value: Pot
        /// </summary>
        [EnumMember(Value = "Pot")]
        Pot = 9,

        /// <summary>
        /// Enum Potm for value: Potm
        /// </summary>
        [EnumMember(Value = "Potm")]
        Potm = 10,

        /// <summary>
        /// Enum Pdf for value: Pdf
        /// </summary>
        [EnumMember(Value = "Pdf")]
        Pdf = 11,

        /// <summary>
        /// Enum Xps for value: Xps
        /// </summary>
        [EnumMember(Value = "Xps")]
        Xps = 12,

        /// <summary>
        /// Enum Ppsx for value: Ppsx
        /// </summary>
        [EnumMember(Value = "Ppsx")]
        Ppsx = 13,

        /// <summary>
        /// Enum Tiff for value: Tiff
        /// </summary>
        [EnumMember(Value = "Tiff")]
        Tiff = 14,

        /// <summary>
        /// Enum Html for value: Html
        /// </summary>
        [EnumMember(Value = "Html")]
        Html = 15,

        /// <summary>
        /// Enum Swf for value: Swf
        /// </summary>
        [EnumMember(Value = "Swf")]
        Swf = 16,

        /// <summary>
        /// Enum Txt for value: Txt
        /// </summary>
        [EnumMember(Value = "Txt")]
        Txt = 17,

        /// <summary>
        /// Enum Doc for value: Doc
        /// </summary>
        [EnumMember(Value = "Doc")]
        Doc = 18,

        /// <summary>
        /// Enum Docx for value: Docx
        /// </summary>
        [EnumMember(Value = "Docx")]
        Docx = 19,

        /// <summary>
        /// Enum Bmp for value: Bmp
        /// </summary>
        [EnumMember(Value = "Bmp")]
        Bmp = 20,

        /// <summary>
        /// Enum Jpeg for value: Jpeg
        /// </summary>
        [EnumMember(Value = "Jpeg")]
        Jpeg = 21,

        /// <summary>
        /// Enum Png for value: Png
        /// </summary>
        [EnumMember(Value = "Png")]
        Png = 22,

        /// <summary>
        /// Enum Emf for value: Emf
        /// </summary>
        [EnumMember(Value = "Emf")]
        Emf = 23,

        /// <summary>
        /// Enum Wmf for value: Wmf
        /// </summary>
        [EnumMember(Value = "Wmf")]
        Wmf = 24,

        /// <summary>
        /// Enum Gif for value: Gif
        /// </summary>
        [EnumMember(Value = "Gif")]
        Gif = 25,

        /// <summary>
        /// Enum Exif for value: Exif
        /// </summary>
        [EnumMember(Value = "Exif")]
        Exif = 26,

        /// <summary>
        /// Enum Ico for value: Ico
        /// </summary>
        [EnumMember(Value = "Ico")]
        Ico = 27,

        /// <summary>
        /// Enum Svg for value: Svg
        /// </summary>
        [EnumMember(Value = "Svg")]
        Svg = 28

    }

}
