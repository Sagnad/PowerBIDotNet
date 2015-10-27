﻿// Copyright (c) Microsoft. All rights reserved. 
// Licensed under the MIT license. See LICENSE file in the project root for full license information. 

using System;

namespace PowerBIDotNet
{
    public class Workspaces : IWorkspaces
    {
        ICommunication _communication;
        IConfigurationForTenants _configurationForTenants;

        public Workspaces(ICommunication communication, IConfigurationForTenants configurationForTenants)
        {
            _communication = communication;
            _configurationForTenants = configurationForTenants;
        }

        public IWorkspace GetFor(Tenant tenant)
        {
            var tenantConfiguration = _configurationForTenants.GetFor(tenant);
            var workspace = new Workspace(tenantConfiguration.AccessToken, _communication);
            return workspace;
        }
    }
}
