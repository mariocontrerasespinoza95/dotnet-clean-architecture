using Application.Abstractions.Messaging;

namespace Application.Users.LoginUser;
public sealed record LogInUserCommand(
    string Email, 
    string Password) : ICommand<AccessTokenResponse>;
