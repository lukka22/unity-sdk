/**
* Copyright 2018 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using FullSerializer;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace  IBM.Watson.DeveloperCloud.Services.CompareComply.v1
{
    /// <summary>
    /// The original labeling from the input document, without the submitted feedback.
    /// </summary>
    [fsObject]
    public class OriginalLabelsOut
    {
        /// <summary>
        /// A string identifying the type of modification the feedback entry in the `updated_labels` array. Possible
        /// values are `added`, `not_changed`, and `removed`.
        /// </summary>
        public enum ModificationEnum
        {
            /// <summary>
            /// Enum added for added
            /// </summary>
            [EnumMember(Value = "added")]
            added,
            /// <summary>
            /// Enum notChanged for not_changed
            /// </summary>
            [EnumMember(Value = "not_changed")]
            not_changed,
            /// <summary>
            /// Enum removed for removed
            /// </summary>
            [EnumMember(Value = "removed")]
            removed
        }

        /// <summary>
        /// A string identifying the type of modification the feedback entry in the `updated_labels` array. Possible
        /// values are `added`, `not_changed`, and `removed`.
        /// </summary>
        [fsProperty("modification")]
        public ModificationEnum? Modification { get; set; }
        /// <summary>
        /// Description of the action specified by the element and whom it affects.
        /// </summary>
        [fsProperty("types")]
        public List<TypeLabel> Types { get; set; }
        /// <summary>
        /// List of functional categories into which the element falls; in other words, the subject matter of the
        /// element.
        /// </summary>
        [fsProperty("categories")]
        public List<Category> Categories { get; set; }
    }

}
