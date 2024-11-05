// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.GuestConfiguration
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class WirePathAttribute : Attribute
    {
        private string _wirePath;

        public WirePathAttribute(string wirePath)
        {
            _wirePath = wirePath;
        }

        public override string ToString()
        {
            return _wirePath;
        }
    }
}
