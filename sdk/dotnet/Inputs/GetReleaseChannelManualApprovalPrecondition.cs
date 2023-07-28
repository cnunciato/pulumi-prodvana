// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Prodvana.Inputs
{

    public sealed class GetReleaseChannelManualApprovalPreconditionArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// description of the manual approval
        /// </summary>
        [Input("description")]
        public string? Description { get; set; }

        /// <summary>
        /// whether to require manual approval for every action, or just the first
        /// </summary>
        [Input("everyAction")]
        public bool? EveryAction { get; set; }

        /// <summary>
        /// name of the manual approval
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetReleaseChannelManualApprovalPreconditionArgs()
        {
        }
        public static new GetReleaseChannelManualApprovalPreconditionArgs Empty => new GetReleaseChannelManualApprovalPreconditionArgs();
    }
}
