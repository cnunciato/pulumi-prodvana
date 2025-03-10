// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Prodvana.Inputs
{

    public sealed class ReleaseChannelManualApprovalPreconditionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// description of the manual approval
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// whether this approval is required for every convergence action, or just the first
        /// </summary>
        [Input("everyAction")]
        public Input<bool>? EveryAction { get; set; }

        /// <summary>
        /// name of the manual approval
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public ReleaseChannelManualApprovalPreconditionGetArgs()
        {
        }
        public static new ReleaseChannelManualApprovalPreconditionGetArgs Empty => new ReleaseChannelManualApprovalPreconditionGetArgs();
    }
}
