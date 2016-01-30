﻿// Copyright (c) Microsoft. All rights reserved. 
// Licensed under the MIT license. See LICENSE file in the project root for full license information. 

using System.Net;

namespace PowerBIDotNet
{
    /// <summary>
    /// Represents an implementation of <see cref="IWebRequestFactory"/>
    /// </summary>
    public class WebRequestFactory : IWebRequestFactory
    {
#pragma warning disable 1591 // Xml Comments
        public HttpWebRequest Create(string url)
        {
            return WebRequest.Create(url) as HttpWebRequest;
        }
#pragma warning restore 1591 // Xml Comments
    }
}