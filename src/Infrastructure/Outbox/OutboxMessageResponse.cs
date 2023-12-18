﻿namespace Infrastructure.Outbox;

internal sealed record OutboxMessageResponse(
    Guid Id,
    string Content);