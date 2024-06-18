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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Slidize.Cloud.Sdk.Client;
using Slidize.Cloud.Sdk.Model;

namespace Slidize.Cloud.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISlidizeApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Converts files provided in the request body into target format and returns conversion result.
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
/// <param name="documents"></param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream Convert(ExportFormat format, List<System.IO.Stream> documents);

        /// <summary>
        /// Converts files provided in the request body into target format and returns conversion result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
/// <param name="documents"></param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> ConvertWithHttpInfo(ExportFormat format, List<System.IO.Stream> documents);
        /// <summary>
        /// Converts file provided in the request body into video.
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
/// <param name="options"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ConvertToVideo(System.IO.Stream document, VideoOptions? options = default(VideoOptions?));

        /// <summary>
        /// Converts file provided in the request body into video.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
/// <param name="options"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> ConvertToVideoWithHttpInfo(System.IO.Stream document, VideoOptions? options = default(VideoOptions?));
        /// <summary>
        /// Adds image watermarks and return result.
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
/// <param name="image"></param>
/// <param name="options"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ImageWatermark(List<System.IO.Stream> documents, System.IO.Stream image, ImageWatermarkOptions? options = default(ImageWatermarkOptions?));

        /// <summary>
        /// Adds image watermarks and return result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
/// <param name="image"></param>
/// <param name="options"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> ImageWatermarkWithHttpInfo(List<System.IO.Stream> documents, System.IO.Stream image, ImageWatermarkOptions? options = default(ImageWatermarkOptions?));
        /// <summary>
        /// Merges files provided in the request and saves the merge result into target format.
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
/// <param name="documents"></param>
/// <param name="options"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream Merge(ExportFormat format, List<System.IO.Stream> documents, MergeOptions? options = default(MergeOptions?));

        /// <summary>
        /// Merges files provided in the request and saves the merge result into target format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
/// <param name="documents"></param>
/// <param name="options"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> MergeWithHttpInfo(ExportFormat format, List<System.IO.Stream> documents, MergeOptions? options = default(MergeOptions?));
        /// <summary>
        /// Protects presentation with specified password and returns result.
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
/// <param name="options"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream Protect(System.IO.Stream document, ProtectionOptions? options = default(ProtectionOptions?));

        /// <summary>
        /// Protects presentation with specified password and returns result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
/// <param name="options"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> ProtectWithHttpInfo(System.IO.Stream document, ProtectionOptions? options = default(ProtectionOptions?));
        /// <summary>
        /// Remove annotations from presentation
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream RemoveAnnotations(System.IO.Stream document);

        /// <summary>
        /// Remove annotations from presentation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> RemoveAnnotationsWithHttpInfo(System.IO.Stream document);
        /// <summary>
        /// Remove macros from presentation
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream RemoveMacros(System.IO.Stream document);

        /// <summary>
        /// Remove macros from presentation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> RemoveMacrosWithHttpInfo(System.IO.Stream document);
        /// <summary>
        /// Replace text in presentation.
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
/// <param name="options"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ReplaceText(List<System.IO.Stream> documents, ReplaceTextOptions? options = default(ReplaceTextOptions?));

        /// <summary>
        /// Replace text in presentation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
/// <param name="options"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> ReplaceTextWithHttpInfo(List<System.IO.Stream> documents, ReplaceTextOptions? options = default(ReplaceTextOptions?));
        /// <summary>
        /// Splits presentation according to the specified slides range and saves result into target format.
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
/// <param name="document"></param>
/// <param name="options"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream Split(ExportFormat format, System.IO.Stream document, SplitOptions? options = default(SplitOptions?));

        /// <summary>
        /// Splits presentation according to the specified slides range and saves result into target format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
/// <param name="document"></param>
/// <param name="options"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> SplitWithHttpInfo(ExportFormat format, System.IO.Stream document, SplitOptions? options = default(SplitOptions?));
        /// <summary>
        /// Adds text watermarks and return result.
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
/// <param name="options"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream TextWatermark(List<System.IO.Stream> documents, TextWatermarkOptions? options = default(TextWatermarkOptions?));

        /// <summary>
        /// Adds text watermarks and return result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
