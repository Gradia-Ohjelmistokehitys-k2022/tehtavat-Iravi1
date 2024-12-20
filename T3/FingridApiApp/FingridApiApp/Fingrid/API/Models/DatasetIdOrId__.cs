// <auto-generated/>
#pragma warning disable CS0618
using Fingrid.API.Models.Record_string;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Fingrid.API.Models.Pick_TimeseriesDataPrivate.Exclude_keyofTimeseriesDataPrivate
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DatasetIdOrId__ : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Construct a type with a set of properties K of type T</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Fingrid.API.Models.Record_string.String_? AdditionalJson { get; set; }
#nullable restore
#else
        public global::Fingrid.API.Models.Record_string.String_ AdditionalJson { get; set; }
#endif
        /// <summary>The endTime property</summary>
        public DateTimeOffset? EndTime { get; set; }
        /// <summary>The modifiedAtUtc property</summary>
        public DateTimeOffset? ModifiedAtUtc { get; set; }
        /// <summary>The startTime property</summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary>The value property</summary>
        public double? Value { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Fingrid.API.Models.Pick_TimeseriesDataPrivate.Exclude_keyofTimeseriesDataPrivate.DatasetIdOrId__"/> and sets the default values.
        /// </summary>
        public DatasetIdOrId__()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Fingrid.API.Models.Pick_TimeseriesDataPrivate.Exclude_keyofTimeseriesDataPrivate.DatasetIdOrId__"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Fingrid.API.Models.Pick_TimeseriesDataPrivate.Exclude_keyofTimeseriesDataPrivate.DatasetIdOrId__ CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Fingrid.API.Models.Pick_TimeseriesDataPrivate.Exclude_keyofTimeseriesDataPrivate.DatasetIdOrId__();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "additionalJson", n => { AdditionalJson = n.GetObjectValue<global::Fingrid.API.Models.Record_string.String_>(global::Fingrid.API.Models.Record_string.String_.CreateFromDiscriminatorValue); } },
                { "endTime", n => { EndTime = n.GetDateTimeOffsetValue(); } },
                { "modifiedAtUtc", n => { ModifiedAtUtc = n.GetDateTimeOffsetValue(); } },
                { "startTime", n => { StartTime = n.GetDateTimeOffsetValue(); } },
                { "value", n => { Value = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Fingrid.API.Models.Record_string.String_>("additionalJson", AdditionalJson);
            writer.WriteDateTimeOffsetValue("endTime", EndTime);
            writer.WriteDateTimeOffsetValue("modifiedAtUtc", ModifiedAtUtc);
            writer.WriteDateTimeOffsetValue("startTime", StartTime);
            writer.WriteDoubleValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
