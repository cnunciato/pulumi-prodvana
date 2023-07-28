// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Prodvana.Inputs
{

    public sealed class GetReleaseChannelReleaseChannelStablePreconditionInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// duration to wait for the release channel to be stable. A valid Go duration string, e.g. `10m` or `1h`. Defaults to `10m`
        /// </summary>
        [Input("duration", required: true)]
        public Input<string> Duration { get; set; } = null!;

        /// <summary>
        /// name of a release channel that must be in a stable deployment state
        /// </summary>
        [Input("releaseChannel", required: true)]
        public Input<string> ReleaseChannel { get; set; } = null!;

        public GetReleaseChannelReleaseChannelStablePreconditionInputArgs()
        {
        }
        public static new GetReleaseChannelReleaseChannelStablePreconditionInputArgs Empty => new GetReleaseChannelReleaseChannelStablePreconditionInputArgs();
    }
}