/// <param name="options"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> TextWatermarkWithHttpInfo(List<System.IO.Stream> documents, TextWatermarkOptions? options = default(TextWatermarkOptions?));
        /// <summary>
        /// Removes password from the presentation and returns result.
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="password">Password to remove.</param>
/// <param name="document"></param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream Unprotect(string password, System.IO.Stream document);

        /// <summary>
        /// Removes password from the presentation and returns result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="password">Password to remove.</param>
/// <param name="document"></param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> UnprotectWithHttpInfo(string password, System.IO.Stream document);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISlidizeApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Converts files provided in the request body into target format and returns conversion result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
        /// <param name="documents"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> ConvertAsync(ExportFormat format, List<System.IO.Stream> documents,  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Converts files provided in the request body into target format and returns conversion result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
        /// <param name="documents"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> ConvertWithHttpInfoAsync(ExportFormat format, List<System.IO.Stream> documents,  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Converts file provided in the request body into video.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> ConvertToVideoAsync(System.IO.Stream document, VideoOptions? options = default(VideoOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Converts file provided in the request body into video.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> ConvertToVideoWithHttpInfoAsync(System.IO.Stream document, VideoOptions? options = default(VideoOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Adds image watermarks and return result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
        /// <param name="image"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> ImageWatermarkAsync(List<System.IO.Stream> documents, System.IO.Stream image, ImageWatermarkOptions? options = default(ImageWatermarkOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Adds image watermarks and return result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
        /// <param name="image"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> ImageWatermarkWithHttpInfoAsync(List<System.IO.Stream> documents, System.IO.Stream image, ImageWatermarkOptions? options = default(ImageWatermarkOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Merges files provided in the request and saves the merge result into target format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
        /// <param name="documents"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> MergeAsync(ExportFormat format, List<System.IO.Stream> documents, MergeOptions? options = default(MergeOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Merges files provided in the request and saves the merge result into target format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
        /// <param name="documents"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> MergeWithHttpInfoAsync(ExportFormat format, List<System.IO.Stream> documents, MergeOptions? options = default(MergeOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Protects presentation with specified password and returns result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> ProtectAsync(System.IO.Stream document, ProtectionOptions? options = default(ProtectionOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Protects presentation with specified password and returns result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> ProtectWithHttpInfoAsync(System.IO.Stream document, ProtectionOptions? options = default(ProtectionOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Remove annotations from presentation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> RemoveAnnotationsAsync(System.IO.Stream document,  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Remove annotations from presentation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> RemoveAnnotationsWithHttpInfoAsync(System.IO.Stream document,  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Remove macros from presentation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> RemoveMacrosAsync(System.IO.Stream document,  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Remove macros from presentation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> RemoveMacrosWithHttpInfoAsync(System.IO.Stream document,  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Replace text in presentation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> ReplaceTextAsync(List<System.IO.Stream> documents, ReplaceTextOptions? options = default(ReplaceTextOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Replace text in presentation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> ReplaceTextWithHttpInfoAsync(List<System.IO.Stream> documents, ReplaceTextOptions? options = default(ReplaceTextOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Splits presentation according to the specified slides range and saves result into target format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
        /// <param name="document"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> SplitAsync(ExportFormat format, System.IO.Stream document, SplitOptions? options = default(SplitOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Splits presentation according to the specified slides range and saves result into target format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
        /// <param name="document"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> SplitWithHttpInfoAsync(ExportFormat format, System.IO.Stream document, SplitOptions? options = default(SplitOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Adds text watermarks and return result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> TextWatermarkAsync(List<System.IO.Stream> documents, TextWatermarkOptions? options = default(TextWatermarkOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Adds text watermarks and return result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> TextWatermarkWithHttpInfoAsync(List<System.IO.Stream> documents, TextWatermarkOptions? options = default(TextWatermarkOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Removes password from the presentation and returns result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="password">Password to remove.</param>
        /// <param name="document"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> UnprotectAsync(string password, System.IO.Stream document,  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Removes password from the presentation and returns result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="password">Password to remove.</param>
        /// <param name="document"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> UnprotectWithHttpInfoAsync(string password, System.IO.Stream document,  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISlidizeApi : ISlidizeApiSync, ISlidizeApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SlidizeApi : ISlidizeApi
    {
        private Slidize.Cloud.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SlidizeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SlidizeApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlidizeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SlidizeApi(string basePath)
        {
            this.Configuration = Slidize.Cloud.Sdk.Client.Configuration.MergeConfigurations(
                Slidize.Cloud.Sdk.Client.GlobalConfiguration.Instance,
                new Slidize.Cloud.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Slidize.Cloud.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Slidize.Cloud.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Slidize.Cloud.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlidizeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SlidizeApi(Slidize.Cloud.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Slidize.Cloud.Sdk.Client.Configuration.MergeConfigurations(
                Slidize.Cloud.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Slidize.Cloud.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Slidize.Cloud.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Slidize.Cloud.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlidizeApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SlidizeApi(Slidize.Cloud.Sdk.Client.ISynchronousClient client, Slidize.Cloud.Sdk.Client.IAsynchronousClient asyncClient, Slidize.Cloud.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Slidize.Cloud.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Slidize.Cloud.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Slidize.Cloud.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Slidize.Cloud.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Slidize.Cloud.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Converts files provided in the request body into target format and returns conversion result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
/// <param name="documents"></param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream Convert(ExportFormat format, List<System.IO.Stream> documents)
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = ConvertWithHttpInfo(format, documents);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Converts files provided in the request body into target format and returns conversion result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
/// <param name="documents"></param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> ConvertWithHttpInfo(ExportFormat format, List<System.IO.Stream> documents)
        {
            // verify the required parameter 'documents' is set
            if (documents == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'documents' when calling SlidizeApi->Convert");
            }

            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("format", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(format)); // path parameter
            foreach (var file in documents)
            {
                localVarRequestOptions.FileParameters.Add("documents", file);
            }

            localVarRequestOptions.Operation = "SlidizeApi.Convert";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<System.IO.Stream>("/convert/{format}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Convert", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Converts files provided in the request body into target format and returns conversion result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
        /// <param name="documents"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> ConvertAsync(ExportFormat format, List<System.IO.Stream> documents,  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = await ConvertWithHttpInfoAsync(format, documents,  cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Converts files provided in the request body into target format and returns conversion result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
        /// <param name="documents"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream>> ConvertWithHttpInfoAsync(ExportFormat format, List<System.IO.Stream> documents, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'documents' is set
            if (documents == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'documents' when calling SlidizeApi->Convert");
            }


            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("format", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(format)); // path parameter
            foreach (var file in documents)
            {
                localVarRequestOptions.FileParameters.Add("documents", file);
            }

            localVarRequestOptions.Operation = "SlidizeApi.Convert";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<System.IO.Stream>("/convert/{format}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Convert", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Converts file provided in the request body into video. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
/// <param name="options"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream ConvertToVideo(System.IO.Stream document, VideoOptions? options = default(VideoOptions?))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = ConvertToVideoWithHttpInfo(document, options);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Converts file provided in the request body into video. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
/// <param name="options"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> ConvertToVideoWithHttpInfo(System.IO.Stream document, VideoOptions? options = default(VideoOptions?))
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'document' when calling SlidizeApi->ConvertToVideo");
            }

            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.FileParameters.Add("document", document);
            if (options != null)
            {
                localVarRequestOptions.FormParameters.Add("options", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(options)); // form parameter
            }

            localVarRequestOptions.Operation = "SlidizeApi.ConvertToVideo";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<System.IO.Stream>("/video", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConvertToVideo", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Converts file provided in the request body into video. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> ConvertToVideoAsync(System.IO.Stream document, VideoOptions? options = default(VideoOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = await ConvertToVideoWithHttpInfoAsync(document, options,  cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Converts file provided in the request body into video. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream>> ConvertToVideoWithHttpInfoAsync(System.IO.Stream document, VideoOptions? options = default(VideoOptions?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'document' when calling SlidizeApi->ConvertToVideo");
            }


            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.FileParameters.Add("document", document);
            if (options != null)
            {
                localVarRequestOptions.FormParameters.Add("options", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(options)); // form parameter
            }

            localVarRequestOptions.Operation = "SlidizeApi.ConvertToVideo";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<System.IO.Stream>("/video", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConvertToVideo", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Adds image watermarks and return result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
/// <param name="image"></param>
/// <param name="options"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream ImageWatermark(List<System.IO.Stream> documents, System.IO.Stream image, ImageWatermarkOptions? options = default(ImageWatermarkOptions?))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = ImageWatermarkWithHttpInfo(documents, image, options);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Adds image watermarks and return result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
/// <param name="image"></param>
/// <param name="options"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> ImageWatermarkWithHttpInfo(List<System.IO.Stream> documents, System.IO.Stream image, ImageWatermarkOptions? options = default(ImageWatermarkOptions?))
        {
            // verify the required parameter 'documents' is set
            if (documents == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'documents' when calling SlidizeApi->ImageWatermark");
            }

            // verify the required parameter 'image' is set
            if (image == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'image' when calling SlidizeApi->ImageWatermark");
            }

            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            foreach (var file in documents)
            {
                localVarRequestOptions.FileParameters.Add("documents", file);
            }
            localVarRequestOptions.FileParameters.Add("image", image);
            if (options != null)
            {
                localVarRequestOptions.FormParameters.Add("options", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(options)); // form parameter
            }

            localVarRequestOptions.Operation = "SlidizeApi.ImageWatermark";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<System.IO.Stream>("/watermark/image", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ImageWatermark", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Adds image watermarks and return result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
        /// <param name="image"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> ImageWatermarkAsync(List<System.IO.Stream> documents, System.IO.Stream image, ImageWatermarkOptions? options = default(ImageWatermarkOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = await ImageWatermarkWithHttpInfoAsync(documents, image, options,  cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Adds image watermarks and return result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
        /// <param name="image"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream>> ImageWatermarkWithHttpInfoAsync(List<System.IO.Stream> documents, System.IO.Stream image, ImageWatermarkOptions? options = default(ImageWatermarkOptions?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'documents' is set
            if (documents == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'documents' when calling SlidizeApi->ImageWatermark");
            }

            // verify the required parameter 'image' is set
            if (image == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'image' when calling SlidizeApi->ImageWatermark");
            }


            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            foreach (var file in documents)
            {
                localVarRequestOptions.FileParameters.Add("documents", file);
            }
            localVarRequestOptions.FileParameters.Add("image", image);
            if (options != null)
            {
                localVarRequestOptions.FormParameters.Add("options", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(options)); // form parameter
            }

            localVarRequestOptions.Operation = "SlidizeApi.ImageWatermark";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<System.IO.Stream>("/watermark/image", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ImageWatermark", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Merges files provided in the request and saves the merge result into target format. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
/// <param name="documents"></param>
/// <param name="options"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream Merge(ExportFormat format, List<System.IO.Stream> documents, MergeOptions? options = default(MergeOptions?))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = MergeWithHttpInfo(format, documents, options);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Merges files provided in the request and saves the merge result into target format. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
/// <param name="documents"></param>
/// <param name="options"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> MergeWithHttpInfo(ExportFormat format, List<System.IO.Stream> documents, MergeOptions? options = default(MergeOptions?))
        {
            // verify the required parameter 'documents' is set
            if (documents == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'documents' when calling SlidizeApi->Merge");
            }

            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("format", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(format)); // path parameter
            foreach (var file in documents)
            {
                localVarRequestOptions.FileParameters.Add("documents", file);
            }
            if (options != null)
            {
                localVarRequestOptions.FormParameters.Add("options", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(options)); // form parameter
            }

            localVarRequestOptions.Operation = "SlidizeApi.Merge";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<System.IO.Stream>("/merge/{format}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Merge", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Merges files provided in the request and saves the merge result into target format. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
        /// <param name="documents"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> MergeAsync(ExportFormat format, List<System.IO.Stream> documents, MergeOptions? options = default(MergeOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = await MergeWithHttpInfoAsync(format, documents, options,  cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Merges files provided in the request and saves the merge result into target format. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
        /// <param name="documents"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream>> MergeWithHttpInfoAsync(ExportFormat format, List<System.IO.Stream> documents, MergeOptions? options = default(MergeOptions?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'documents' is set
            if (documents == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'documents' when calling SlidizeApi->Merge");
            }


            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("format", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(format)); // path parameter
            foreach (var file in documents)
            {
                localVarRequestOptions.FileParameters.Add("documents", file);
            }
            if (options != null)
            {
                localVarRequestOptions.FormParameters.Add("options", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(options)); // form parameter
            }

            localVarRequestOptions.Operation = "SlidizeApi.Merge";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<System.IO.Stream>("/merge/{format}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Merge", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Protects presentation with specified password and returns result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
/// <param name="options"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream Protect(System.IO.Stream document, ProtectionOptions? options = default(ProtectionOptions?))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = ProtectWithHttpInfo(document, options);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Protects presentation with specified password and returns result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
/// <param name="options"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> ProtectWithHttpInfo(System.IO.Stream document, ProtectionOptions? options = default(ProtectionOptions?))
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'document' when calling SlidizeApi->Protect");
            }

            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.FileParameters.Add("document", document);
            if (options != null)
            {
                localVarRequestOptions.FormParameters.Add("options", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(options)); // form parameter
            }

            localVarRequestOptions.Operation = "SlidizeApi.Protect";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<System.IO.Stream>("/lock", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Protect", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Protects presentation with specified password and returns result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> ProtectAsync(System.IO.Stream document, ProtectionOptions? options = default(ProtectionOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = await ProtectWithHttpInfoAsync(document, options,  cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Protects presentation with specified password and returns result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream>> ProtectWithHttpInfoAsync(System.IO.Stream document, ProtectionOptions? options = default(ProtectionOptions?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'document' when calling SlidizeApi->Protect");
            }


            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.FileParameters.Add("document", document);
            if (options != null)
            {
                localVarRequestOptions.FormParameters.Add("options", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(options)); // form parameter
            }

            localVarRequestOptions.Operation = "SlidizeApi.Protect";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<System.IO.Stream>("/lock", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Protect", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove annotations from presentation 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream RemoveAnnotations(System.IO.Stream document)
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = RemoveAnnotationsWithHttpInfo(document);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove annotations from presentation 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> RemoveAnnotationsWithHttpInfo(System.IO.Stream document)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'document' when calling SlidizeApi->RemoveAnnotations");
            }

            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.FileParameters.Add("document", document);

            localVarRequestOptions.Operation = "SlidizeApi.RemoveAnnotations";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<System.IO.Stream>("/removeAnnotations", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveAnnotations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove annotations from presentation 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> RemoveAnnotationsAsync(System.IO.Stream document,  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = await RemoveAnnotationsWithHttpInfoAsync(document,  cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove annotations from presentation 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream>> RemoveAnnotationsWithHttpInfoAsync(System.IO.Stream document, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'document' when calling SlidizeApi->RemoveAnnotations");
            }


            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.FileParameters.Add("document", document);

            localVarRequestOptions.Operation = "SlidizeApi.RemoveAnnotations";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<System.IO.Stream>("/removeAnnotations", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveAnnotations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove macros from presentation 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream RemoveMacros(System.IO.Stream document)
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = RemoveMacrosWithHttpInfo(document);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove macros from presentation 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> RemoveMacrosWithHttpInfo(System.IO.Stream document)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'document' when calling SlidizeApi->RemoveMacros");
            }

            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.FileParameters.Add("document", document);

            localVarRequestOptions.Operation = "SlidizeApi.RemoveMacros";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<System.IO.Stream>("/removeMacros", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveMacros", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove macros from presentation 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> RemoveMacrosAsync(System.IO.Stream document,  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = await RemoveMacrosWithHttpInfoAsync(document,  cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove macros from presentation 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="document"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream>> RemoveMacrosWithHttpInfoAsync(System.IO.Stream document, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'document' when calling SlidizeApi->RemoveMacros");
            }


            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.FileParameters.Add("document", document);

            localVarRequestOptions.Operation = "SlidizeApi.RemoveMacros";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<System.IO.Stream>("/removeMacros", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveMacros", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Replace text in presentation. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
/// <param name="options"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream ReplaceText(List<System.IO.Stream> documents, ReplaceTextOptions? options = default(ReplaceTextOptions?))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = ReplaceTextWithHttpInfo(documents, options);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Replace text in presentation. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
/// <param name="options"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> ReplaceTextWithHttpInfo(List<System.IO.Stream> documents, ReplaceTextOptions? options = default(ReplaceTextOptions?))
        {
            // verify the required parameter 'documents' is set
            if (documents == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'documents' when calling SlidizeApi->ReplaceText");
            }

            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            foreach (var file in documents)
            {
                localVarRequestOptions.FileParameters.Add("documents", file);
            }
            if (options != null)
            {
                localVarRequestOptions.FormParameters.Add("options", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(options)); // form parameter
            }

            localVarRequestOptions.Operation = "SlidizeApi.ReplaceText";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<System.IO.Stream>("/replaceText", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReplaceText", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Replace text in presentation. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> ReplaceTextAsync(List<System.IO.Stream> documents, ReplaceTextOptions? options = default(ReplaceTextOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = await ReplaceTextWithHttpInfoAsync(documents, options,  cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Replace text in presentation. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream>> ReplaceTextWithHttpInfoAsync(List<System.IO.Stream> documents, ReplaceTextOptions? options = default(ReplaceTextOptions?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'documents' is set
            if (documents == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'documents' when calling SlidizeApi->ReplaceText");
            }


            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            foreach (var file in documents)
            {
                localVarRequestOptions.FileParameters.Add("documents", file);
            }
            if (options != null)
            {
                localVarRequestOptions.FormParameters.Add("options", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(options)); // form parameter
            }

            localVarRequestOptions.Operation = "SlidizeApi.ReplaceText";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<System.IO.Stream>("/replaceText", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReplaceText", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Splits presentation according to the specified slides range and saves result into target format. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
/// <param name="document"></param>
/// <param name="options"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream Split(ExportFormat format, System.IO.Stream document, SplitOptions? options = default(SplitOptions?))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = SplitWithHttpInfo(format, document, options);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Splits presentation according to the specified slides range and saves result into target format. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
/// <param name="document"></param>
/// <param name="options"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> SplitWithHttpInfo(ExportFormat format, System.IO.Stream document, SplitOptions? options = default(SplitOptions?))
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'document' when calling SlidizeApi->Split");
            }

            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("format", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(format)); // path parameter
            localVarRequestOptions.FileParameters.Add("document", document);
            if (options != null)
            {
                localVarRequestOptions.FormParameters.Add("options", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(options)); // form parameter
            }

            localVarRequestOptions.Operation = "SlidizeApi.Split";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<System.IO.Stream>("/split/{format}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Split", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Splits presentation according to the specified slides range and saves result into target format. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
        /// <param name="document"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> SplitAsync(ExportFormat format, System.IO.Stream document, SplitOptions? options = default(SplitOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = await SplitWithHttpInfoAsync(format, document, options,  cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Splits presentation according to the specified slides range and saves result into target format. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Output file format.</param>
        /// <param name="document"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream>> SplitWithHttpInfoAsync(ExportFormat format, System.IO.Stream document, SplitOptions? options = default(SplitOptions?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'document' when calling SlidizeApi->Split");
            }


            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("format", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(format)); // path parameter
            localVarRequestOptions.FileParameters.Add("document", document);
            if (options != null)
            {
                localVarRequestOptions.FormParameters.Add("options", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(options)); // form parameter
            }

            localVarRequestOptions.Operation = "SlidizeApi.Split";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<System.IO.Stream>("/split/{format}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Split", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Adds text watermarks and return result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
/// <param name="options"> (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream TextWatermark(List<System.IO.Stream> documents, TextWatermarkOptions? options = default(TextWatermarkOptions?))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = TextWatermarkWithHttpInfo(documents, options);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Adds text watermarks and return result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
/// <param name="options"> (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> TextWatermarkWithHttpInfo(List<System.IO.Stream> documents, TextWatermarkOptions? options = default(TextWatermarkOptions?))
        {
            // verify the required parameter 'documents' is set
            if (documents == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'documents' when calling SlidizeApi->TextWatermark");
            }

            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            foreach (var file in documents)
            {
                localVarRequestOptions.FileParameters.Add("documents", file);
            }
            if (options != null)
            {
                localVarRequestOptions.FormParameters.Add("options", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(options)); // form parameter
            }

            localVarRequestOptions.Operation = "SlidizeApi.TextWatermark";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<System.IO.Stream>("/watermark/text", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TextWatermark", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Adds text watermarks and return result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> TextWatermarkAsync(List<System.IO.Stream> documents, TextWatermarkOptions? options = default(TextWatermarkOptions?),  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = await TextWatermarkWithHttpInfoAsync(documents, options,  cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Adds text watermarks and return result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documents"></param>
        /// <param name="options"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream>> TextWatermarkWithHttpInfoAsync(List<System.IO.Stream> documents, TextWatermarkOptions? options = default(TextWatermarkOptions?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'documents' is set
            if (documents == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'documents' when calling SlidizeApi->TextWatermark");
            }


            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            foreach (var file in documents)
            {
                localVarRequestOptions.FileParameters.Add("documents", file);
            }
            if (options != null)
            {
                localVarRequestOptions.FormParameters.Add("options", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(options)); // form parameter
            }

            localVarRequestOptions.Operation = "SlidizeApi.TextWatermark";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<System.IO.Stream>("/watermark/text", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TextWatermark", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Removes password from the presentation and returns result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="password">Password to remove.</param>
/// <param name="document"></param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream Unprotect(string password, System.IO.Stream document)
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = UnprotectWithHttpInfo(password, document);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Removes password from the presentation and returns result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="password">Password to remove.</param>
/// <param name="document"></param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> UnprotectWithHttpInfo(string password, System.IO.Stream document)
        {
            // verify the required parameter 'password' is set
            if (password == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'password' when calling SlidizeApi->Unprotect");
            }

            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'document' when calling SlidizeApi->Unprotect");
            }

            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.HeaderParameters.Add("password", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(password)); // header parameter
            localVarRequestOptions.FileParameters.Add("document", document);

            localVarRequestOptions.Operation = "SlidizeApi.Unprotect";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<System.IO.Stream>("/unlock", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Unprotect", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Removes password from the presentation and returns result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="password">Password to remove.</param>
        /// <param name="document"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> UnprotectAsync(string password, System.IO.Stream document,  System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream> localVarResponse = await UnprotectWithHttpInfoAsync(password, document,  cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Removes password from the presentation and returns result. 
        /// </summary>
        /// <exception cref="Slidize.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="password">Password to remove.</param>
        /// <param name="document"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Slidize.Cloud.Sdk.Client.ApiResponse<System.IO.Stream>> UnprotectWithHttpInfoAsync(string password, System.IO.Stream document, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'password' is set
            if (password == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'password' when calling SlidizeApi->Unprotect");
            }

            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new Slidize.Cloud.Sdk.Client.ApiException(400, "Missing required parameter 'document' when calling SlidizeApi->Unprotect");
            }


            Slidize.Cloud.Sdk.Client.RequestOptions localVarRequestOptions = new Slidize.Cloud.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Slidize.Cloud.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.HeaderParameters.Add("password", Slidize.Cloud.Sdk.Client.ClientUtils.ParameterToString(password)); // header parameter
            localVarRequestOptions.FileParameters.Add("document", document);

            localVarRequestOptions.Operation = "SlidizeApi.Unprotect";
            //localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<System.IO.Stream>("/unlock", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Unprotect", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
