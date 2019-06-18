// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Fabric.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EdgeGatewayPoolsOperations.
    /// </summary>
    public static partial class EdgeGatewayPoolsOperationsExtensions
    {
            /// <summary>
            /// Returns the requested edge gateway pool object.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='edgeGatewayPool'>
            /// Name of the edge gateway pool.
            /// </param>
            public static EdgeGatewayPool Get(this IEdgeGatewayPoolsOperations operations, string resourceGroupName, string location, string edgeGatewayPool)
            {
                return operations.GetAsync(resourceGroupName, location, edgeGatewayPool).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the requested edge gateway pool object.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='edgeGatewayPool'>
            /// Name of the edge gateway pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EdgeGatewayPool> GetAsync(this IEdgeGatewayPoolsOperations operations, string resourceGroupName, string location, string edgeGatewayPool, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, location, edgeGatewayPool, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of all edge gateway pool objects at a location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<EdgeGatewayPool> List(this IEdgeGatewayPoolsOperations operations, string resourceGroupName, string location, ODataQuery<EdgeGatewayPool> odataQuery = default(ODataQuery<EdgeGatewayPool>))
            {
                return operations.ListAsync(resourceGroupName, location, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of all edge gateway pool objects at a location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EdgeGatewayPool>> ListAsync(this IEdgeGatewayPoolsOperations operations, string resourceGroupName, string location, ODataQuery<EdgeGatewayPool> odataQuery = default(ODataQuery<EdgeGatewayPool>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, location, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of all edge gateway pool objects at a location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<EdgeGatewayPool> ListNext(this IEdgeGatewayPoolsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of all edge gateway pool objects at a location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EdgeGatewayPool>> ListNextAsync(this IEdgeGatewayPoolsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}