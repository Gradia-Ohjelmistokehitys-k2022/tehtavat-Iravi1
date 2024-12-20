// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Fingrid.API.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ValidateError : ApiException, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The fields property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Fingrid.API.Models.FieldErrors? Fields { get; set; }
#nullable restore
#else
        public global::Fingrid.API.Models.FieldErrors Fields { get; set; }
#endif
        /// <summary>The primary error message.</summary>
        public override string Message { get => MessageEscaped ?? string.Empty; }
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessageEscaped { get; set; }
#nullable restore
#else
        public string MessageEscaped { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The stack property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Stack { get; set; }
#nullable restore
#else
        public string Stack { get; set; }
#endif
        /// <summary>The status property</summary>
        public double? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Fingrid.API.Models.ValidateError"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Fingrid.API.Models.ValidateError CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Fingrid.API.Models.ValidateError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "fields", n => { Fields = n.GetObjectValue<global::Fingrid.API.Models.FieldErrors>(global::Fingrid.API.Models.FieldErrors.CreateFromDiscriminatorValue); } },
                { "message", n => { MessageEscaped = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "stack", n => { Stack = n.GetStringValue(); } },
                { "status", n => { Status = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Fingrid.API.Models.FieldErrors>("fields", Fields);
            writer.WriteStringValue("message", MessageEscaped);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("stack", Stack);
            writer.WriteDoubleValue("status", Status);
        }
    }
}
#pragma warning restore CS0618
