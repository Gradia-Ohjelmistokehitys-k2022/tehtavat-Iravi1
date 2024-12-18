// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Fingrid.API.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod_ : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Fingrid.API.Models.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod_.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod__data>? Data { get; set; }
#nullable restore
#else
        public List<global::Fingrid.API.Models.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod_.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod__data> Data { get; set; }
#endif
        /// <summary>The pagination property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Fingrid.API.Models.IPagination? Pagination { get; set; }
#nullable restore
#else
        public global::Fingrid.API.Models.IPagination Pagination { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Fingrid.API.Models.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod_"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Fingrid.API.Models.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod_ CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Fingrid.API.Models.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod_();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "data", n => { Data = n.GetCollectionOfObjectValues<global::Fingrid.API.Models.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod_.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod__data>(global::Fingrid.API.Models.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod_.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod__data.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pagination", n => { Pagination = n.GetObjectValue<global::Fingrid.API.Models.IPagination>(global::Fingrid.API.Models.IPagination.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Fingrid.API.Models.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod_.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod__data>("data", Data);
            writer.WriteObjectValue<global::Fingrid.API.Models.IPagination>("pagination", Pagination);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Fingrid.API.Models.TimeseriesData"/>, <see cref="global::Fingrid.API.Models.TimeseriesDataOneRowPerTimePeriod"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod__data : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Fingrid.API.Models.TimeseriesData"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Fingrid.API.Models.TimeseriesData? TimeseriesData { get; set; }
#nullable restore
#else
            public global::Fingrid.API.Models.TimeseriesData TimeseriesData { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Fingrid.API.Models.TimeseriesDataOneRowPerTimePeriod"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Fingrid.API.Models.TimeseriesDataOneRowPerTimePeriod? TimeseriesDataOneRowPerTimePeriod { get; set; }
#nullable restore
#else
            public global::Fingrid.API.Models.TimeseriesDataOneRowPerTimePeriod TimeseriesDataOneRowPerTimePeriod { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Fingrid.API.Models.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod_.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod__data"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Fingrid.API.Models.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod_.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod__data CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Fingrid.API.Models.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod_.IWithPagination_TimeseriesDataOrTimeseriesDataOneRowPerTimePeriod__data();
                result.TimeseriesData = new global::Fingrid.API.Models.TimeseriesData();
                result.TimeseriesDataOneRowPerTimePeriod = new global::Fingrid.API.Models.TimeseriesDataOneRowPerTimePeriod();
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(TimeseriesData != null || TimeseriesDataOneRowPerTimePeriod != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(TimeseriesData, TimeseriesDataOneRowPerTimePeriod);
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                writer.WriteObjectValue<global::Fingrid.API.Models.TimeseriesData>(null, TimeseriesData, TimeseriesDataOneRowPerTimePeriod);
            }
        }
    }
}
#pragma warning restore CS0618