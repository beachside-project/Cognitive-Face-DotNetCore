﻿//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license.
//
// Microsoft Cognitive Services (formerly Project Oxford): https://www.microsoft.com/cognitive-services
//
// Microsoft Cognitive Services (formerly Project Oxford) GitHub:
// https://github.com/Microsoft/Cognitive-Face-DotNetCore/
//
// Copyright (c) Microsoft Corporation
// All rights reserved.
//
// MIT License:
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace Microsoft.ProjectOxford.Face.Contract
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Hair color type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HairColorType
    {
        /// <summary>
        /// unknown
        /// </summary>
        Unknown,

        /// <summary>
        /// White
        /// </summary>
        White,

        /// <summary>
        /// Gray
        /// </summary>
        Gray,

        /// <summary>
        /// Blond
        /// </summary>
        Blond,

        /// <summary>
        /// Brown
        /// </summary>
        Brown,

        /// <summary>
        /// Red
        /// </summary>
        Red,

        /// <summary>
        /// Black
        /// </summary>
        Black,

        /// <summary>
        /// Other
        /// </summary>
        Other
    }

    /// <summary>
    /// Face HiarColor class contains hair color information
    /// </summary>
    public class HairColor
    {
        /// <summary>
        /// Indicating the hair color type
        /// </summary>
        public HairColorType Color
        {
            get; set;
        }

        /// <summary>
        /// Indicating the confidence for hair color type
        /// </summary>
        public double Confidence
        {
            get; set;
        }
    }

    /// <summary>
    /// Face Hair class contains hair information
    /// </summary>
    public class Hair
    {
        #region Properties

        /// <summary>
        /// Indicating the confidence of a bald head
        /// </summary>
        public double Bald
        {
            get; set;
        }

        /// <summary>
        /// Indicating whether hair is occluded or not
        /// </summary>
        public bool Invisible
        {
            get; set;
        }

        /// <summary>
        /// Indicating all possible hair colors with confidences
        /// </summary>
        public HairColor[] HairColor
        {
            get; set;
        }

        #endregion Properties
    }
}