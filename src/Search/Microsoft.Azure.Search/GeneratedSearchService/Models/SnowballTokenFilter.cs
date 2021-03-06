// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A filter that stems words using a Snowball-generated stemmer. This
    /// token filter is implemented using Apache Lucene.
    /// <see href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/snowball/SnowballFilter.html" />
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.SnowballTokenFilter")]
    public partial class SnowballTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the SnowballTokenFilter class.
        /// </summary>
        public SnowballTokenFilter() { }

        /// <summary>
        /// Initializes a new instance of the SnowballTokenFilter class.
        /// </summary>
        public SnowballTokenFilter(string name, SnowballTokenFilterLanguage language)
            : base(name)
        {
            Language = language;
        }

        /// <summary>
        /// Gets or sets the language to use. Possible values include:
        /// 'armenian', 'basque', 'catalan', 'danish', 'dutch', 'english',
        /// 'finnish', 'french', 'german', 'german2', 'hungarian', 'italian',
        /// 'kp', 'lovins', 'norwegian', 'porter', 'portuguese', 'romanian',
        /// 'russian', 'spanish', 'swedish', 'turkish'
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public SnowballTokenFilterLanguage Language { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
