﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace LINGYUN.Abp.Webhooks;

public interface IDynamicWebhookDefinitionStore
{
    Task<WebhookDefinition> GetOrNullAsync(string name);

    Task<IReadOnlyList<WebhookDefinition>> GetWebhooksAsync();

    Task<IReadOnlyList<WebhookGroupDefinition>> GetGroupsAsync();
}
