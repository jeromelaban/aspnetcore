﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Security.Cryptography;

namespace Microsoft.AspNet.Security.DataProtection
{
    internal static class ExceptionExtensions
    {
        /// <summary>
        /// Determines whether an exception must be homogenized by being wrapped inside a
        /// CryptographicException before being rethrown.
        /// </summary>
        public static bool RequiresHomogenization(this Exception ex)
        {
            return !(ex is CryptographicException);
        }
    }
}
