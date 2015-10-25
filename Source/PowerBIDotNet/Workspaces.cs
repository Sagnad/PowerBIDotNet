﻿using System;

namespace Infrastructure.PowerBI
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
            var workspace = new Workspace(tenantConfiguration, _communication);
            return workspace;
        }
    }
}
