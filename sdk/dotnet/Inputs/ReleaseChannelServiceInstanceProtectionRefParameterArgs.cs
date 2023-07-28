// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Prodvana.Inputs
{

    public sealed class ReleaseChannelServiceInstanceProtectionRefParameterArgs : global::Pulumi.ResourceArgs
    {
        [Input("dockerImageTagValue")]
        public Input<string>? DockerImageTagValue { get; set; }

        [Input("intValue")]
        public Input<int>? IntValue { get; set; }

        /// <summary>
        /// Release Channel name
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("secretValue")]
        public Input<Inputs.ReleaseChannelServiceInstanceProtectionRefParameterSecretValueArgs>? SecretValue { get; set; }

        [Input("stringValue")]
        public Input<string>? StringValue { get; set; }

        public ReleaseChannelServiceInstanceProtectionRefParameterArgs()
        {
        }
        public static new ReleaseChannelServiceInstanceProtectionRefParameterArgs Empty => new ReleaseChannelServiceInstanceProtectionRefParameterArgs();
    }
}
