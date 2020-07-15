// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.AspNetCore.Components.Web.Extensions
{
    internal struct TagElement : IHeadElement
    {
        public string Type => "tag";

        public string TagName { get; }

        public IReadOnlyDictionary<string, object>? Attributes { get; set; }

        public TagElement(string tagName)
        {
            TagName = tagName;
            Attributes = null;
        }
    }
}