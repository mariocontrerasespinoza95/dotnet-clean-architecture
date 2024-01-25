using Application.Bookings.ConfirmBooking;
using Application.IntegrationTests.Infrastructure;
using Domain.Abstractions;
using Domain.Bookings;
using FluentAssertions;

namespace Application.IntegrationTests.Bookings;

public class ConfirmBookingTests : BaseIntegrationTest
{
    private static readonly Guid BookingId = Guid.NewGuid();

    public ConfirmBookingTests(IntegrationTestWebAppFactory factory)
        : base(factory)
    {
    }

    [Fact]
    public async Task ConfirmBooking_ShouldReturnFailure_WhenBookingIsNotFound()
    {
        // Arrange
        var command = new ConfirmBookingCommand(BookingId);

        // Act
        Result result = await Sender.Send(command);

        // Assert
        result.Error.Should().Be(BookingErrors.NotFound);
    }
}
