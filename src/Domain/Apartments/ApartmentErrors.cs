using Domain.Abstractions;

namespace Domain.Apartments;

public static class ApartmentErrors
{
    public static readonly Error NotFound = new(
        "Property.Found",
        "The property with the specified identifier was not found");
}
