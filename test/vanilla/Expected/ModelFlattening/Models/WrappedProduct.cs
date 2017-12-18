// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.ModelFlattening.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The wrapped produc.
    /// </summary>
    public partial class WrappedProduct
    {
        /// <summary>
        /// Initializes a new instance of the WrappedProduct class.
        /// </summary>
        public WrappedProduct()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WrappedProduct class.
        /// </summary>
        /// <param name="value">the product value</param>
        public WrappedProduct(string value = default(string))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the product value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}