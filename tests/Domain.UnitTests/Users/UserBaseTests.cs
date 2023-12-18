using Domain.UnitTests.Infrastructure;
using Domain.Users;
using Domain.Users.Events;
using FluentAssertions;

namespace Domain.UnitTests.Users;
public class UserBaseTests : BaseTest
{
    [Fact]
    public void Create_Should_Raise_UseCreatedDomainEvent()
    {
        // Arrange
        var firstName = new FirstName("first");
        var lastName = new LastName("last");
        var email = new Email("test@test.com");

        // Act
        var user = User.Create(firstName, lastName, email);

        // Assert
        var userCreatedDomainEvent = AssertDomainEventWasPublished<UserCreatedDomainEvent>(user);

        userCreatedDomainEvent.UserId.Should().Be(user.Id);
    }
}
