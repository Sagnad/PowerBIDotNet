﻿// Copyright (c) Microsoft. All rights reserved. 
// Licensed under the MIT license. See LICENSE file in the project root for full license information. 

using System;
using System.Collections.Generic;
using PowerBIDotNet.Wrappers;

namespace PowerBIDotNet
{
    /// <summary>
    /// Represents an implementation of <see cref="IDashboards"/>
    /// </summary>
    public class Dashboards : IDashboards
    {
        Token _token;
        ICommunication _communication;

        /// <summary>
        /// Initializes an instance of <see cref="Dashboards"/>
        /// </summary>
        /// <param name="token"><see cref="Token">Access token</see></param>
        /// <param name="communication"><see cref="ICommunication"/> for communicating with Power BI</param>
        public Dashboards(Token token, ICommunication communication)
        {
            _token = token;
            _communication = communication;
        }

#pragma warning disable 1591 // Xml Comments
        public IEnumerable<Dashboard> GetAll()
        {
            try
            {
                var dashboards = _communication.Get<DashboardsWrapper>(_token, "dashboards", "beta");
                return dashboards.Value;
            }
            catch
            {
                return new Dashboard[0];
            }
        }
#pragma warning restore 1591 // Xml Comments
    }
}
