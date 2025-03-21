// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Prodvana.Inputs
{

    public sealed class GetReleaseChannelConvergenceProtectionRefArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Release Channel name
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("parameters")]
        private List<Inputs.GetReleaseChannelConvergenceProtectionRefParameterArgs>? _parameters;
        public List<Inputs.GetReleaseChannelConvergenceProtectionRefParameterArgs> Parameters
        {
            get => _parameters ?? (_parameters = new List<Inputs.GetReleaseChannelConvergenceProtectionRefParameterArgs>());
            set => _parameters = value;
        }

        public GetReleaseChannelConvergenceProtectionRefArgs()
        {
        }
        public static new GetReleaseChannelConvergenceProtectionRefArgs Empty => new GetReleaseChannelConvergenceProtectionRefArgs();
    }
}
