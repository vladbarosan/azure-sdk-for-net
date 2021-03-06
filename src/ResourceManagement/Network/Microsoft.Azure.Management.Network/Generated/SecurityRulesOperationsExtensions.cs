// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for SecurityRulesOperations.
    /// </summary>
    public static partial class SecurityRulesOperationsExtensions
    {
            /// <summary>
            /// The delete network security rule operation deletes the specified network
            /// security rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            public static void Delete(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName)
            {
                Task.Factory.StartNew(s => ((ISecurityRulesOperations)s).DeleteAsync(resourceGroupName, networkSecurityGroupName, securityRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete network security rule operation deletes the specified network
            /// security rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The delete network security rule operation deletes the specified network
            /// security rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            public static void BeginDelete(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName)
            {
                Task.Factory.StartNew(s => ((ISecurityRulesOperations)s).BeginDeleteAsync(resourceGroupName, networkSecurityGroupName, securityRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete network security rule operation deletes the specified network
            /// security rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Get NetworkSecurityRule operation retrieves information about the
            /// specified network security rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            public static SecurityRule Get(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName)
            {
                return Task.Factory.StartNew(s => ((ISecurityRulesOperations)s).GetAsync(resourceGroupName, networkSecurityGroupName, securityRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get NetworkSecurityRule operation retrieves information about the
            /// specified network security rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SecurityRule> GetAsync(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put network security rule operation creates/updates a security rule in
            /// the specified network security group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            /// <param name='securityRuleParameters'>
            /// Parameters supplied to the create/update network security rule operation
            /// </param>
            public static SecurityRule CreateOrUpdate(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRule securityRuleParameters)
            {
                return Task.Factory.StartNew(s => ((ISecurityRulesOperations)s).CreateOrUpdateAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, securityRuleParameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put network security rule operation creates/updates a security rule in
            /// the specified network security group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            /// <param name='securityRuleParameters'>
            /// Parameters supplied to the create/update network security rule operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SecurityRule> CreateOrUpdateAsync(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRule securityRuleParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, securityRuleParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put network security rule operation creates/updates a security rule in
            /// the specified network security group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            /// <param name='securityRuleParameters'>
            /// Parameters supplied to the create/update network security rule operation
            /// </param>
            public static SecurityRule BeginCreateOrUpdate(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRule securityRuleParameters)
            {
                return Task.Factory.StartNew(s => ((ISecurityRulesOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, securityRuleParameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put network security rule operation creates/updates a security rule in
            /// the specified network security group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            /// <param name='securityRuleParameters'>
            /// Parameters supplied to the create/update network security rule operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SecurityRule> BeginCreateOrUpdateAsync(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRule securityRuleParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, securityRuleParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List network security rule operation retrieves all the security rules
            /// in a network security group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            public static IPage<SecurityRule> List(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName)
            {
                return Task.Factory.StartNew(s => ((ISecurityRulesOperations)s).ListAsync(resourceGroupName, networkSecurityGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List network security rule operation retrieves all the security rules
            /// in a network security group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SecurityRule>> ListAsync(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List network security rule operation retrieves all the security rules
            /// in a network security group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SecurityRule> ListNext(this ISecurityRulesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((ISecurityRulesOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List network security rule operation retrieves all the security rules
            /// in a network security group.
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
            public static async Task<IPage<SecurityRule>> ListNextAsync(this ISecurityRulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
