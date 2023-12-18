using Application.Abstractions.Messaging;
using Domain.Abstractions;
using Infrastructure;
using System.Reflection;

namespace ArchitectureTests;

public class BaseTest
{
    protected static Assembly ApplicationAssembly => typeof(IBaseCommand).Assembly;

    protected static Assembly DomainAssembly => typeof(IEntity).Assembly;

    protected static Assembly InfrastructureAssembly => typeof(ApplicationDbContext).Assembly;
}
