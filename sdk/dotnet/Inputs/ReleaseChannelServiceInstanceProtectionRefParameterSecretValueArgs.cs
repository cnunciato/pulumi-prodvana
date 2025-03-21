// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Prodvana.Inputs
{

    public sealed class ReleaseChannelServiceInstanceProtectionRefParameterSecretValueArgs : global::Pulumi.ResourceArgs
    {
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Current application version
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public ReleaseChannelServiceInstanceProtectionRefParameterSecretValueArgs()
        {
        }
        public static new ReleaseChannelServiceInstanceProtectionRefParameterSecretValueArgs Empty => new ReleaseChannelServiceInstanceProtectionRefParameterSecretValueArgs();
    }
}
