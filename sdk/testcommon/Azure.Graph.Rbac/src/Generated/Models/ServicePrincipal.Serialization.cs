// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class ServicePrincipal
    {
        internal static ServicePrincipal DeserializeServicePrincipal(JsonElement element)
        {
            bool? accountEnabled = default;
            IReadOnlyList<string> alternativeNames = default;
            string appDisplayName = default;
            string appId = default;
            string appOwnerTenantId = default;
            bool? appRoleAssignmentRequired = default;
            IReadOnlyList<AppRole> appRoles = default;
            string displayName = default;
            string errorUrl = default;
            string homepage = default;
            IReadOnlyList<KeyCredential> keyCredentials = default;
            string logoutUrl = default;
            IReadOnlyList<OAuth2Permission> oauth2Permissions = default;
            IReadOnlyList<PasswordCredential> passwordCredentials = default;
            string preferredTokenSigningKeyThumbprint = default;
            string publisherName = default;
            IReadOnlyList<string> replyUrls = default;
            string samlMetadataUrl = default;
            IReadOnlyList<string> servicePrincipalNames = default;
            string servicePrincipalType = default;
            IReadOnlyList<string> tags = default;
            string objectId = default;
            string objectType = default;
            DateTimeOffset? deletionTimestamp = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("alternativeNames"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    alternativeNames = array;
                    continue;
                }
                if (property.NameEquals("appDisplayName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appOwnerTenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appOwnerTenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appRoleAssignmentRequired"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appRoleAssignmentRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("appRoles"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppRole> array = new List<AppRole>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(AppRole.DeserializeAppRole(item));
                        }
                    }
                    appRoles = array;
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("homepage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    homepage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyCredentials"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KeyCredential> array = new List<KeyCredential>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(KeyCredential.DeserializeKeyCredential(item));
                        }
                    }
                    keyCredentials = array;
                    continue;
                }
                if (property.NameEquals("logoutUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logoutUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("oauth2Permissions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OAuth2Permission> array = new List<OAuth2Permission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(OAuth2Permission.DeserializeOAuth2Permission(item));
                        }
                    }
                    oauth2Permissions = array;
                    continue;
                }
                if (property.NameEquals("passwordCredentials"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PasswordCredential> array = new List<PasswordCredential>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(PasswordCredential.DeserializePasswordCredential(item));
                        }
                    }
                    passwordCredentials = array;
                    continue;
                }
                if (property.NameEquals("preferredTokenSigningKeyThumbprint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preferredTokenSigningKeyThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisherName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replyUrls"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    replyUrls = array;
                    continue;
                }
                if (property.NameEquals("samlMetadataUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    samlMetadataUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("servicePrincipalNames"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    servicePrincipalNames = array;
                    continue;
                }
                if (property.NameEquals("servicePrincipalType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    servicePrincipalType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    tags = array;
                    continue;
                }
                if (property.NameEquals("objectId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    objectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deletionTimestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletionTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    additionalPropertiesDictionary.Add(property.Name, null);
                }
                else
                {
                    additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
                }
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ServicePrincipal(objectId, objectType, deletionTimestamp, additionalProperties, accountEnabled, alternativeNames, appDisplayName, appId, appOwnerTenantId, appRoleAssignmentRequired, appRoles, displayName, errorUrl, homepage, keyCredentials, logoutUrl, oauth2Permissions, passwordCredentials, preferredTokenSigningKeyThumbprint, publisherName, replyUrls, samlMetadataUrl, servicePrincipalNames, servicePrincipalType, tags);
        }
    }
}
