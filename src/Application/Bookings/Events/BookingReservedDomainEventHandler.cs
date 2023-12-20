using Domain.Bookings.Events;
using MediatR;

namespace Application.Bookings.Events;
internal sealed class BookingReservedDomainEventHandler : INotificationHandler<BookingReservedDomainEvent>
{

    public Task Handle(BookingReservedDomainEvent notification, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
