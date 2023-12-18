using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Outbox;

public sealed class OutboxMessage
{
    public OutboxMessage(
        Guid id,
        DateTime ocurredOnUtc,
        string type,
        string content)
    {
        Id = id;
        OcurredOnUtc = ocurredOnUtc;
        Type = type;
        Content = content;
    }

    public Guid Id { get; private set; }

    public DateTime OcurredOnUtc { get; private set; }

    public string Type { get; private set; }

    public string Content { get; private set; }

    public DateTime? ProcessedOnUtc { get; private set; }

    public string? Error { get; private set; }
}
