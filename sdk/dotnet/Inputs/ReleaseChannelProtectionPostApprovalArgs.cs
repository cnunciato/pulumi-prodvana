// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Prodvana.Inputs
{

    public sealed class ReleaseChannelProtectionPostApprovalArgs : global::Pulumi.ResourceArgs
    {
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        public ReleaseChannelProtectionPostApprovalArgs()
        {
        }
        public static new ReleaseChannelProtectionPostApprovalArgs Empty => new ReleaseChannelProtectionPostApprovalArgs();
    }
}
