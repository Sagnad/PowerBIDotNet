﻿// Copyright (c) Microsoft. All rights reserved. 
// Licensed under the MIT license. See LICENSE file in the project root for full license information. 

using System;

namespace PowerBIDotNet
{
    /// <summary>
    /// Represents the tokens of interest in the OAUTH scheme
    /// </summary>
    public class Tokens
    {
        /// <summary>
        /// Gets or sets the access <see cref="Token">token</see>
        /// </summary>
        public Token AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the refresh <see cref="Token">token</see> used when one needs to refresh the token
        /// </summary>
        public Token RefreshToken { get; set; }

        /// <summary>
        /// Gets or sets the time in which the Access Token returned expires.
        /// This value is calculated based on the current UTC time measured locally and the 
        /// value expires in received from the service
        /// </summary>
        public DateTimeOffset ExpiresOn { get; set; }
    }
}
