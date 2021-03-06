// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using MigAz.Core.Interface;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigAz.Azure.Arm
{
    public class VirtualNetworkGateway : ArmResource, IVirtualNetworkGateway
    {
        private VirtualNetworkGateway() : base(null, null) { }

        public VirtualNetworkGateway(AzureSubscription azureSubscription, JToken resourceToken) : base(azureSubscription, resourceToken)
        {
        }

        public new async Task InitializeChildrenAsync()
        {
            await base.InitializeChildrenAsync();
        }



        public override string ToString()
        {
            return this.Name;
        }
    }
}

