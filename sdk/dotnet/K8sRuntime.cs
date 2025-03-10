// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Prodvana
{
    /// <summary>
    /// This resource allows you to manage a Prodvana Kubernetes [Runtime](https://docs.prodvana.io/docs/prodvana-concepts#runtime). You are responsible for managing the agent lifetime. Also see `prodvana.ManagedK8sRuntime`.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Prodvana = Pulumi.Prodvana;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var example = new Prodvana.K8sRuntime("example");
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// ```sh
    ///  $ pulumi import prodvana:index/k8sRuntime:K8sRuntime example &lt;runtime name&gt;
    /// ```
    /// </summary>
    [ProdvanaResourceType("prodvana:index/k8sRuntime:K8sRuntime")]
    public partial class K8sRuntime : global::Pulumi.CustomResource
    {
        /// <summary>
        /// API Token used for linking the Kubernetes Prodvana agent
        /// </summary>
        [Output("agentApiToken")]
        public Output<string> AgentApiToken { get; private set; } = null!;

        /// <summary>
        /// Runtime name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a K8sRuntime resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public K8sRuntime(string name, K8sRuntimeArgs? args = null, CustomResourceOptions? options = null)
            : base("prodvana:index/k8sRuntime:K8sRuntime", name, args ?? new K8sRuntimeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private K8sRuntime(string name, Input<string> id, K8sRuntimeState? state = null, CustomResourceOptions? options = null)
            : base("prodvana:index/k8sRuntime:K8sRuntime", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/prodvana",
                AdditionalSecretOutputs =
                {
                    "agentApiToken",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing K8sRuntime resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static K8sRuntime Get(string name, Input<string> id, K8sRuntimeState? state = null, CustomResourceOptions? options = null)
        {
            return new K8sRuntime(name, id, state, options);
        }
    }

    public sealed class K8sRuntimeArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Runtime name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public K8sRuntimeArgs()
        {
        }
        public static new K8sRuntimeArgs Empty => new K8sRuntimeArgs();
    }

    public sealed class K8sRuntimeState : global::Pulumi.ResourceArgs
    {
        [Input("agentApiToken")]
        private Input<string>? _agentApiToken;

        /// <summary>
        /// API Token used for linking the Kubernetes Prodvana agent
        /// </summary>
        public Input<string>? AgentApiToken
        {
            get => _agentApiToken;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _agentApiToken = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Runtime name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public K8sRuntimeState()
        {
        }
        public static new K8sRuntimeState Empty => new K8sRuntimeState();
    }
}
