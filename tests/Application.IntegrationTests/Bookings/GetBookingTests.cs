using Application.Bookings.GetBooking;
using Application.IntegrationTests.Infrastructure;
using Domain.Abstractions;
using Domain.Bookings;
using FluentAssertions;

namespace Application.IntegrationTests.Bookings;

public class GetBookingTests : BaseIntegrationTest
{
    private static readonly Guid BookingId = Guid.NewGuid();

    public GetBookingTests(IntegrationTestWebAppFactory factory)
        : base(factory)
    {
    }

    [Fact]
    public async Task GetBooking_ShouldReturnFailure_WhenBookingIsNotFound()
    {
        // Arrange
        var query = new GetBookingQuery(BookingId);

        // Act
        Result<BookingResponse> result = await Sender.Send(query);

        // Assert
        result.Error.Should().Be(BookingErrors.NotFound);
    }
}
