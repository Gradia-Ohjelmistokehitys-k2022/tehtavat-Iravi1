// <auto-generated/>
#pragma warning disable CS0618
using Fingrid.API.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Fingrid.API.Data
{
    /// <summary>
    /// Builds and executes requests for operations under \data
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DataRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Fingrid.API.Data.DataRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DataRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/data?datasets={datasets}{&endTime*,format*,locale*,oneRowPerTimePeriod*,page*,pageSize*,sortBy*,sortOrder*,startTime*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Fingrid.API.Data.DataRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DataRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/data?datasets={datasets}{&endTime*,format*,locale*,oneRowPerTimePeriod*,page*,pageSize*,sortBy*,sortOrder*,startTime*}", rawUrl)
        {
        }
        /// <summary>
        /// Get data for multiple datasets. Returns empty array if no data is found. If only part of requested datasets have data in generel or for requested timespan, those data are returned.
        /// </summary>
        /// <returns>A <see cref="global::Fingrid.API.Models.TimeseriesDataResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Fingrid.API.Models.ValidateError">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Fingrid.API.Models.TimeseriesDataResponse?> GetAsync(Action<RequestConfiguration<global::Fingrid.API.Data.DataRequestBuilder.DataRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Fingrid.API.Models.TimeseriesDataResponse> GetAsync(Action<RequestConfiguration<global::Fingrid.API.Data.DataRequestBuilder.DataRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::Fingrid.API.Models.ValidateError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Fingrid.API.Models.TimeseriesDataResponse>(requestInfo, global::Fingrid.API.Models.TimeseriesDataResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get data for multiple datasets. Returns empty array if no data is found. If only part of requested datasets have data in generel or for requested timespan, those data are returned.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Fingrid.API.Data.DataRequestBuilder.DataRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Fingrid.API.Data.DataRequestBuilder.DataRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Fingrid.API.Data.DataRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Fingrid.API.Data.DataRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Fingrid.API.Data.DataRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get data for multiple datasets. Returns empty array if no data is found. If only part of requested datasets have data in generel or for requested timespan, those data are returned.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DataRequestBuilderGetQueryParameters 
        {
            /// <summary>Comma-separated list of dataset ids</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("datasets")]
            public string? Datasets { get; set; }
#nullable restore
#else
            [QueryParameter("datasets")]
            public string Datasets { get; set; }
#endif
            /// <summary>Format - date-time (as date-time in RFC3339). Ending time up to which to query data. Timezone is optional, UTC is assumed if not provided. Response is always in UTC time. If you are using tester on this page use Example 1 format, if you are using curl use Example 2 format.</summary>
            [QueryParameter("endTime")]
            public DateTimeOffset? EndTime { get; set; }
            /// <summary>Response format. Either json, csv or xml. Default is json.</summary>
            [Obsolete("This property is deprecated, use FormatAsGetFormatQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("format")]
            public string? Format { get; set; }
#nullable restore
#else
            [QueryParameter("format")]
            public string Format { get; set; }
#endif
            /// <summary>Response format. Either json, csv or xml. Default is json.</summary>
            [QueryParameter("format")]
            public global::Fingrid.API.Data.GetFormatQueryParameterType? FormatAsGetFormatQueryParameterType { get; set; }
            /// <summary>Language for response. Used only if oneRowPerTimePeriod is true. Either en or fi. Default is en.</summary>
            [Obsolete("This property is deprecated, use LocaleAsGetLocaleQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("locale")]
            public string? Locale { get; set; }
#nullable restore
#else
            [QueryParameter("locale")]
            public string Locale { get; set; }
#endif
            /// <summary>Language for response. Used only if oneRowPerTimePeriod is true. Either en or fi. Default is en.</summary>
            [QueryParameter("locale")]
            public global::Fingrid.API.Data.GetLocaleQueryParameterType? LocaleAsGetLocaleQueryParameterType { get; set; }
            /// <summary>If true, returns one row per time period, instead of one row per observation. Result has an attribute for each requested dataset. Currently does not support XML. Default is false.</summary>
            [QueryParameter("oneRowPerTimePeriod")]
            public bool? OneRowPerTimePeriod { get; set; }
            /// <summary>Format - int32. Number of page. Default is 1.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>Format - int32. Number of results per page. Value can be between 1-20000. Default is 10.</summary>
            [QueryParameter("pageSize")]
            public int? PageSize { get; set; }
            [Obsolete("This property is deprecated, use SortByAsGetSortByQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sortBy")]
            public string? SortBy { get; set; }
#nullable restore
#else
            [QueryParameter("sortBy")]
            public string SortBy { get; set; }
#endif
            [QueryParameter("sortBy")]
            public global::Fingrid.API.Data.GetSortByQueryParameterType? SortByAsGetSortByQueryParameterType { get; set; }
            /// <summary>Order results in this direction. Either asc or desc. Default is asc.</summary>
            [Obsolete("This property is deprecated, use SortOrderAsGetSortOrderQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sortOrder")]
            public string? SortOrder { get; set; }
#nullable restore
#else
            [QueryParameter("sortOrder")]
            public string SortOrder { get; set; }
#endif
            /// <summary>Order results in this direction. Either asc or desc. Default is asc.</summary>
            [QueryParameter("sortOrder")]
            public global::Fingrid.API.Data.GetSortOrderQueryParameterType? SortOrderAsGetSortOrderQueryParameterType { get; set; }
            /// <summary>Format - date-time (as date-time in RFC3339). Starting time from which to query data. Timezone is optional, UTC is assumed if not provided. Response is always in UTC time. If you are using tester on this page use Example 1 format, if you are using curl use Example 2 format.</summary>
            [QueryParameter("startTime")]
            public DateTimeOffset? StartTime { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DataRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Fingrid.API.Data.DataRequestBuilder.DataRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
